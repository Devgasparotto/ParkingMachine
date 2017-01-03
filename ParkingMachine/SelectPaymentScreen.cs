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
    public partial class SelectPaymentScreen : Form
    {
        public string buttonPressed = "";

        public SelectPaymentScreen()
        {
            InitializeComponent();
        }

        private void CreditDebitButton_Click(object sender, EventArgs e)
        {
            buttonPressed = "CreditDebit";
            this.Close();
        }

        private void CoinButton_Click(object sender, EventArgs e)
        {
            buttonPressed = "Coin";
            this.Close();
        }
    }
}
