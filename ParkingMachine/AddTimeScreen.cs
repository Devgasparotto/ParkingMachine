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
    public partial class AddTimeScreen : Form
    {
        public DateTime validTillDate;
        public double currentCost;
        private double rate = 1;
        private double dateTimeIncrements = 15; //15 minutes
        private double costMax = 20;
        private double hoursIncrements = 0.25; //15 minutes

        public DateTime currentTime = new DateTime(2016, 11, 8, 13, 0, 0); //Starting time is 11/8/2016 13:00;
        public double hours;


        public string buttonPressed = "";

        public AddTimeScreen(DateTime? validTill = null)
        {
            InitializeComponent();
            currentCost = 0.00;

            if(validTill != null && validTill > currentTime)
            {
                validTillDate = Convert.ToDateTime(validTill);
            }
            else
            {
                validTillDate = currentTime;
            }

            UpdateDisplays();
        }

        private void DisplayHours()
        {
            HoursDisplay.Text = hours.ToString();
        }

        private void DisplayValidTill()
        {
            ValidDate.Text = validTillDate.ToString();
        }

        private void DisplayCost()
        {
            Cost.Text = "$" + currentCost.ToString();
        }

        private void UpdateDisplays()
        {
            DisplayHours();
            DisplayValidTill();
            DisplayCost();
        }

        private void AddTimeButton_Click(object sender, EventArgs e)
        {
            if(currentCost + rate/4 > costMax)
            {
                AddTimeButton.Enabled = false;
            }
            else
            {
                currentCost += rate / 4;
                validTillDate = validTillDate.AddMinutes(dateTimeIncrements);
                hours += hoursIncrements;
                UpdateDisplays();
            }
            
            SubtractTimeButton.Enabled = true;
        }

        private void SubtractTimeButton_Click(object sender, EventArgs e)
        {
            if(currentCost - rate/4 < 0)
            {
                SubtractTimeButton.Enabled = false;
            }
            else
            {
                currentCost -= rate / 4;
                validTillDate = validTillDate.AddMinutes(-dateTimeIncrements);
                hours -= hoursIncrements;
                UpdateDisplays();
            }

            AddTimeButton.Enabled = true;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if(currentCost > 0)
            {
                buttonPressed = "Confirm";
                this.Close();
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            buttonPressed = "Return";
            this.Close();
        }
    }
}
