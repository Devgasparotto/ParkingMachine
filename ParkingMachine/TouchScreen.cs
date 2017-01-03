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
    public partial class TouchScreen : Form
    {
        public string currentScreen = "";
        private MainScreen mainScreenForm;
        private SelectPaymentScreen selectPaymentScreenForm;
        private AddTimeScreen addTimeScreenForm;
        private CreditDebitPrompt creditDebitPromptForm;
        private CardManualEntry cardManualEntryForm;
        private PINEntry pinEntryForm;
        private EjectCard ejectCardForm;
        private PrintingTicket printingTicketForm;
        private TicketInsert ticketInsertForm;
        private AddCoins addCoinsForm;
        private RefundAmount refundAmountForm;
        private RefundSuccess refundSuccessForm;
        private RemoveTicket removeTicketForm;

        private Ticket ticketToBePrinted;
        private int ticketIndex = 3;

        //Keeps track of the number of times the card has been declined
        private int declinedCount = 0;
        private int declinedCountLimit = 1;

        private Boolean homeButtonClicked;
        private Boolean cannotClickHome;

        private Color greenColor = Color.Green;
        private Color defaultColor = SystemColors.Control;

        public CreditCard currentCard;
        public CreditCard insertedCard;
        public Ticket currentTicket;
        public Ticket insertedTicket;
        public double coinsInserted;
        public double coinsInRefund;

        public List<CreditCard> creditCards = new List<CreditCard>();

        public enum State
        {
            Neutral,
            TicketPrinted,
            TicketInserted,
            TicketInsertRequired,
            CardReady,
            CardInserted
        }
        public State currentState;

        public enum CardState
        {
            Neutral,
            CardReady,
            CardInserted
        }
        public CardState currentCardState;

        public enum TicketState
        {
            Neutral,
            TicketPrinted,
            TicketInserted,
            TicketInsertRequired
        }
        public TicketState currentTicketState;

        public enum CoinState
        {
            Neutral,
            CoinReady
        }
        public CoinState currentCoinState;

        public enum Mode
        {
            Neutral,
            BuyTicket,
            RefundTicket,
            AddToTicket
        }
        public Mode currentMode;

        public TouchScreen()
        {
            InitializeComponent();
            SetStartingState();
            DisplayMainScreen();

            Utility.HandleCardManualEntrySubmitButtonClick = (cardCredentials) =>
            {
                HandleCardManualEntrySubmission(cardCredentials);
            };
        }

        private void SetStartingState()
        {
            currentMode = Mode.Neutral;
            currentState = State.Neutral;
            currentCardState = CardState.Neutral;
            currentTicketState = TicketState.Neutral;
            currentCoinState = CoinState.Neutral;
            coinsInRefund = 0.00;
            coinsInserted = 0.00;
            homeButtonClicked = false;
            cannotClickHome = false;
        }

        private void CurrentScreenPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RemoveCurrentScreenByForm(Form currentForm)
        {
            CurrentScreenPanel.Controls.Remove(currentForm);
            currentScreen = "";
        }

        private void RemoveCurrentScreen()
        {
            switch (currentScreen)
            {
                case "MainScreen":
                    RemoveCurrentScreenByForm(mainScreenForm);
                    break;
                case "SelectPaymentScreen":
                    RemoveCurrentScreenByForm(selectPaymentScreenForm);
                    break;
                case "AddTimeScreen":
                    RemoveCurrentScreenByForm(addTimeScreenForm);
                    break;
                case "CreditDebitPrompt":
                    RemoveCurrentScreenByForm(creditDebitPromptForm);
                    break;
                case "CardManualEntry":
                    RemoveCurrentScreenByForm(cardManualEntryForm);
                    break;
                case "PINEntry":
                    RemoveCurrentScreenByForm(pinEntryForm);
                    break;
                case "EjectCard":
                    RemoveCurrentScreenByForm(ejectCardForm);
                    break;
                case "PrintingTicket":
                    RemoveCurrentScreenByForm(printingTicketForm);
                    break;
                case "AddCoins":
                    RemoveCurrentScreenByForm(addCoinsForm);
                    break;
                case "TicketInsert":
                    RemoveCurrentScreenByForm(ticketInsertForm);
                    break;
                case "RefundAmount":
                    RemoveCurrentScreenByForm(refundAmountForm);
                    break;
                case "RefundSuccess":
                    RemoveCurrentScreenByForm(refundSuccessForm);
                    break;
                case "RemoveTicket":
                    RemoveCurrentScreenByForm(removeTicketForm);
                    break;
            }
        }


        //DISPLAY HANDLERS

        private void SetTitle(string title)
        {
            Title.Text = title;
        }

        private void DisplayScreen(Form formToDisplay, string newScreenName, string newScreenTitle)
        {
            formToDisplay.TopLevel = false;
            CurrentScreenPanel.Controls.Add(formToDisplay);
            formToDisplay.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formToDisplay.Dock = DockStyle.Fill;
            currentScreen = newScreenName;
            SetTitle(newScreenTitle);
            formToDisplay.Show();
        }

        private void DisplayMainScreen()
        {
            
            currentState = State.Neutral;
            currentMode = Mode.Neutral;
            mainScreenForm = new MainScreen();
            DisplayScreen(mainScreenForm, "MainScreen", "Main Menu");
            mainScreenForm.FormClosed += (sender, e) => MainScreen_HandleButtonClick(sender, e);
            
        }

        private void DisplayPaymentScreen()
        {
            selectPaymentScreenForm = new SelectPaymentScreen();
            DisplayScreen(selectPaymentScreenForm, "SelectPaymentScreen", "Select Payment Type");
            selectPaymentScreenForm.FormClosed += (sender, e) => SelectPaymentScreen_HandleButtonClick(sender, e);
        }

        private void DisplayAddTimeScreen(DateTime? validTill = null)
        {
            addTimeScreenForm = new AddTimeScreen(validTill);
            DisplayScreen(addTimeScreenForm, "AddTimeScreen", "Add Time");
            addTimeScreenForm.FormClosed += (sender, e) => AddTimeScreen_HandleButtonClick(sender, e);
        }

        private void DisplayCreditDebitPrompt()
        {
            //currentState = State.CardReady;
            ChangeInsertCardColour(greenColor);
            ChangeSwipeCardColour(greenColor);
            currentCardState = CardState.CardReady;
            creditDebitPromptForm = new CreditDebitPrompt();
            DisplayScreen(creditDebitPromptForm, "CreditDebitPrompt", "Credit / Debit");
            creditDebitPromptForm.FormClosed += (sender, e) => CreditDebitPrompt_HandleButtonClick(sender, e);
        }

        private void DisplayCardManualEntry()
        {
            //currentState = State.Neutral;
            currentCardState = CardState.CardReady;
            cardManualEntryForm = new CardManualEntry();
            DisplayScreen(cardManualEntryForm, "CardManualEntry", "Manual Card Entry");
            cardManualEntryForm.FormClosed += (sender, e) => CardManualEntry_HandleButtonClick(sender, e);
            //cardManualEntryForm
        }

        private void DisplayPINEntry(string pin)
        {
            pinEntryForm = new PINEntry(pin);
            DisplayScreen(pinEntryForm, "PINEntry", "Enter your PIN");
            pinEntryForm.FormClosed += (sender, e) => PINEntry_HandleButtonClick(sender, e);
        }

        private void DisplayEjectCard()
        {
            ejectCardForm = new EjectCard();
            DisplayScreen(ejectCardForm, "EjectCard", "Card Ejected");
        }

        private void DisplayPrintingTicket()
        {
            //currentState = State.TicketPrinted;
            ChangePrintTicketColour(greenColor);
            currentTicketState = TicketState.TicketPrinted;
            printingTicketForm = new PrintingTicket();
            DisplayScreen(printingTicketForm, "PrintingTicket", "Ticket Printed");
        }

        private void DisplayAddCoins(DateTime? validTill = null)
        {
            currentCoinState = CoinState.CoinReady;
            addCoinsForm = new AddCoins(validTill);
            DisplayScreen(addCoinsForm, "AddCoins", "Insert Coins");
            addCoinsForm.FormClosed += (sender, e) => AddCoins_HandleButtonClick(sender, e);
            ChangeCoinInsertColour(greenColor);
        }

        private void DisplayTicketInsert()
        {
            currentTicketState = TicketState.TicketInsertRequired;
            ticketInsertForm = new TicketInsert();
            DisplayScreen(ticketInsertForm, "TicketInsert", "Insert Ticket");
            ChangeInsertTicketColour(greenColor);
        }

        private void DisplayRefundAmount()
        {
            refundAmountForm = new RefundAmount(insertedTicket.expiryDate);
            DisplayScreen(refundAmountForm, "RefundAmount", "Refund Remaining Time");
            refundAmountForm.FormClosed += (sender, e) => RefundAmount_HandleButtonClick(sender, e);
        }

        private void DisplayRefundSuccess()
        {
            refundSuccessForm = new RefundSuccess();
            DisplayScreen(refundSuccessForm, "RefundSuccess", "Refund was successful");
        }

        private void DisplayRemoveTicket()
        {
            ChangePrintTicketColour(greenColor);
            removeTicketForm = new RemoveTicket();
            DisplayScreen(removeTicketForm, "RemoveTicket", "Transaction Cancelled");
        }

        private void DisplayNextScreenAfterEjectCard()
        {
            ChangeInsertCardColour();
            if (!homeButtonClicked)
            {
                RemoveCurrentScreen();
                DisplayPrintingTicket();
            }
            else if (homeButtonClicked && (currentMode == Mode.AddToTicket || currentMode == Mode.RefundTicket))
            {
                homeButtonClicked = false;
                RemoveCurrentScreen();
                DisplayRemoveTicket();
                //RemoveInsertedTicket();
                //DisplayMainScreen();
            }
            else if (homeButtonClicked)
            {
                homeButtonClicked = false;
                RemoveCurrentScreen();
                DisplayMainScreen();
            }
        }


        private void HomeButton_Click(object sender, EventArgs e)
        {
            ExecuteHomeButtonCleanup();
        }

        private void ExecuteHomeButtonCleanup()
        {
            if (!cannotClickHome && currentTicketState != TicketState.TicketPrinted)
            {
                homeButtonClicked = true;
                SetAllButtonColoursToDefault();

                if (currentCardState == CardState.CardInserted)//(currentState == State.CardInserted)
                {
                    //Eject card
                    RemoveCurrentScreen();
                    DisplayEjectCard();
                    ChangeInsertCardColour(greenColor);
                }
                else if (currentTicketState == TicketState.TicketInserted)
                {
                    cannotClickHome = true;
                    ticketToBePrinted = insertedTicket;
                    RemoveCurrentScreen();
                    DisplayRemoveTicket();
                }
                else
                {
                    RemoveCurrentScreen();
                    //currentState = State.Neutral;
                    currentCardState = CardState.Neutral;
                    currentTicketState = TicketState.Neutral;
                    DisplayMainScreen();
                }

                currentCoinState = CoinState.Neutral;
                RefundCoins();

                //DestroyTicketToBePrinted();
                //TODO: Dispense all coins, Eject card prompt, Eject ticket, Destroy ticket to be printed
            }
        }


        //SUBSCREEN HANDLERS

        private void MainScreen_HandleButtonClick(object sender, FormClosedEventArgs e)
        {
            RemoveCurrentScreenByForm(mainScreenForm);
            switch (mainScreenForm.buttonPressed)
            {
                case "BuyTicket":
                    currentMode = Mode.BuyTicket;
                    //ChangeButtonToGreen();
                    DisplayPaymentScreen();
                    break;
                case "RefundTicket":
                    currentMode = Mode.RefundTicket;
                    //TODO: Implement this
                    DisplayTicketInsert();
                    break;
                case "AddTime":
                    currentMode = Mode.AddToTicket;
                    //TODO: Implement this
                    DisplayTicketInsert();
                    break;
            }
            //System.Windows.Forms.MessageBox.Show(mainScreenForm.buttonPressed);
        }

        private void SelectPaymentScreen_HandleButtonClick(object sender, FormClosedEventArgs e)
        {
            RemoveCurrentScreenByForm(selectPaymentScreenForm);
            switch (selectPaymentScreenForm.buttonPressed)
            {
                case "CreditDebit":
                    if (currentMode == Mode.BuyTicket)
                    {
                        DisplayAddTimeScreen();
                    }
                    else if (currentMode == Mode.AddToTicket)
                    {
                        DisplayAddTimeScreen(insertedTicket.expiryDate);
                    }
                    break;
                case "Coin":
                    if (currentMode == Mode.BuyTicket)
                    {
                        DisplayAddCoins();
                    }
                    else if (currentMode == Mode.AddToTicket)
                    {
                        DisplayAddCoins(insertedTicket.expiryDate);
                    }
                    break;
            }
        }

        private void AddTimeScreen_HandleButtonClick(object sender, FormClosedEventArgs e)
        {
            RemoveCurrentScreenByForm(addTimeScreenForm);
            switch (addTimeScreenForm.buttonPressed)
            {
                case "Confirm":
                    SetupTicketToBePrintedByCard();
                    //TODO: determine when ticketToBePrinted should be destroyed - homeCleanup, where else?
                    DisplayCreditDebitPrompt();
                    break;
                case "Return":
                    DisplayPaymentScreen();
                    break;
            }
        }

        private void CreditDebitPrompt_HandleButtonClick(object sender, FormClosedEventArgs e)
        {
            RemoveCurrentScreenByForm(creditDebitPromptForm);
            ChangeInsertCardColour();
            ChangeSwipeCardColour();
            switch (creditDebitPromptForm.buttonPressed)
            {
                case "ManualEntry":
                    DisplayCardManualEntry();
                    break;
            }
        }

        private void CardManualEntry_HandleButtonClick(object sender, FormClosedEventArgs e)
        {
            RemoveCurrentScreenByForm(cardManualEntryForm);
            switch (cardManualEntryForm.buttonPressed)
            {
                case "Cancel":
                    if (currentMode == Mode.BuyTicket)
                    {
                        ExecuteHomeButtonCleanup();
                    }
                    else if (currentMode == Mode.AddToTicket)
                    {
                        ExecuteHomeButtonCleanup();
                    }
                    break;
            }
        }

        private void PINEntry_HandleButtonClick(object sender, FormClosedEventArgs e)
        {
            RemoveCurrentScreenByForm(pinEntryForm);
            switch (pinEntryForm.buttonPressed)
            {
                case "Submit":
                    if (currentCardState == CardState.CardInserted)//(currentState == State.CardInserted) //Was a Card inserted
                    {
                        ChangeInsertCardColour(greenColor);
                        DisplayEjectCard();
                    }
                    else
                    {
                        DisplayPrintingTicket();
                    }
                    break;
                case "Cancel":
                    ExecuteHomeButtonCleanup();
                    break;
            }
        }

        private void AddCoins_HandleButtonClick(object sender, FormClosedEventArgs e)
        {
            ChangeCoinInsertColour();
            RemoveCurrentScreenByForm(addCoinsForm);
            switch (addCoinsForm.buttonPressed)
            {
                case "Submit":
                    currentCoinState = CoinState.Neutral;
                    if (currentMode == Mode.AddToTicket && currentTicketState == TicketState.TicketInserted)//Adding to inserted ticket
                    {
                        coinsInserted = 0;
                        DisplayPrintingTicket();
                        SetupTicketToBePrintedByCoin();
                    }
                    else if (currentMode == Mode.BuyTicket)
                    {
                        coinsInserted = 0;
                        DisplayPrintingTicket();
                        SetupTicketToBePrintedByCoin();
                    }
                    break;
                case "Refund":
                    ExecuteHomeButtonCleanup();
                    break;
            }
        }

        private void RefundAmount_HandleButtonClick(object sender, FormClosedEventArgs e)
        {
            RemoveCurrentScreenByForm(refundAmountForm);
            switch (refundAmountForm.buttonPressed)
            {
                case "Refund":
                    currentCoinState = CoinState.Neutral;
                    if (currentMode == Mode.RefundTicket && currentTicketState == TicketState.TicketInserted)//Refunding inserted ticket
                    {
                        currentTicketState = TicketState.Neutral;
                        insertedTicket = null;
                        coinsInRefund += refundAmountForm.amountToBeRefunded;
                        DisplayRefundSuccess();
                    }
                    else if (refundAmountForm.amountToBeRefunded == 0)
                    {
                        ExecuteHomeButtonCleanup();
                    }
                    break;
                case "Cancel":
                    ExecuteHomeButtonCleanup();
                    break;
            }
        }


        //HARDWARE HANDLERS
        public Boolean AllowTextChangeInsertCardToEjectCard()
        {
            if (currentCardState == CardState.CardReady && currentScreen == "CreditDebitPrompt") //(currentState == State.CardReady && currentScreen == "CreditDebitPrompt")
            {
                return true;
            }
            return false;
        }

        public Boolean AllowTextChangeEjectCardToInsertCard()
        {
            if (currentCardState == CardState.CardInserted && currentScreen == "EjectCard")//(currentState == State.CardInserted && currentScreen == "EjectCard") //TODO: Ensure we eject cards when necessary
            {
                return true;
            }
            return false;
        }

        public void HandleCardSwipe(CreditCard card)
        {
            HandleCard(card);
        }

        public void HandleCardInsert(CreditCard card)
        {
            if (insertedCard == null)
            {
                insertedCard = card;
                HandleCard(card);
                //currentState = State.CardInserted;
                currentCardState = CardState.CardInserted;
            }
        }

        public void HandleCardEject()
        {
            if (currentScreen == "EjectCard")
            {
                insertedCard = null;
                //currentState = State.Neutral;
                currentCardState = CardState.Neutral;
                DisplayNextScreenAfterEjectCard();
            }
        }

        public void HandleCoinInsert(double coinAmount)
        {
            if (currentCoinState == CoinState.CoinReady && currentScreen == "AddCoins") //TODO: verify I don't need currentScreen == "AddCoins"
            {
                InsertCoin(coinAmount);
            }
        }

        public double HandleCoinReturn()
        {
            return EmptyRefundedCoins();
        }

        public Ticket HandlePrintTicket()
        {
            if (currentTicketState == TicketState.TicketPrinted)//(currentState == State.TicketPrinted)
            {
                ChangePrintTicketColour();
                //currentState = State.Neutral; //TODO: veryify this is correct
                currentTicketState = TicketState.Neutral;
                Ticket tempTicketToBePrinted = ticketToBePrinted;
                ticketToBePrinted = null; //TODO: verify this does not have any ramifications
                RemoveCurrentScreen();
                DisplayMainScreen();
                return tempTicketToBePrinted;
            }
            else if (currentTicketState == TicketState.TicketInserted && currentScreen == "RemoveTicket")//(currentState == State.TicketInserted) //Return old ticket - same screen as PrintingTicket
            {
                ChangePrintTicketColour();
                //currentState = State.Neutral; //TODO: verify this is correct
                Ticket tempInsertedTicket = insertedTicket;
                insertedTicket = null;
                //Check HomeButtonClicked variable
                cannotClickHome = false; //TODO: verify this doesn't mess anything up
                RemoveCurrentScreen();
                DisplayMainScreen();
                return tempInsertedTicket;
            }
            return null;
        }

        public Boolean HandleInsertTicket()
        {
            if (currentTicket != null && currentTicketState == TicketState.TicketInsertRequired && currentScreen == "TicketInsert")//(currentState == State.TicketInsertRequired)
            {
                insertedTicket = currentTicket; //this might be wrong
                ChangeInsertTicketColour();
                //currentState = State.TicketInserted;
                currentTicketState = TicketState.TicketInserted;
                RemoveCurrentScreen();
                if (currentMode == Mode.RefundTicket)
                {
                    DisplayRefundAmount();
                }
                else if (currentMode == Mode.AddToTicket)
                {
                    DisplayPaymentScreen();
                }
                return true;
            }
            return false;
        }


        //Handle Card Transactions

        private void HandleCard(CreditCard card)
        {
            if (card.canBeSwiped)
            {
                declinedCount = 0;
                creditDebitPromptForm.SetLabelVisibilities(false);
                RemoveCurrentScreenByForm(creditDebitPromptForm);
                DisplayPINEntry(card.pin);

                ChangeInsertCardColour();
                ChangeSwipeCardColour();
            }
            else if (!card.canBeSwiped && declinedCount >= declinedCountLimit - 1)
            {
                //Display option to enter Card Info manually
                creditDebitPromptForm.SetCardInfoEntryVisbility(true);
            }
            else if (!card.canBeSwiped)
            {
                creditDebitPromptForm.SetCardDeclinedVisibility(true);
                declinedCount++; //TODO: reset declinedCount
            }
        }

        private void HandleCardManualEntrySubmission(string[] cardCredentials)
        {
            string creditCardNumber = cardCredentials[0];
            string cvvNumber = cardCredentials[1];
            if (CreditCardExists(creditCardNumber, cvvNumber))
            {
                cardManualEntryForm.Close();
                DisplayPrintingTicket();
            }
            else
            {
                cardManualEntryForm.SetCardInvalidLabelVisibility(true);
            }
        }

        private Boolean CreditCardExists(string creditCardNumber, string cvvNumber)
        {

            foreach (CreditCard card in creditCards)
            {
                if (card.cardNumber == creditCardNumber && card.CVV.ToString() == cvvNumber)
                {
                    return true;
                }
            }
            return false;
        }


        //Handle Ticket Transactions

        private void SetupTicketToBePrintedByCard()
        {
            ticketToBePrinted = new ParkingMachine.Ticket(ticketIndex, addTimeScreenForm.currentTime, addTimeScreenForm.validTillDate);
            ticketIndex++;
        }

        private void SetupTicketToBePrintedByCoin()
        {
            ticketToBePrinted = new ParkingMachine.Ticket(ticketIndex, addCoinsForm.currentDateTime, addCoinsForm.validTill);
            ticketIndex++;
        }

        private void DestroyTicketToBePrinted()
        {
            ticketToBePrinted = null;
        }

        private void RemoveInsertedTicket()
        {
            RemoveCurrentScreen();
            //DisplayRemoveTicket();
        }


        //Handle Coin Transactions

        private void InsertCoin(double coinAmount)
        {
            coinsInserted += coinAmount;
            if (coinAmount == 0.25)
            {
                addCoinsForm.AddQuarter();
            }
            else if (coinAmount == 1.00)
            {
                addCoinsForm.AddLoonie();
            }
            else if (coinAmount == 2.00)
            {
                addCoinsForm.AddToonie();
            }
        }

        private void RefundCoins()
        {
            ChangeCoinInsertColour();
            coinsInRefund += coinsInserted;
            if (coinsInRefund > 0)
            {
                ChangeCoinRefundColour(greenColor);
            }
            coinsInserted = 0;
        }

        public double EmptyRefundedCoins()
        {
            double tempCoinsInRefund = coinsInRefund;
            coinsInRefund = 0.00;
            ChangeCoinRefundColour();
            return tempCoinsInRefund;
        }


        //Hardware Button Manipulation

        private void ChangeButtonColour(Button button, Color? newColor = null)
        {
            if (newColor == null || button.BackColor == greenColor)
            {
                button.BackColor = defaultColor;
            }
            else
            {
                button.BackColor = greenColor;
            }
        }

        private void ChangeInsertCardColour(Color? newColor = null)
        {
            Button button = ((HardwareInterface)this.ParentForm).InsertCardButton;
            ChangeButtonColour(button, newColor);
        }

        private void ChangeSwipeCardColour(Color? newColor = null)
        {
            Button button = ((HardwareInterface)this.ParentForm).CardSwipeButton;
            ChangeButtonColour(button, newColor);
        }

        private void ChangeCoinInsertColour(Color? newColor = null)
        {
            Button button = ((HardwareInterface)this.ParentForm).CoinInsertButton;
            ChangeButtonColour(button, newColor);
        }

        private void ChangeCoinRefundColour(Color? newColor = null)
        {
            Button button = ((HardwareInterface)this.ParentForm).CoinReturnButton;
            ChangeButtonColour(button, newColor);
        }

        private void ChangePrintTicketColour(Color? newColor = null)
        {
            Button button = ((HardwareInterface)this.ParentForm).PrintedTicketButton;
            ChangeButtonColour(button, newColor);
        }

        private void ChangeInsertTicketColour(Color? newColor = null)
        {
            Button button = ((HardwareInterface)this.ParentForm).InsertTicketButton;
            ChangeButtonColour(button, newColor);
        }

        private void SetAllButtonColoursToDefault()
        {
            ((HardwareInterface)this.ParentForm).InsertCardButton.BackColor = defaultColor;
            ((HardwareInterface)this.ParentForm).CardSwipeButton.BackColor = defaultColor;
        }
    }
}
