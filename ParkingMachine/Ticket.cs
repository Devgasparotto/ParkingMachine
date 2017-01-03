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
    public partial class Ticket : Form
    {

        public int ticketId { get; set; }
        public DateTime issueDate { get; set; }
        public DateTime expiryDate { get; set; }
   
        public Ticket(int newTicketId, DateTime newIssuedAt, DateTime newExpiresAt)
        {
            InitializeComponent();
            ticketId = newTicketId;
            issueDate = newIssuedAt;
            expiryDate = newExpiresAt;
            this.Closing += new CancelEventHandler(this.Ticket_Closing);
            DisplayTicketId();
            DisplayIssuedAt();
            DisplayExpiryDate();
        }

        private void DisplayTicketId()
        {
            TicketID.Text = ticketId.ToString();
        }

        private void DisplayIssuedAt()
        {
            IssuedDate.Text = issueDate.ToString();
        }

        private void DisplayExpiryDate()
        {
            ExpiryDate.Text = expiryDate.ToString();
        }

        private void Ticket_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
