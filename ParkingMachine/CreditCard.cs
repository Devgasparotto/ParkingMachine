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
    public partial class CreditCard : Form
    {
        public string cardNumber { get; set; }
        public int CVV { get; set; }
        public Boolean canBeSwiped { get; set; }
        public int cardId { get; set; }
        public string pin { get; set; }

        public CreditCard(int newCardId, string newCardNumber, int newCVV, Boolean swipable, string PIN)
        {
            InitializeComponent();
            cardId = newCardId;
            cardNumber = newCardNumber;
            CVV = newCVV;
            pin = PIN;
            canBeSwiped = swipable;
            this.Closing += new CancelEventHandler(this.Card_Closing);
            DisplayCardNumber();
            DisplayCVV();
            DisplayAcceptedStatus();
        }

        private void DisplayCardNumber()
        {
            CreditCardNumber.Text = cardNumber;
        }

        private void DisplayCVV()
        {
            CVVValue.Text = CVV.ToString();
        }

        private void DisplayAcceptedStatus()
        {
            if (canBeSwiped)
            {
                IsAcceptableLabel.Text = "Accepted";
            }
            else
            {
                IsAcceptableLabel.Text = "Denied";
            }
        }

        private void Card_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
