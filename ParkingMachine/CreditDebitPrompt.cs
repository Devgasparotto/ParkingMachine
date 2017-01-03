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
    public partial class CreditDebitPrompt : Form
    {
        public string buttonPressed = "";

        public CreditDebitPrompt()
        {
            InitializeComponent();
        }

        public void SetCardDeclinedVisibility(Boolean isVisible)
        {
            CardDeclinedLabel.Visible = isVisible;
            //TODO: reset visibilities to default after leaving screen
        }

        public void SetCardInfoEntryVisbility(Boolean isVisible)
        {
            CardInfoEntryLabel.Visible = isVisible;
            CardInfoEntryButton.Visible = isVisible;
        }

        public void SetLabelVisibilities(Boolean isVisible)
        {
            SetCardDeclinedVisibility(isVisible);
            SetCardInfoEntryVisbility(isVisible);
        }

        private void CardInfoEntryButton_Click(object sender, EventArgs e)
        {
            buttonPressed = "ManualEntry";
            this.Close();
        }
    }
}
