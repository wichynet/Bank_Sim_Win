namespace Bank_Sim_Win
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnCreateNewAccount = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCreateIbanNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDeposite = new System.Windows.Forms.Button();
            this.txtDepoIbanNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepoAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtToIbanNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtFromIbanNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTransferAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(336, 168);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.btnCreateNewAccount);
            this.tabPage1.Controls.Add(this.txtFullName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtCreateIbanNumber);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(328, 142);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create new account";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(100, 120);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(208, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "For generate the new IBAN No., click here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // btnCreateNewAccount
            // 
            this.btnCreateNewAccount.Location = new System.Drawing.Point(100, 76);
            this.btnCreateNewAccount.Name = "btnCreateNewAccount";
            this.btnCreateNewAccount.Size = new System.Drawing.Size(124, 23);
            this.btnCreateNewAccount.TabIndex = 3;
            this.btnCreateNewAccount.Text = "Create new account";
            this.btnCreateNewAccount.UseVisualStyleBackColor = true;
            this.btnCreateNewAccount.Click += new System.EventHandler(this.BtnCreateNewAccount_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(100, 23);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(139, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name:";
            // 
            // txtCreateIbanNumber
            // 
            this.txtCreateIbanNumber.Location = new System.Drawing.Point(100, 49);
            this.txtCreateIbanNumber.Name = "txtCreateIbanNumber";
            this.txtCreateIbanNumber.Size = new System.Drawing.Size(139, 20);
            this.txtCreateIbanNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IBAN No.: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeposite);
            this.tabPage2.Controls.Add(this.txtDepoIbanNumber);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtDepoAmount);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(328, 142);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Deposite Money";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeposite
            // 
            this.btnDeposite.Location = new System.Drawing.Point(100, 76);
            this.btnDeposite.Name = "btnDeposite";
            this.btnDeposite.Size = new System.Drawing.Size(124, 23);
            this.btnDeposite.TabIndex = 9;
            this.btnDeposite.Text = "Deposite";
            this.btnDeposite.UseVisualStyleBackColor = true;
            this.btnDeposite.Click += new System.EventHandler(this.BtnDeposite_Click);
            // 
            // txtDepoIbanNumber
            // 
            this.txtDepoIbanNumber.Location = new System.Drawing.Point(100, 23);
            this.txtDepoIbanNumber.Name = "txtDepoIbanNumber";
            this.txtDepoIbanNumber.Size = new System.Drawing.Size(139, 20);
            this.txtDepoIbanNumber.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "IBAN No.:";
            // 
            // txtDepoAmount
            // 
            this.txtDepoAmount.Location = new System.Drawing.Point(100, 49);
            this.txtDepoAmount.Name = "txtDepoAmount";
            this.txtDepoAmount.Size = new System.Drawing.Size(139, 20);
            this.txtDepoAmount.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Deposite Amount";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtToIbanNumber);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btnTransfer);
            this.tabPage3.Controls.Add(this.txtFromIbanNumber);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtTransferAmount);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(328, 142);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transfer Money";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtToIbanNumber
            // 
            this.txtToIbanNumber.Location = new System.Drawing.Point(100, 49);
            this.txtToIbanNumber.Name = "txtToIbanNumber";
            this.txtToIbanNumber.Size = new System.Drawing.Size(139, 20);
            this.txtToIbanNumber.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "To IBAN No.:";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(100, 102);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(124, 23);
            this.btnTransfer.TabIndex = 14;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.BtnTransfer_Click);
            // 
            // txtFromIbanNumber
            // 
            this.txtFromIbanNumber.Location = new System.Drawing.Point(100, 23);
            this.txtFromIbanNumber.Name = "txtFromIbanNumber";
            this.txtFromIbanNumber.Size = new System.Drawing.Size(139, 20);
            this.txtFromIbanNumber.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "From IBAN No.:";
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.Location = new System.Drawing.Point(100, 75);
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.Size = new System.Drawing.Size(139, 20);
            this.txtTransferAmount.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Transfer Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 189);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Bank Simulator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCreateIbanNumber;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateNewAccount;
        private System.Windows.Forms.Button btnDeposite;
        private System.Windows.Forms.TextBox txtDepoIbanNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepoAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToIbanNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtFromIbanNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTransferAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

