namespace ParkingMachine
{
    partial class CreditDebitPrompt
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
            this.SwipeLabel = new System.Windows.Forms.Label();
            this.CardDeclinedLabel = new System.Windows.Forms.Label();
            this.CardInfoEntryLabel = new System.Windows.Forms.Label();
            this.CardInfoEntryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SwipeLabel
            // 
            this.SwipeLabel.AutoSize = true;
            this.SwipeLabel.Font = new System.Drawing.Font("Marlett", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwipeLabel.Location = new System.Drawing.Point(93, 50);
            this.SwipeLabel.Name = "SwipeLabel";
            this.SwipeLabel.Size = new System.Drawing.Size(517, 40);
            this.SwipeLabel.TabIndex = 0;
            this.SwipeLabel.Text = "Please Swipe or Insert your Card";
            // 
            // CardDeclinedLabel
            // 
            this.CardDeclinedLabel.AutoSize = true;
            this.CardDeclinedLabel.Font = new System.Drawing.Font("Marlett", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardDeclinedLabel.Location = new System.Drawing.Point(77, 295);
            this.CardDeclinedLabel.Name = "CardDeclinedLabel";
            this.CardDeclinedLabel.Size = new System.Drawing.Size(533, 27);
            this.CardDeclinedLabel.TabIndex = 2;
            this.CardDeclinedLabel.Text = "Card was declined, try swiping or inserting again";
            this.CardDeclinedLabel.Visible = false;
            // 
            // CardInfoEntryLabel
            // 
            this.CardInfoEntryLabel.AutoSize = true;
            this.CardInfoEntryLabel.Font = new System.Drawing.Font("Marlett", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardInfoEntryLabel.Location = new System.Drawing.Point(28, 322);
            this.CardInfoEntryLabel.Name = "CardInfoEntryLabel";
            this.CardInfoEntryLabel.Size = new System.Drawing.Size(674, 27);
            this.CardInfoEntryLabel.TabIndex = 3;
            this.CardInfoEntryLabel.Text = "Alternatively you may enter card information to make payment";
            this.CardInfoEntryLabel.UseMnemonic = false;
            this.CardInfoEntryLabel.Visible = false;
            // 
            // CardInfoEntryButton
            // 
            this.CardInfoEntryButton.BackColor = System.Drawing.Color.White;
            this.CardInfoEntryButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CardInfoEntryButton.FlatAppearance.BorderSize = 3;
            this.CardInfoEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CardInfoEntryButton.Font = new System.Drawing.Font("Marlett", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardInfoEntryButton.Location = new System.Drawing.Point(261, 367);
            this.CardInfoEntryButton.Name = "CardInfoEntryButton";
            this.CardInfoEntryButton.Size = new System.Drawing.Size(171, 77);
            this.CardInfoEntryButton.TabIndex = 4;
            this.CardInfoEntryButton.Text = "Enter Card Info";
            this.CardInfoEntryButton.UseVisualStyleBackColor = false;
            this.CardInfoEntryButton.Visible = false;
            this.CardInfoEntryButton.Click += new System.EventHandler(this.CardInfoEntryButton_Click);
            // 
            // CreditDebitPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(744, 635);
            this.Controls.Add(this.CardInfoEntryButton);
            this.Controls.Add(this.CardInfoEntryLabel);
            this.Controls.Add(this.CardDeclinedLabel);
            this.Controls.Add(this.SwipeLabel);
            this.Name = "CreditDebitPrompt";
            this.Text = "CreditDebitPromptcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SwipeLabel;
        private System.Windows.Forms.Label CardDeclinedLabel;
        private System.Windows.Forms.Label CardInfoEntryLabel;
        private System.Windows.Forms.Button CardInfoEntryButton;
    }
}