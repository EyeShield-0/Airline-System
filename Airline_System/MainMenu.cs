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
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            
            InitializeComponent();
            MaximizeBox = false;
            btnCustMenu.MouseEnter += OnMouseEnterbtnCustMenu;
            btnCustMenu.MouseLeave += OnMouseLeavebtnCustMenu;

            btnFlightMenu.MouseEnter += OnMouseEnterbtnFlightMenu;
            btnFlightMenu.MouseLeave += OnMouseLeavebtnFlightMenu;

            btnBookingMenu.MouseEnter += OnMouseEnterbtnBookingMenu;
            btnBookingMenu.MouseLeave += OnMouseLeavebtnBookingMenu;

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

        private void btnCustMenu_Click(object sender, EventArgs e)
        {
            CustomerMenu customerMenu = new CustomerMenu(this);
            Hide();
            customerMenu.ShowDialog();
        }

        private void btnFlightMenu_Click(object sender, EventArgs e)
        {
            FlightMenu flightMenu = new FlightMenu(this);
            Hide();
            flightMenu.ShowDialog();
        }


        private void btnBookingMenu_Click(object sender, EventArgs e)
        {
            BookingMenu bookingMenu = new BookingMenu(this);
            Hide();
            bookingMenu.ShowDialog();
        }

        //hover color change
        private void OnMouseEnterbtnCustMenu(object sender, EventArgs e)
        {
            btnCustMenu.BackColor = Color.FromArgb(6, 90, 130);

        }
        private void OnMouseLeavebtnCustMenu(object sender, EventArgs e)
        {
            btnCustMenu.BackColor = Color.FromArgb(0, 112, 187);

        }

        private void OnMouseEnterbtnFlightMenu(object sender, EventArgs e)
        {

            btnFlightMenu.BackColor = Color.FromArgb(6, 90, 130);

        }
        private void OnMouseLeavebtnFlightMenu(object sender, EventArgs e)
        {

            btnFlightMenu.BackColor = Color.FromArgb(0, 112, 187);

        }

        private void OnMouseEnterbtnBookingMenu(object sender, EventArgs e)
        {

            btnBookingMenu.BackColor = Color.FromArgb(6, 90, 130);

        }
        private void OnMouseLeavebtnBookingMenu(object sender, EventArgs e)
        {

            btnBookingMenu.BackColor = Color.FromArgb(0, 112, 187);

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }

  
}
