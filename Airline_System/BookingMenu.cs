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
    public partial class BookingMenu : Form
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

        private Label lblSuccessBooking;
        private Label lblFailBooking;
        private Label lblFailCustId;
        private Label lblFailFlightId;
        private RichTextBox richTextBox1;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        MainMenu main;

        public BookingMenu()
        {
            InitializeComponent();
        }
        public BookingMenu(MainMenu x)
        {
            main = x;
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBookCustView = new System.Windows.Forms.RichTextBox();
            this.txtBookFlightView = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDCustBooking = new System.Windows.Forms.TextBox();
            this.txtIDFlightBooking = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblSuccessBooking = new System.Windows.Forms.Label();
            this.lblFailBooking = new System.Windows.Forms.Label();
            this.lblFailCustId = new System.Windows.Forms.Label();
            this.lblFailFlightId = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(361, 666);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Queens Inc. ©";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(339, 39);
            this.label6.TabIndex = 20;
            this.label6.Text = "Airline System Booking";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(120, 588);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 32);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Vladimir Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(92)))));
            this.label7.Location = new System.Drawing.Point(576, -2);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 78);
            this.label7.TabIndex = 19;
            this.label7.Text = "Queens♚";
            // 
            // txtBookCustView
            // 
            this.txtBookCustView.Location = new System.Drawing.Point(17, 79);
            this.txtBookCustView.Name = "txtBookCustView";
            this.txtBookCustView.ReadOnly = true;
            this.txtBookCustView.Size = new System.Drawing.Size(375, 274);
            this.txtBookCustView.TabIndex = 21;
            this.txtBookCustView.Text = "";
            // 
            // txtBookFlightView
            // 
            this.txtBookFlightView.Location = new System.Drawing.Point(418, 79);
            this.txtBookFlightView.Name = "txtBookFlightView";
            this.txtBookFlightView.ReadOnly = true;
            this.txtBookFlightView.Size = new System.Drawing.Size(370, 274);
            this.txtBookFlightView.TabIndex = 22;
            this.txtBookFlightView.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customer ID to book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Flight ID to book";
            // 
            // txtIDCustBooking
            // 
            this.txtIDCustBooking.Location = new System.Drawing.Point(167, 405);
            this.txtIDCustBooking.Name = "txtIDCustBooking";
            this.txtIDCustBooking.Size = new System.Drawing.Size(225, 20);
            this.txtIDCustBooking.TabIndex = 25;
            // 
            // txtIDFlightBooking
            // 
            this.txtIDFlightBooking.Location = new System.Drawing.Point(167, 462);
            this.txtIDFlightBooking.Name = "txtIDFlightBooking";
            this.txtIDFlightBooking.Size = new System.Drawing.Size(225, 20);
            this.txtIDFlightBooking.TabIndex = 26;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.btnBook.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(121, 532);
            this.btnBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(128, 32);
            this.btnBook.TabIndex = 27;
            this.btnBook.Text = "Submit Booking";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click_1);
            // 
            // lblSuccessBooking
            // 
            this.lblSuccessBooking.AutoSize = true;
            this.lblSuccessBooking.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccessBooking.ForeColor = System.Drawing.Color.Green;
            this.lblSuccessBooking.Location = new System.Drawing.Point(178, 495);
            this.lblSuccessBooking.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSuccessBooking.Name = "lblSuccessBooking";
            this.lblSuccessBooking.Size = new System.Drawing.Size(0, 13);
            this.lblSuccessBooking.TabIndex = 28;
            // 
            // lblFailBooking
            // 
            this.lblFailBooking.AutoSize = true;
            this.lblFailBooking.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFailBooking.ForeColor = System.Drawing.Color.Red;
            this.lblFailBooking.Location = new System.Drawing.Point(182, 495);
            this.lblFailBooking.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFailBooking.Name = "lblFailBooking";
            this.lblFailBooking.Size = new System.Drawing.Size(0, 13);
            this.lblFailBooking.TabIndex = 29;
            // 
            // lblFailCustId
            // 
            this.lblFailCustId.AutoSize = true;
            this.lblFailCustId.ForeColor = System.Drawing.Color.Salmon;
            this.lblFailCustId.Location = new System.Drawing.Point(543, 388);
            this.lblFailCustId.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFailCustId.Name = "lblFailCustId";
            this.lblFailCustId.Size = new System.Drawing.Size(0, 13);
            this.lblFailCustId.TabIndex = 30;
            // 
            // lblFailFlightId
            // 
            this.lblFailFlightId.AutoSize = true;
            this.lblFailFlightId.ForeColor = System.Drawing.Color.Salmon;
            this.lblFailFlightId.Location = new System.Drawing.Point(543, 430);
            this.lblFailFlightId.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblFailFlightId.Name = "lblFailFlightId";
            this.lblFailFlightId.Size = new System.Drawing.Size(0, 13);
            this.lblFailFlightId.TabIndex = 31;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(418, 370);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(370, 274);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = "";
            // 
            // BookingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(820, 703);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblFailFlightId);
            this.Controls.Add(this.lblFailCustId);
            this.Controls.Add(this.lblFailBooking);
            this.Controls.Add(this.lblSuccessBooking);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.txtIDFlightBooking);
            this.Controls.Add(this.txtIDCustBooking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBookFlightView);
            this.Controls.Add(this.txtBookCustView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 465);
            this.Name = "BookingMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BookingMenu";
            this.Load += new System.EventHandler(this.BookingMenu_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtBookCustView;
        private System.Windows.Forms.RichTextBox txtBookFlightView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDCustBooking;
        private System.Windows.Forms.TextBox txtIDFlightBooking;
        private System.Windows.Forms.Button btnBook;
    
    private void BookingMenu_Load(object sender, EventArgs e)
        {
            // txtBookCustView.Text = Program.ac.customerList();
            // txtBookFlightView.Text = Program.ac.flightList();
        }
        public bool checkInteger(TextBox t)
        {
            int a;
            return int.TryParse(t.Text, out a);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            main.Show();
            Close();
        }

        private void BookingMenu_Load_1(object sender, EventArgs e)
        {
            lblSuccessBooking.Text = "";
            lblFailBooking.Text = "";
            lblFailFlightId.Text = "";
            lblSuccessBooking.Text = "";

            txtBookCustView.Text = Program.ac.customerList();
            txtBookFlightView.Text = Program.ac.flightList();
            richTextBox1.Text = Program.ac.viewBookingList();
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





        private void btnBook_Click_1(object sender, EventArgs e)
        {

            lblSuccessBooking.Text = "";
            lblFailBooking.Text = "";
            lblFailFlightId.Text = "";
            lblSuccessBooking.Text = "";

            if (checkInteger(txtIDCustBooking))
            {
                if (checkInteger(txtIDFlightBooking))
                {
                    int custId = Convert.ToInt32(txtIDCustBooking.Text);
                    int flightId = Convert.ToInt32(txtIDFlightBooking.Text);

                    if (Program.ac.addBook(custId, flightId))
                    {
                        lblSuccessBooking.Text = "Successfully added booking!";
                        txtIDCustBooking.Clear();
                        txtIDFlightBooking.Clear();
                    }
                    else
                    {
                     lblFailBooking.Text = "Flight already full or does not exist!";
                    }
                }
                else
                {
                    lblFailBooking.Text = "Please enter correct flight Id!";
                   txtIDFlightBooking.Clear();
                }
            }
            else
            {
                lblFailBooking.Text = "Please enter correct customer Id!";
              txtIDCustBooking.Clear();
            }

            richTextBox1.Text = Program.ac.viewBookingList();

        }
    }

}

    
   

