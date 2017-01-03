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
    public partial class CardManualEntry : Form
    {
        public string buttonPressed = "";
        private int cardNumberLengthLimit = 16;
        private int cvvLengthLimit = 3;
        private Boolean isCreditCardEntrySelected;

        public CardManualEntry()
        {
            InitializeComponent();
            isCreditCardEntrySelected = false;
        }

        private void CreditCardNumber_Click(object sender, EventArgs e)
        {
            isCreditCardEntrySelected = true;
            SetPINVisibility(true);
        }

        private void CVV_Click(object sender, EventArgs e)
        {
            isCreditCardEntrySelected = false;
            SetPINVisibility(true);
        }

        private void SetPINVisibility(Boolean isVisible)
        {
            OnePinButton.Visible = isVisible;
            TwoPinButton.Visible = isVisible;
            ThreePinButton.Visible = isVisible;
            FourPinButton.Visible = isVisible;
            FivePinButton.Visible = isVisible;
            SixPinButton.Visible = isVisible;
            SevenPinButton.Visible = isVisible;
            EightPinButton.Visible = isVisible;
            NinePinButton.Visible = isVisible;
            ZeroPinButton.Visible = isVisible;
            CorrectionButton.Visible = isVisible;
        }

        public void SetCardInvalidLabelVisibility(Boolean isVisible)
        {
            CardInvalidLabel.Visible = isVisible;
        }

        private void PINClick(string number)
        {
            if(isCreditCardEntrySelected && CreditCardNumber.Text.Length < cardNumberLengthLimit)
            {
                CreditCardNumber.Text += number;
            }
            else if(!isCreditCardEntrySelected && CVV.Text.Length < cvvLengthLimit)
            {
                CVV.Text += number;
            }
        }

        private void CorrectionButton_Click(object sender, EventArgs e)
        {
            if (isCreditCardEntrySelected && CreditCardNumber.Text.Length > 0)
            {
                CreditCardNumber.Text = CreditCardNumber.Text.Remove(CreditCardNumber.Text.Length - 1);
            }
            else if(!isCreditCardEntrySelected && CVV.Text.Length > 0)
            {
                CVV.Text = CVV.Text.Remove(CVV.Text.Length - 1);
            }
        }

        private void OnePinButton_Click(object sender, EventArgs e)
        {
            PINClick("1");
        }

        private void TwoPinButton_Click(object sender, EventArgs e)
        {
            PINClick("2");
        }

        private void ThreePinButton_Click(object sender, EventArgs e)
        {
            PINClick("3");
        }

        private void FourPinButton_Click(object sender, EventArgs e)
        {
            PINClick("4");
        }

        private void FivePinButton_Click(object sender, EventArgs e)
        {
            PINClick("5");
        }

        private void SixPinButton_Click(object sender, EventArgs e)
        {
            PINClick("6");
        }

        private void SevenPinButton_Click(object sender, EventArgs e)
        {
            PINClick("7");
        }

        private void EightPinButton_Click(object sender, EventArgs e)
        {
            PINClick("8");
        }

        private void NinePinButton_Click(object sender, EventArgs e)
        {
            PINClick("9");
        }

        private void ZeroPinButton_Click(object sender, EventArgs e)
        {
            PINClick("0");
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string[] cardCredentials = { CreditCardNumber.Text, CVV.Text };
            Utility.HandleCardManualEntrySubmitButtonClick(cardCredentials);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            buttonPressed = "Cancel";
            CleanUp();
            this.Close();
        }

        private void CleanUp()
        {
            CreditCardNumber.Text = "";
            CVV.Text = "";
        }
    }
}
