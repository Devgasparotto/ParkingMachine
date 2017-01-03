namespace ParkingMachine
{
    partial class SelectPaymentScreen
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
            this.PayPromptLabel = new System.Windows.Forms.Label();
            this.CreditDebitButton = new System.Windows.Forms.Button();
            this.CoinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PayPromptLabel
            // 
            this.PayPromptLabel.AutoSize = true;
            this.PayPromptLabel.Font = new System.Drawing.Font("Marlett", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayPromptLabel.Location = new System.Drawing.Point(57, 106);
            this.PayPromptLabel.Name = "PayPromptLabel";
            this.PayPromptLabel.Size = new System.Drawing.Size(653, 56);
            this.PayPromptLabel.TabIndex = 0;
            this.PayPromptLabel.Text = "How would you like to pay?";
            // 
            // CreditDebitButton
            // 
            this.CreditDebitButton.BackColor = System.Drawing.Color.White;
            this.CreditDebitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CreditDebitButton.FlatAppearance.BorderSize = 3;
            this.CreditDebitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreditDebitButton.Font = new System.Drawing.Font("Marlett", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditDebitButton.Location = new System.Drawing.Point(189, 218);
            this.CreditDebitButton.Name = "CreditDebitButton";
            this.CreditDebitButton.Size = new System.Drawing.Size(290, 86);
            this.CreditDebitButton.TabIndex = 1;
            this.CreditDebitButton.Text = "Credit / Debit";
            this.CreditDebitButton.UseVisualStyleBackColor = false;
            this.CreditDebitButton.Click += new System.EventHandler(this.CreditDebitButton_Click);
            // 
            // CoinButton
            // 
            this.CoinButton.BackColor = System.Drawing.Color.White;
            this.CoinButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CoinButton.FlatAppearance.BorderSize = 3;
            this.CoinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CoinButton.Font = new System.Drawing.Font("Marlett", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoinButton.Location = new System.Drawing.Point(189, 372);
            this.CoinButton.Name = "CoinButton";
            this.CoinButton.Size = new System.Drawing.Size(290, 86);
            this.CoinButton.TabIndex = 2;
            this.CoinButton.Text = "Coin";
            this.CoinButton.UseVisualStyleBackColor = false;
            this.CoinButton.Click += new System.EventHandler(this.CoinButton_Click);
            // 
            // SelectPaymentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(744, 635);
            this.Controls.Add(this.CoinButton);
            this.Controls.Add(this.CreditDebitButton);
            this.Controls.Add(this.PayPromptLabel);
            this.Name = "SelectPaymentScreen";
            this.Text = "SelectPaymentScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PayPromptLabel;
        private System.Windows.Forms.Button CreditDebitButton;
        private System.Windows.Forms.Button CoinButton;
    }
}