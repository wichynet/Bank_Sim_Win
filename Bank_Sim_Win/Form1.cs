using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

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

            //string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Bank.mdf;Integrated Security=True";
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wicha\source\repos\Bank_Sim_Win\Bank_Sim_Win\Bank.mdf;Integrated Security=True";
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

            MessageBox.Show("Created the new account completely", "COMPLETED");
        }

        private void BtnDeposite_Click(object sender, EventArgs e)
        {
            double amount;

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
            else if(!Double.TryParse(txtDepoIbanNumber.Text, out amount))            
            {
                MessageBox.Show("Please enter the amount in number", "ERROR");

                return;
            }
        }
    }
}
