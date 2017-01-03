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
    public partial class PINEntry : Form
    {
        public string buttonPressed = "";
        private string pinToVerify = "";
        string pinEntered; //numbers entered by user
        int numbersEntered = 0; //amount of numbers currently in PIN string
        string lastNumberEntered; //last number entered in PIN by user

        public PINEntry(string pin)
        {
            InitializeComponent();
            pinToVerify = pin;
            ResetPIN();
            PINInvalidLabel.Visible = false;
        }
        
        private void ResetPIN()
        {
            pinEntered = "";
            numbersEntered = 0;
            PINNumber.Text = "";
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (pinEntered == pinToVerify) //if the current entered PIN is the same as the hardcoded PIN, accept the transcation
            {
                //EjectCard eject = new EjectCard(); //open a new window prompting the user to eject their card
                //eject.Show();
                pinEntered = "";
                numbersEntered = 0;
                PINNumber.Text = "";
                PINInvalidLabel.Visible = false;
                buttonPressed = "Submit";
                this.Close();
            }
            else
            {
                PINInvalidLabel.Visible = true;
                ResetPIN();
                //TryAgain tryAgain = new TryAgain(); //open a new window prompting the user the PIN was declined
                //tryAgain.Show();
            }            
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            buttonPressed = "Cancel";
            this.Close();
        }

        private void CorrectionButton_Click(object sender, EventArgs e)
        {
            //remove last number of PIN entered
            if (pinEntered.Length > 0)
            {
                pinEntered = pinEntered.Remove(pinEntered.Length - 1);
                numbersEntered = numbersEntered - 1;
            }

            //remove last * character from display screen
            if (PINNumber.Text.Length > 0)
            {
                PINNumber.Text = PINNumber.Text.Remove(PINNumber.Text.Length - 1);
            }
        }

        private void PINButton_Click(string number)
        {
            if (numbersEntered < 4) //make sure there can be max of 4 numbers in PIN string
            {
                PINNumber.Text = PINNumber.Text + "*"; //add asterix to display to hide the user's PIN
                pinEntered = pinEntered + number; //add this number to the hidden string of the user's PIN
                lastNumberEntered = lastNumberEntered + number; //set this number to be the last number entered
                numbersEntered++;
            }
        }


        private void OnePinButton_Click(object sender, EventArgs e)
        {
            PINButton_Click("1");
        }

        private void TwoPinButton_Click(object sender, EventArgs e)
        {
            PINButton_Click("2");
        }

        private void ThreePinButton_Click(object sender, EventArgs e)
        {
            PINButton_Click("3");
        }

        private void FourPinButton_Click(object sender, EventArgs e)
        {
            PINButton_Click("4");
        }

        private void FivePinButton_Click(object sender, EventArgs e)
        {
            PINButton_Click("5");
        }

        private void SixPinButton_Click(object sender, EventArgs e)
        {
            PINButton_Click("6");
        }

        private void SevenPinButton_Click(object sender, EventArgs e)
        {
            PINButton_Click("7");
        }

        private void EightPinButton_Click(object sender, EventArgs e)
        {
            PINButton_Click("8");
        }

        private void NinePinButton_Click(object sender, EventArgs e)
        {
            PINButton_Click("9");
        }

        private void ZeroPinButton_Click(object sender, EventArgs e)
        {
            PINButton_Click("0");
        }
    }
}
