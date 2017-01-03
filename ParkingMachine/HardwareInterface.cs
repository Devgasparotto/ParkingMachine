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
    public partial class HardwareInterface : Form
    {
        private TouchScreen touchScreenForm;

        BindingList<Ticket> tickets = new BindingList<Ticket>();
        BindingSource bindingTicketSource = new BindingSource();
        List<CreditCard> creditCards = new List<CreditCard>();

        private DateTime currentTime = new DateTime(2016, 11, 8, 13, 0, 0); //Starting time is 11/8/2016 13:00;

        public HardwareInterface()
        {
            InitializeComponent();
            
            SetupCards();
            SetupTickets();
            PopulateTicketCBO();
            PopulateCardCBO();
            PopulateCoinInsertCBO();
            SetupTouchScreen();
        }

        private void SetupTouchScreen()
        {
            touchScreenForm = new TouchScreen();
            touchScreenForm.TopLevel = false;
            TouchScreenPanel.Controls.Add(touchScreenForm);
            touchScreenForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            touchScreenForm.Dock = DockStyle.Fill;
            touchScreenForm.Show();
            touchScreenForm.currentTicket = GetSelectedTicket();
            touchScreenForm.currentCard = GetSelectedCard();
            touchScreenForm.creditCards = creditCards;
        }

        private void SetupCards()
        { 
            CreditCard creditCardAccepted = new CreditCard(1, "1111111111111111", 123, true, "0000");
            CreditCard creditCardDeclined = new CreditCard(2, "2222222222222222", 321, false, "0000");
            creditCards.Add(creditCardAccepted);
            creditCards.Add(creditCardDeclined);
        }

        private void SetupTickets()
        {
            Ticket inUseTicket = new ParkingMachine.Ticket(1, currentTime.AddHours(-1), currentTime.AddHours(1));
            Ticket expiredTicket = new ParkingMachine.Ticket(2, currentTime.AddHours(-3), currentTime.AddHours(-1));
            AddTicket(inUseTicket);
            AddTicket(expiredTicket);
        }

        private void PopulateTicketCBO()
        {
            ticketCBO.DisplayMember = "ticketId";
            ticketCBO.ValueMember = "ticketId";
            bindingTicketSource.DataSource = tickets;
            ticketCBO.DataSource = bindingTicketSource;
        }

        private void PopulateCardCBO()
        {
            cardCBO.DisplayMember = "cardId";
            cardCBO.ValueMember = "cardId";
            cardCBO.DataSource = creditCards;
        }

        private void PopulateCoinInsertCBO()
        {
            List<double> coins = new List<double>();
            coins.Add(0.25);
            coins.Add(1);
            coins.Add(2);
            coinInsertCBO.DataSource = coins;
        }

        private void DisplayTicket(int ticketId)
        {
            Ticket ticket = GetTicketFromList(ticketId);
            if(ticket != null)
            {
                ticket.Show();
            }
        }

        private void DisplayCard(int cardId)
        {
            CreditCard card = GetCardFromList(cardId);
            card.Show();
        }

        private CreditCard GetCardFromList(int index)
        {
            return creditCards.ElementAt(index - 1);
        }

        private Ticket GetTicketFromList(int ticketIdToGet)
        {
            int index = 0;
            foreach (Ticket ticket in tickets)
            {
                if (ticket.ticketId == ticketIdToGet)
                {
                    return tickets.ElementAt(index);
                }
                index++;
            }
            return null;
        }

        private CreditCard GetSelectedCard()
        {
            int selectedCard = (int)cardCBO.SelectedValue;
            return GetCardFromList(selectedCard);
        }

        private Ticket GetSelectedTicket()
        {
            if(ticketCBO.SelectedValue != null)
            {
                int selectedTicket = (int)ticketCBO.SelectedValue;
                return GetTicketFromList(selectedTicket);
            }
            return null;
        }

        private void AddTicket(Ticket newTicket)
        {
            tickets.Add(newTicket);
        }

        private void RemoveTicket(int tickedIdToRemove)
        {
            int index = 0;
            foreach (Ticket ticket in tickets)
            {
                if(ticket.ticketId == tickedIdToRemove)
                {
                    tickets.RemoveAt(index);
                    break;
                }
                index++;
            }
        }


        //Hardware Handler

        private void CardSwipeButton_Click(object sender, EventArgs e)
        {
            if (touchScreenForm.currentCardState == TouchScreen.CardState.CardReady) //(touchScreenForm.currentState == TouchScreen.State.CardReady)
            {
                CreditCard currentCard = GetSelectedCard();
                touchScreenForm.HandleCardSwipe(currentCard);
            }
        }

        private void InsertCardButton_Click(object sender, EventArgs e)
        {
            if (touchScreenForm.currentCardState == TouchScreen.CardState.CardReady)//(touchScreenForm.currentState == TouchScreen.State.CardReady) //Insert Card
            {
                if (touchScreenForm.AllowTextChangeInsertCardToEjectCard())
                {
                    InsertCardButton.Text = "Eject Card";
                }

                CreditCard currentCard = GetSelectedCard();
                touchScreenForm.HandleCardInsert(currentCard);
            }

            else if (touchScreenForm.currentCardState == TouchScreen.CardState.CardInserted)//(touchScreenForm.currentState == TouchScreen.State.CardInserted)//Eject Card
            {
                if (touchScreenForm.AllowTextChangeEjectCardToInsertCard())
                {
                    InsertCardButton.Text = "Insert Card";
                }
                touchScreenForm.HandleCardEject();
            }
            
            //TODO: implement enabling and disabling of InsertCardButton       
        }

        private void CoinInsertButton_Click(object sender, EventArgs e)
        {
            double coinAmount = (double)coinInsertCBO.SelectedValue;
            touchScreenForm.HandleCoinInsert(coinAmount);
        }

        private void CoinReturnButton_Click(object sender, EventArgs e)
        {
            double coinsReturned = touchScreenForm.HandleCoinReturn();
            if(coinsReturned > 0)
            {
                System.Windows.Forms.MessageBox.Show("Refunded: $" + coinsReturned.ToString());
            }
        }

        private void PrintedTicketButton_Click(object sender, EventArgs e)
        {
            Ticket newTicket = touchScreenForm.HandlePrintTicket();
            if(newTicket != null)
            {
                AddTicket(newTicket);
                DisplayTicket(newTicket.ticketId);
            }
        }

        private void InsertTicketButton_Click(object sender, EventArgs e)
        {
            touchScreenForm.currentTicket = GetSelectedTicket(); //TODO: Verify this is correct
            if (touchScreenForm.HandleInsertTicket())
            {
                //Remove Inserted Ticket from tickets list
                Ticket currentTicket = GetSelectedTicket();
                RemoveTicket(currentTicket.ticketId);
            }
        }

        private void ticketCBO_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedTicket = (int)ticketCBO.SelectedValue;
            DisplayTicket(selectedTicket);
            touchScreenForm.currentTicket = GetSelectedTicket();
        }

        private void cardCBO_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedCard = (int)cardCBO.SelectedValue;
            DisplayCard(selectedCard);
            touchScreenForm.currentCard = GetSelectedCard();
        }
    }
}
