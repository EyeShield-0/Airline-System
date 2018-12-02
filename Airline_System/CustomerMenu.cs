using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_System
{
    public partial class CustomerMenu : Form
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
        MainMenu main;

        public CustomerMenu()
        {
            InitializeComponent();
        }
        public CustomerMenu(MainMenu m)
        {
            main = m;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblOutFailAdd = new System.Windows.Forms.Label();
            this.lblOutSuccessAdd = new System.Windows.Forms.Label();
            this.txtPNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblFailDelCust = new System.Windows.Forms.Label();
            this.txtOutputSuccess = new System.Windows.Forms.Label();
            this.txtIdCust = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelCust = new System.Windows.Forms.Button();
            this.txtBoxCustView = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-4, 65);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(624, 258);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lblOutFailAdd);
            this.tabPage1.Controls.Add(this.lblOutSuccessAdd);
            this.tabPage1.Controls.Add(this.txtPNumber);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnAddCust);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtLName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtFName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(616, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  Add";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblOutFailAdd
            // 
            this.lblOutFailAdd.AutoSize = true;
            this.lblOutFailAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutFailAdd.ForeColor = System.Drawing.Color.Red;
            this.lblOutFailAdd.Location = new System.Drawing.Point(230, 213);
            this.lblOutFailAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutFailAdd.Name = "lblOutFailAdd";
            this.lblOutFailAdd.Size = new System.Drawing.Size(0, 13);
            this.lblOutFailAdd.TabIndex = 12;
            // 
            // lblOutSuccessAdd
            // 
            this.lblOutSuccessAdd.AutoSize = true;
            this.lblOutSuccessAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutSuccessAdd.ForeColor = System.Drawing.Color.Green;
            this.lblOutSuccessAdd.Location = new System.Drawing.Point(218, 213);
            this.lblOutSuccessAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutSuccessAdd.Name = "lblOutSuccessAdd";
            this.lblOutSuccessAdd.Size = new System.Drawing.Size(0, 13);
            this.lblOutSuccessAdd.TabIndex = 11;
            // 
            // txtPNumber
            // 
            this.txtPNumber.Location = new System.Drawing.Point(267, 122);
            this.txtPNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPNumber.Name = "txtPNumber";
            this.txtPNumber.Size = new System.Drawing.Size(214, 20);
            this.txtPNumber.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone Number";
            // 
            // btnAddCust
            // 
            this.btnAddCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.btnAddCust.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.ForeColor = System.Drawing.Color.White;
            this.btnAddCust.Location = new System.Drawing.Point(261, 174);
            this.btnAddCust.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(90, 32);
            this.btnAddCust.TabIndex = 3;
            this.btnAddCust.Text = "Submit";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(267, 89);
            this.txtLName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(214, 20);
            this.txtLName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(267, 56);
            this.txtFName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(214, 20);
            this.txtFName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblFailDelCust);
            this.tabPage2.Controls.Add(this.txtOutputSuccess);
            this.tabPage2.Controls.Add(this.txtIdCust);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnDelCust);
            this.tabPage2.Controls.Add(this.txtBoxCustView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(616, 232);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delete/View";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblFailDelCust
            // 
            this.lblFailDelCust.AutoSize = true;
            this.lblFailDelCust.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFailDelCust.ForeColor = System.Drawing.Color.Red;
            this.lblFailDelCust.Location = new System.Drawing.Point(230, 213);
            this.lblFailDelCust.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFailDelCust.Name = "lblFailDelCust";
            this.lblFailDelCust.Size = new System.Drawing.Size(0, 13);
            this.lblFailDelCust.TabIndex = 5;
            // 
            // txtOutputSuccess
            // 
            this.txtOutputSuccess.AutoSize = true;
            this.txtOutputSuccess.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputSuccess.ForeColor = System.Drawing.Color.Green;
            this.txtOutputSuccess.Location = new System.Drawing.Point(218, 213);
            this.txtOutputSuccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtOutputSuccess.Name = "txtOutputSuccess";
            this.txtOutputSuccess.Size = new System.Drawing.Size(0, 13);
            this.txtOutputSuccess.TabIndex = 4;
            // 
            // txtIdCust
            // 
            this.txtIdCust.Location = new System.Drawing.Point(209, 180);
            this.txtIdCust.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdCust.Name = "txtIdCust";
            this.txtIdCust.Size = new System.Drawing.Size(89, 20);
            this.txtIdCust.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID";
            // 
            // btnDelCust
            // 
            this.btnDelCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.btnDelCust.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelCust.ForeColor = System.Drawing.Color.White;
            this.btnDelCust.Location = new System.Drawing.Point(313, 173);
            this.btnDelCust.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelCust.Name = "btnDelCust";
            this.btnDelCust.Size = new System.Drawing.Size(129, 32);
            this.btnDelCust.TabIndex = 1;
            this.btnDelCust.Text = "Delete Customer";
            this.btnDelCust.UseVisualStyleBackColor = false;
            this.btnDelCust.Click += new System.EventHandler(this.btnDelCust_Click);
            // 
            // txtBoxCustView
            // 
            this.txtBoxCustView.BackColor = System.Drawing.Color.White;
            this.txtBoxCustView.Location = new System.Drawing.Point(5, 4);
            this.txtBoxCustView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxCustView.Name = "txtBoxCustView";
            this.txtBoxCustView.ReadOnly = true;
            this.txtBoxCustView.Size = new System.Drawing.Size(585, 157);
            this.txtBoxCustView.TabIndex = 0;
            this.txtBoxCustView.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(265, 361);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Queens Inc. ©";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(240, 327);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 32);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(362, 39);
            this.label6.TabIndex = 10;
            this.label6.Text = "Airline System Customer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Vladimir Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(92)))));
            this.label7.Location = new System.Drawing.Point(372, -2);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 78);
            this.label7.TabIndex = 9;
            this.label7.Text = "Queens♚";
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(600, 406);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomerMenu";
            this.Load += new System.EventHandler(this.CustomerMenu_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDelCust;
        private System.Windows.Forms.RichTextBox txtBoxCustView;
        private System.Windows.Forms.TextBox txtPNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdCust;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label6;
        private Label txtOutputSuccess;
        private Label lblOutSuccessAdd;
        private Label lblOutFailAdd;
        private Label lblFailDelCust;
        private System.Windows.Forms.Label label7;

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            string firstName = txtFName.Text;
            string lastName = txtLName.Text;
            string phone = txtPNumber.Text;

            lblOutFailAdd.Text = "";
            lblOutSuccessAdd.Text = "";

            if (Program.ac.addCustomer(firstName, lastName, phone))
            {

                lblOutSuccessAdd.Text = "Successfully added customer!";
            }
            else
            {
                lblOutFailAdd.Text = "Failed to add customer!";
            }

            txtFName.Clear();
            txtLName.Clear();
            txtPNumber.Clear();

            txtBoxCustView.Text = Program.ac.customerList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            main.Show();
            Close();
        }

        public bool checkInteger(TextBox t)
        {
            int a;
            return int.TryParse(t.Text, out a);

        }

        private void btnDelCust_Click(object sender, EventArgs e)
        {
            lblFailDelCust.Text = "";
            txtOutputSuccess.Text = "";
            if (checkInteger(txtIdCust))
            {
                int custId = Convert.ToInt32(txtIdCust.Text);

                if (Program.ac.deleteCustomer(custId))
                {
                    txtBoxCustView.Text = Program.ac.customerList();
                    txtOutputSuccess.Text = "Successfully deleted customer!";
                }
                else
                {
                    lblFailDelCust.Text = "Customer Id not in the found!";
                }
            }
            else
            {
                lblFailDelCust.Text = "Please enter an integer!";
            }

            txtIdCust.Clear();
        }

        private void CustomerMenu_Load_1(object sender, EventArgs e)
        {
            txtBoxCustView.Text = Program.ac.customerList();
            this.MouseDown += Main_MouseDown;

        }





        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Main_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }










        private void tabPage1_Click(object sender, EventArgs e)
        {
            lblOutFailAdd.Text = "";
            lblOutSuccessAdd.Text = "";
            lblFailDelCust.Text = "";
            txtOutputSuccess.Text = "";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            lblOutFailAdd.Text = "";
            lblOutSuccessAdd.Text = "";
            lblFailDelCust.Text = "";
            txtOutputSuccess.Text = "";
        }
    }

   /* private void btnSubmitCust_Click(object sender, EventArgs e)
        {
            string firstName = txtCustName.Text;
            string lastName = txtCustLName.Text;
            string phone = txtPhone.Text;

            if (Program.ac.addCustomer(firstName, lastName, phone))
            {
                txtboxCust.Text = "Success\n";
            }

            txtCustName.Clear();
            txtCustLName.Clear();
            txtPhone.Clear();

            txtboxCust.Text = Program.ac.customerList();
        }


        private void btnBackCustAdd_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
        }

        
    }*/
}
