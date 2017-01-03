using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingMachine
{
    public partial class MainScreen : Form
    {
        public string buttonPressed = "";

        public MainScreen()
        {
            InitializeComponent();
        }

        private void BuyTicketButton_Click(object sender, EventArgs e)
        {
            buttonPressed = "BuyTicket";
            this.Close();
        }

        private void RefundTicketButton_Click(object sender, EventArgs e)
        {
            buttonPressed = "RefundTicket";
            this.Close();
        }

        private void AddTimeButton_Click(object sender, EventArgs e)
        {
            buttonPressed = "AddTime";
            this.Close();
        }
    }
}
