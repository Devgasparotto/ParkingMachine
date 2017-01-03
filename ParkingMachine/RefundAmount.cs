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
    public partial class RefundAmount : Form
    {
        public string buttonPressed;
        public DateTime currentDateTime = new DateTime(2016, 11, 8, 13, 0, 0); //Starting time is 11/8/2016 13:00;
        public double amountToBeRefunded;
        private int timeIncrements = 15;
        private double costPerTimeIncrement = 0.25;

        public RefundAmount(DateTime expiryDateTime)
        {
            InitializeComponent();
            amountToBeRefunded = 0.00;
            SetAmountToBeRefunded(expiryDateTime);
            buttonPressed = "";
        }

        private void SetAmountToBeRefunded(DateTime expiryDateTime)
        {
            if(expiryDateTime > currentDateTime)
            {
                //TimeSpan difference = expiryDateTime.Subtract(currentDateTime);
                //(EndDate - StartDate).TotalDays
                double difference = (expiryDateTime - currentDateTime).TotalMinutes;
                double timeSegments = difference / timeIncrements;
                amountToBeRefunded = costPerTimeIncrement*Math.Floor(timeSegments);
                UpdateDisplay();
            }
            else
            {
                amountToBeRefunded = 0;
                RefundAmountBox.Text = "$0.00 - This ticket is expired";
                RefundButton.BackColor = Color.Gray;
            }
        }

        private void UpdateDisplay()
        {
            RefundAmountBox.Text = "$" + amountToBeRefunded.ToString();
            if(amountToBeRefunded <= 0)
            {
                RefundButton.BackColor = Color.Gray;
            }
        }

        private void RefundButton_Click(object sender, EventArgs e)
        {
            if(amountToBeRefunded > 0)
            {
                buttonPressed = "Refund";
                this.Close();
            }                      
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            buttonPressed = "Cancel";
            this.Close();
        }
    }
}
