namespace ParkingMachine
{
    partial class HardwareInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CardSwipeButton = new System.Windows.Forms.Button();
            this.InsertCardButton = new System.Windows.Forms.Button();
            this.CoinInsertButton = new System.Windows.Forms.Button();
            this.CoinReturnButton = new System.Windows.Forms.Button();
            this.PrintedTicketButton = new System.Windows.Forms.Button();
            this.InsertTicketButton = new System.Windows.Forms.Button();
            this.TouchScreenPanel = new System.Windows.Forms.Panel();
            this.ticketCBO = new System.Windows.Forms.ComboBox();
            this.cardCBO = new System.Windows.Forms.ComboBox();
            this.TicketLabel = new System.Windows.Forms.Label();
            this.CardLabel = new System.Windows.Forms.Label();
            this.CoinInsertLabel = new System.Windows.Forms.Label();
            this.coinInsertCBO = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CardSwipeButton
            // 
            this.CardSwipeButton.AutoSize = true;
            this.CardSwipeButton.Location = new System.Drawing.Point(12, 120);
            this.CardSwipeButton.Name = "CardSwipeButton";
            this.CardSwipeButton.Size = new System.Drawing.Size(101, 43);
            this.CardSwipeButton.TabIndex = 0;
            this.CardSwipeButton.Text = "Swipe Card";
            this.CardSwipeButton.UseVisualStyleBackColor = true;
            this.CardSwipeButton.Click += new System.EventHandler(this.CardSwipeButton_Click);
            // 
            // InsertCardButton
            // 
            this.InsertCardButton.Location = new System.Drawing.Point(15, 212);
            this.InsertCardButton.Name = "InsertCardButton";
            this.InsertCardButton.Size = new System.Drawing.Size(101, 43);
            this.InsertCardButton.TabIndex = 1;
            this.InsertCardButton.Text = "Insert Card";
            this.InsertCardButton.UseVisualStyleBackColor = true;
            this.InsertCardButton.Click += new System.EventHandler(this.InsertCardButton_Click);
            // 
            // CoinInsertButton
            // 
            this.CoinInsertButton.Location = new System.Drawing.Point(927, 120);
            this.CoinInsertButton.Name = "CoinInsertButton";
            this.CoinInsertButton.Size = new System.Drawing.Size(101, 43);
            this.CoinInsertButton.TabIndex = 2;
            this.CoinInsertButton.Text = "Coin Insert";
            this.CoinInsertButton.UseVisualStyleBackColor = true;
            this.CoinInsertButton.Click += new System.EventHandler(this.CoinInsertButton_Click);
            // 
            // CoinReturnButton
            // 
            this.CoinReturnButton.Location = new System.Drawing.Point(927, 212);
            this.CoinReturnButton.Name = "CoinReturnButton";
            this.CoinReturnButton.Size = new System.Drawing.Size(101, 43);
            this.CoinReturnButton.TabIndex = 3;
            this.CoinReturnButton.Text = "Coin Return";
            this.CoinReturnButton.UseMnemonic = false;
            this.CoinReturnButton.UseVisualStyleBackColor = true;
            this.CoinReturnButton.Click += new System.EventHandler(this.CoinReturnButton_Click);
            // 
            // PrintedTicketButton
            // 
            this.PrintedTicketButton.Location = new System.Drawing.Point(930, 402);
            this.PrintedTicketButton.Name = "PrintedTicketButton";
            this.PrintedTicketButton.Size = new System.Drawing.Size(101, 43);
            this.PrintedTicketButton.TabIndex = 4;
            this.PrintedTicketButton.Text = "Printed Ticket";
            this.PrintedTicketButton.UseVisualStyleBackColor = true;
            this.PrintedTicketButton.Click += new System.EventHandler(this.PrintedTicketButton_Click);
            // 
            // InsertTicketButton
            // 
            this.InsertTicketButton.Location = new System.Drawing.Point(927, 478);
            this.InsertTicketButton.Name = "InsertTicketButton";
            this.InsertTicketButton.Size = new System.Drawing.Size(101, 43);
            this.InsertTicketButton.TabIndex = 5;
            this.InsertTicketButton.Text = "Insert Ticket";
            this.InsertTicketButton.UseVisualStyleBackColor = true;
            this.InsertTicketButton.Click += new System.EventHandler(this.InsertTicketButton_Click);
            // 
            // TouchScreenPanel
            // 
            this.TouchScreenPanel.Location = new System.Drawing.Point(139, 28);
            this.TouchScreenPanel.Name = "TouchScreenPanel";
            this.TouchScreenPanel.Size = new System.Drawing.Size(754, 640);
            this.TouchScreenPanel.TabIndex = 6;
            // 
            // ticketCBO
            // 
            this.ticketCBO.FormattingEnabled = true;
            this.ticketCBO.Location = new System.Drawing.Point(927, 346);
            this.ticketCBO.Name = "ticketCBO";
            this.ticketCBO.Size = new System.Drawing.Size(98, 21);
            this.ticketCBO.TabIndex = 9;
            this.ticketCBO.SelectionChangeCommitted += new System.EventHandler(this.ticketCBO_SelectionChangeCommitted);
            // 
            // cardCBO
            // 
            this.cardCBO.FormattingEnabled = true;
            this.cardCBO.Location = new System.Drawing.Point(15, 81);
            this.cardCBO.Name = "cardCBO";
            this.cardCBO.Size = new System.Drawing.Size(98, 21);
            this.cardCBO.TabIndex = 10;
            this.cardCBO.SelectionChangeCommitted += new System.EventHandler(this.cardCBO_SelectionChangeCommitted);
            // 
            // TicketLabel
            // 
            this.TicketLabel.AutoSize = true;
            this.TicketLabel.Location = new System.Drawing.Point(924, 318);
            this.TicketLabel.Name = "TicketLabel";
            this.TicketLabel.Size = new System.Drawing.Size(42, 13);
            this.TicketLabel.TabIndex = 11;
            this.TicketLabel.Text = "Tickets";
            // 
            // CardLabel
            // 
            this.CardLabel.AutoSize = true;
            this.CardLabel.Location = new System.Drawing.Point(12, 53);
            this.CardLabel.Name = "CardLabel";
            this.CardLabel.Size = new System.Drawing.Size(34, 13);
            this.CardLabel.TabIndex = 12;
            this.CardLabel.Text = "Cards";
            // 
            // CoinInsertLabel
            // 
            this.CoinInsertLabel.AutoSize = true;
            this.CoinInsertLabel.Location = new System.Drawing.Point(924, 53);
            this.CoinInsertLabel.Name = "CoinInsertLabel";
            this.CoinInsertLabel.Size = new System.Drawing.Size(57, 13);
            this.CoinInsertLabel.TabIndex = 13;
            this.CoinInsertLabel.Text = "Coin Insert";
            // 
            // coinInsertCBO
            // 
            this.coinInsertCBO.FormattingEnabled = true;
            this.coinInsertCBO.Location = new System.Drawing.Point(927, 79);
            this.coinInsertCBO.Name = "coinInsertCBO";
            this.coinInsertCBO.Size = new System.Drawing.Size(121, 21);
            this.coinInsertCBO.TabIndex = 14;
            // 
            // HardwareInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1064, 675);
            this.Controls.Add(this.coinInsertCBO);
            this.Controls.Add(this.CoinInsertLabel);
            this.Controls.Add(this.CardLabel);
            this.Controls.Add(this.TicketLabel);
            this.Controls.Add(this.cardCBO);
            this.Controls.Add(this.ticketCBO);
            this.Controls.Add(this.TouchScreenPanel);
            this.Controls.Add(this.InsertTicketButton);
            this.Controls.Add(this.PrintedTicketButton);
            this.Controls.Add(this.CoinReturnButton);
            this.Controls.Add(this.CoinInsertButton);
            this.Controls.Add(this.InsertCardButton);
            this.Controls.Add(this.CardSwipeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HardwareInterface";
            this.Text = "HardwareInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel TouchScreenPanel;
        private System.Windows.Forms.ComboBox ticketCBO;
        private System.Windows.Forms.ComboBox cardCBO;
        private System.Windows.Forms.Label TicketLabel;
        private System.Windows.Forms.Label CardLabel;
        private System.Windows.Forms.Label CoinInsertLabel;
        private System.Windows.Forms.ComboBox coinInsertCBO;
        public System.Windows.Forms.Button InsertCardButton;
        public System.Windows.Forms.Button CardSwipeButton;
        public System.Windows.Forms.Button CoinInsertButton;
        public System.Windows.Forms.Button CoinReturnButton;
        public System.Windows.Forms.Button PrintedTicketButton;
        public System.Windows.Forms.Button InsertTicketButton;
    }
}