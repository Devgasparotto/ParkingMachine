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
    public partial class AddCoins : Form
    {
        public DateTime validTill;
        public DateTime currentDateTime = new DateTime(2016, 11, 8, 13, 0, 0); //Starting time is 11/8/2016 13:00;
        public string buttonPressed = "";

        public double currentCost = 0.0;
        double currentTime = 0.0;

        public AddCoins(DateTime? existingDateTime = null)
        {
            InitializeComponent();

            if (existingDateTime != null && existingDateTime > currentDateTime)
            {
                validTill = Convert.ToDateTime(existingDateTime);
            }
            else
            {
                validTill = currentDateTime;
            }
            
            AmountEntered.Text = "0.00";
            TimeLabel.Text = "0.00" + " Hours";
            UpdateDisplay();
            //currentTime = currentValue / 1.0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void quarterButton_Click(object sender, EventArgs e)
        {
            UpdateCostAndTime(0.25);
        }

        private void addLoonie_Click(object sender, EventArgs e)
        {
            UpdateCostAndTime(1.00);
        }

        private void addToonie_Click(object sender, EventArgs e)
        {
            UpdateCostAndTime(2.00);
        }

        public void AddQuarter()
        {
            validTill = validTill.AddMinutes(15);
            UpdateCostAndTime(0.25);
        }

        public void AddLoonie()
        {
            validTill = validTill.AddMinutes(60);
            UpdateCostAndTime(1.00);
        }

        public void AddToonie()
        {
            validTill = validTill.AddMinutes(120);
            UpdateCostAndTime(2.00);
        }

        private void UpdateCostAndTime(double valueToAdd)
        {
            double valAmount = Double.Parse(AmountEntered.Text);
            currentCost += valueToAdd;
            currentTime += valueToAdd;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            ValidTillDate.Text = validTill.ToString();
            AmountEntered.Text = currentCost.ToString();
            TimeLabel.Text = currentTime.ToString() + " Hours";
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(currentCost > 0)
            {
                buttonPressed = "Submit";
                this.Close();
            }
        }

        private void RefundButton_Click(object sender, EventArgs e)
        {
            if(currentCost > 0)
            {
                buttonPressed = "Refund";
                this.Close();
            }
        }
    }
}
