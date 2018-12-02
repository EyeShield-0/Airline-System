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
    public partial class FlightMenu : Form
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

        public FlightMenu()
        {
            InitializeComponent();
        }

        public FlightMenu(MainMenu x)
        {
            main = x;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtBoxFlightView = new System.Windows.Forms.RichTextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSeats = new System.Windows.Forms.TextBox();
            this.txtIdFlight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelFlight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblSuccessFlight = new System.Windows.Forms.Label();
            this.lblFailAddFlight = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblFailDelFlight = new System.Windows.Forms.Label();
            this.lblSucDelFlight = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
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
            this.label7.TabIndex = 14;
            this.label7.Text = "Queens♚";
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
            // txtBoxFlightView
            // 
            this.txtBoxFlightView.BackColor = System.Drawing.Color.White;
            this.txtBoxFlightView.Location = new System.Drawing.Point(5, 4);
            this.txtBoxFlightView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxFlightView.Name = "txtBoxFlightView";
            this.txtBoxFlightView.ReadOnly = true;
            this.txtBoxFlightView.Size = new System.Drawing.Size(585, 157);
            this.txtBoxFlightView.TabIndex = 0;
            this.txtBoxFlightView.Text = "";
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(267, 106);
            this.txtOrigin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(215, 20);
            this.txtOrigin.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Origin";
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.btnAddFlight.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.ForeColor = System.Drawing.Color.White;
            this.btnAddFlight.Location = new System.Drawing.Point(261, 174);
            this.btnAddFlight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(90, 32);
            this.btnAddFlight.TabIndex = 4;
            this.btnAddFlight.Text = "Submit";
            this.btnAddFlight.UseVisualStyleBackColor = false;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max Seats";
            // 
            // txtMSeats
            // 
            this.txtMSeats.Location = new System.Drawing.Point(267, 72);
            this.txtMSeats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMSeats.Name = "txtMSeats";
            this.txtMSeats.Size = new System.Drawing.Size(214, 20);
            this.txtMSeats.TabIndex = 1;
            // 
            // txtIdFlight
            // 
            this.txtIdFlight.Location = new System.Drawing.Point(209, 180);
            this.txtIdFlight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdFlight.Name = "txtIdFlight";
            this.txtIdFlight.Size = new System.Drawing.Size(89, 20);
            this.txtIdFlight.TabIndex = 3;
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
            // btnDelFlight
            // 
            this.btnDelFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.btnDelFlight.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelFlight.ForeColor = System.Drawing.Color.White;
            this.btnDelFlight.Location = new System.Drawing.Point(313, 173);
            this.btnDelFlight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelFlight.Name = "btnDelFlight";
            this.btnDelFlight.Size = new System.Drawing.Size(129, 32);
            this.btnDelFlight.TabIndex = 1;
            this.btnDelFlight.Text = "Delete Flight";
            this.btnDelFlight.UseVisualStyleBackColor = false;
            this.btnDelFlight.Click += new System.EventHandler(this.btnDelFlight_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Flight Number";
            // 
            // txtFNumber
            // 
            this.txtFNumber.Location = new System.Drawing.Point(268, 37);
            this.txtFNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFNumber.Name = "txtFNumber";
            this.txtFNumber.Size = new System.Drawing.Size(214, 20);
            this.txtFNumber.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(305, 39);
            this.label6.TabIndex = 15;
            this.label6.Text = "Airline System Flight";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lblSuccessFlight);
            this.tabPage1.Controls.Add(this.lblFailAddFlight);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtDestination);
            this.tabPage1.Controls.Add(this.txtOrigin);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnAddFlight);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtMSeats);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtFNumber);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(616, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  Add";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblSuccessFlight
            // 
            this.lblSuccessFlight.AutoSize = true;
            this.lblSuccessFlight.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccessFlight.ForeColor = System.Drawing.Color.Green;
            this.lblSuccessFlight.Location = new System.Drawing.Point(218, 213);
            this.lblSuccessFlight.Name = "lblSuccessFlight";
            this.lblSuccessFlight.Size = new System.Drawing.Size(0, 13);
            this.lblSuccessFlight.TabIndex = 9;
            // 
            // lblFailAddFlight
            // 
            this.lblFailAddFlight.AutoSize = true;
            this.lblFailAddFlight.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFailAddFlight.ForeColor = System.Drawing.Color.Red;
            this.lblFailAddFlight.Location = new System.Drawing.Point(205, 213);
            this.lblFailAddFlight.Name = "lblFailAddFlight";
            this.lblFailAddFlight.Size = new System.Drawing.Size(0, 13);
            this.lblFailAddFlight.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Destination";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(266, 140);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(216, 20);
            this.txtDestination.TabIndex = 3;
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
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblFailDelFlight);
            this.tabPage2.Controls.Add(this.lblSucDelFlight);
            this.tabPage2.Controls.Add(this.txtIdFlight);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnDelFlight);
            this.tabPage2.Controls.Add(this.txtBoxFlightView);
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
            // lblFailDelFlight
            // 
            this.lblFailDelFlight.AutoSize = true;
            this.lblFailDelFlight.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFailDelFlight.ForeColor = System.Drawing.Color.Red;
            this.lblFailDelFlight.Location = new System.Drawing.Point(235, 213);
            this.lblFailDelFlight.Name = "lblFailDelFlight";
            this.lblFailDelFlight.Size = new System.Drawing.Size(0, 13);
            this.lblFailDelFlight.TabIndex = 16;
            // 
            // lblSucDelFlight
            // 
            this.lblSucDelFlight.AutoSize = true;
            this.lblSucDelFlight.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucDelFlight.ForeColor = System.Drawing.Color.Green;
            this.lblSucDelFlight.Location = new System.Drawing.Point(218, 213);
            this.lblSucDelFlight.Name = "lblSucDelFlight";
            this.lblSucDelFlight.Size = new System.Drawing.Size(0, 13);
            this.lblSucDelFlight.TabIndex = 10;
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
            this.label5.TabIndex = 12;
            this.label5.Text = "Queens Inc. ©";
            // 
            // FlightMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(600, 406);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlightMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FlightMenu";
            this.Load += new System.EventHandler(this.FlightMenu_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox txtBoxFlightView;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMSeats;
        private System.Windows.Forms.TextBox txtIdFlight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelFlight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Label lblSuccessFlight;
        private Label lblSucDelFlight;
        private Label lblFailDelFlight;
        private Label lblFailAddFlight;
        private System.Windows.Forms.TextBox txtDestination;

        public bool checkInteger(TextBox t)
        {
            int a;
            return int.TryParse(t.Text, out a);

        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            lblFailAddFlight.Text = "";
            lblSuccessFlight.Text = "";
            if (checkInteger(txtFNumber))
            {
                if (checkInteger(txtMSeats))
                {
                    int flightId = Convert.ToInt32(txtFNumber.Text);
                    string origin = txtOrigin.Text;
                    string destination = txtDestination.Text;
                    int maxSeats = Convert.ToInt32(txtMSeats.Text);
                    Program.ac.addFlight(flightId, origin, destination, maxSeats);

                    lblSuccessFlight.Text = "Successfully added Flight "+flightId+"!";
                    txtBoxFlightView.Text = Program.ac.flightList();
                    txtFNumber.Clear();
                    txtOrigin.Clear();
                    txtDestination.Clear();
                    txtMSeats.Clear();
                }
                else
                {
                    txtMSeats.Clear();
                    lblFailAddFlight.Text = "Please enter an integer for maximum seat number!";
                }

            }
            else
            {
                txtFNumber.Clear();
                lblFailAddFlight.Text = "Please enter an integer flight number!";
            }

        }

        private void FlightMenu_Load(object sender, EventArgs e)
        {

            txtBoxFlightView.Text = Program.ac.flightList();
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

        private void btnDelFlight_Click(object sender, EventArgs e)
        {
            lblFailDelFlight.Text = "";
            lblSucDelFlight.Text = "";
            if (checkInteger(txtIdFlight))
            {
                int flightId = Convert.ToInt32(txtIdFlight.Text);

                if (Program.ac.deleteFlight(flightId))
                {
                    txtBoxFlightView.Text = Program.ac.flightList();
                    lblSucDelFlight.Text = "Successfully deleted flight!";
                }
                else
                {
                    lblFailDelFlight.Text = "Entered flight id is not found!";
                }
            }
            else
            {
                lblFailDelFlight.Text = "Please enter an integer!";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            main.Show();
            Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            lblFailAddFlight.Text = "";
            lblSuccessFlight.Text = "";
            lblFailDelFlight.Text = "";
            lblSucDelFlight.Text = "";
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            lblFailAddFlight.Text = "";
            lblSuccessFlight.Text = "";
            lblFailDelFlight.Text = "";
            lblSucDelFlight.Text = "";
        }




    }






}

