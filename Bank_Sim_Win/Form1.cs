using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Bank_Sim_Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://randomiban.com/?country=Netherlands");
        }

        private void BtnCreateNewAccount_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFullName.Text) || String.IsNullOrEmpty(txtCreateIbanNumber.Text))
            {
                MessageBox.Show("Please enter your full name and IBAN number", "ERROR");

                return;
            }
            else if (txtCreateIbanNumber.Text.Trim().Length != 18)
            {
                MessageBox.Show("Please enter the valid IBAN number", "ERROR");

                return;
            }

            string connString = ConfigurationManager.ConnectionStrings["Bank_Sim_Win"].ConnectionString;
            string cmdString = "SELECT * FROM Customer WHERE IBAN = '" + txtCreateIbanNumber.Text.Trim() + "'";

            BankDataSet ds = new BankDataSet();
            DataTable customerTable = ds.Tables["Customer"];

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand comm = new SqlCommand(cmdString, conn))
                {
                    conn.Open();
                    customerTable.Load(comm.ExecuteReader());

                    if(customerTable.Rows.Count > 0)
                    {
                        MessageBox.Show("Found the existing IBAN in the records", "ERROR");

                        return;
                    }
                }
            }

            cmdString = "INSERT INTO Customer(IBAN, FullName, Amount) VALUES('" + txtCreateIbanNumber.Text + 
                                "', '" + txtFullName.Text + "', 0.0)";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand comm = new SqlCommand(cmdString, conn))
                {
                    try
                    {
                        conn.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch(SqlException ex)
                    {
                        MessageBox.Show("ERROR: " + ex.Message, "ERROR");
                    }
                }
            }

            MessageBox.Show("Created the new account successfully", "COMPLETED");
        }

        private void BtnDeposite_Click(object sender, EventArgs e)
        {
            double amount = 0.0;

            if (String.IsNullOrEmpty(txtDepoIbanNumber.Text) || String.IsNullOrEmpty(txtDepoAmount.Text))
            {
                MessageBox.Show("Please enter IBAN number and amount to deposite", "ERROR");

                return;
            }
            else if (txtDepoIbanNumber.Text.Trim().Length != 18)
            {
                MessageBox.Show("Please enter the valid IBAN number", "ERROR");

                return;
            }
            else if(!Double.TryParse(txtDepoAmount.Text, out amount))            
            {
                MessageBox.Show("Please enter the amount in number", "ERROR");

                return;
            }

            string connString = ConfigurationManager.ConnectionStrings["Bank_Sim_Win"].ConnectionString;
            string cmdString = "SELECT * FROM Customer WHERE IBAN = '" + txtDepoIbanNumber.Text.Trim() + "'";

            BankDataSet ds = new BankDataSet();
            DataTable customerTable = ds.Tables["Customer"];

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand comm = new SqlCommand(cmdString, conn))
                {
                    try
                    {
                        conn.Open();
                        customerTable.Load(comm.ExecuteReader());

                        if (customerTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Not found the existing IBAN in the records, cannot deposite", "ERROR");

                            return;
                        }
                        else
                        {
                            cmdString = "UPDATE Customer SET Amount = Amount + " + amount + " WHERE IBAN = '" + txtDepoIbanNumber.Text.Trim() + "'";
                            using (SqlCommand commUpdate = new SqlCommand(cmdString, conn))
                            {
                                commUpdate.ExecuteNonQuery();
                            }                                

                            MessageBox.Show("Deposite " + amount.ToString() + " to IBAN " + txtDepoIbanNumber.Text + " successfully", "COMPLETED");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("ERROR: " + ex.Message, "ERROR");
                    }
                }
            }
        }

        private void BtnTransfer_Click(object sender, EventArgs e)
        {
            double amountToTransfer = 0.0;

            if (String.IsNullOrEmpty(txtFromIbanNumber.Text) || String.IsNullOrEmpty(txtToIbanNumber.Text) || String.IsNullOrEmpty(txtTransferAmount.Text))
            {
                MessageBox.Show("Please enter IBAN numbers and amount to transfer", "ERROR");

                return;
            }
            else if ((txtFromIbanNumber.Text.Trim().Length != 18) || (txtToIbanNumber.Text.Trim().Length != 18))
            {
                MessageBox.Show("Please enter the valid IBAN number(s)", "ERROR");

                return;
            }
            else if (!Double.TryParse(txtTransferAmount.Text, out amountToTransfer))
            {
                MessageBox.Show("Please enter the amount in number", "ERROR");

                return;
            }
            else if(txtFromIbanNumber.Text.Trim() == txtToIbanNumber.Text.Trim())
            {
                MessageBox.Show("Cannot transfer within the same IBAN accounts", "ERROR");

                return;
            }

            string connString = ConfigurationManager.ConnectionStrings["Bank_Sim_Win"].ConnectionString;
            string cmdString = "SELECT * FROM Customer WHERE IBAN in ('" + txtFromIbanNumber.Text.Trim() + "','" + txtToIbanNumber.Text.Trim() + "')";
            BankDataSet ds = new BankDataSet();
            DataTable customerTable = ds.Tables["Customer"];

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand comm = new SqlCommand(cmdString, conn))
                {
                    conn.Open();
                    customerTable.Load(comm.ExecuteReader());

                    if (customerTable.Rows.Count == 0)
                    {
                        MessageBox.Show("Not found the existing IBAN(s) in the records, cannot deposite", "ERROR");

                        return;
                    }
                    else
                    {
                        var row = customerTable.Select("IBAN = '" + txtFromIbanNumber.Text.Trim() + "'");
                        double currentAmount = Convert.ToDouble(row[0][2]);

                        if(currentAmount < amountToTransfer)
                        {
                            MessageBox.Show("Not enought money to transfer, the current amount is " + currentAmount.ToString(), "ERROR");

                            return;
                        }
                        else
                        {
                            cmdString = "UPDATE Customer SET Amount = Amount - " + amountToTransfer + " WHERE IBAN = '" + txtFromIbanNumber.Text.Trim() + "'";
                            using (SqlCommand commUpdate = new SqlCommand(cmdString, conn))
                            {
                                commUpdate.ExecuteNonQuery();
                            }

                            cmdString = "UPDATE Customer SET Amount = Amount + " + amountToTransfer + " WHERE IBAN = '" + txtToIbanNumber.Text.Trim() + "'";
                            using (SqlCommand commUpdate = new SqlCommand(cmdString, conn))
                            {
                                commUpdate.ExecuteNonQuery();
                            }

                            MessageBox.Show("Transfer money amount " + amountToTransfer.ToString() + " from " + txtFromIbanNumber.Text.Trim() + 
                                            " to " + txtToIbanNumber.Text.Trim() + " successfully", "COMPLETED");
                        }
                    }
                }
            }
         }
    }
}
