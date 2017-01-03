namespace ParkingMachine
{
    partial class CardManualEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.CVVLabel = new System.Windows.Forms.Label();
            this.CreditCardNumber = new System.Windows.Forms.TextBox();
            this.CVV = new System.Windows.Forms.TextBox();
            this.ZeroPinButton = new System.Windows.Forms.Button();
            this.CorrectionButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NinePinButton = new System.Windows.Forms.Button();
            this.EightPinButton = new System.Windows.Forms.Button();
            this.SevenPinButton = new System.Windows.Forms.Button();
            this.SixPinButton = new System.Windows.Forms.Button();
            this.FivePinButton = new System.Windows.Forms.Button();
            this.FourPinButton = new System.Windows.Forms.Button();
            this.ThreePinButton = new System.Windows.Forms.Button();
            this.TwoPinButton = new System.Windows.Forms.Button();
            this.OnePinButton = new System.Windows.Forms.Button();
            this.CardInvalidLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Marlett", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Number (no spaces):";
            // 
            // CVVLabel
            // 
            this.CVVLabel.AutoSize = true;
            this.CVVLabel.Font = new System.Drawing.Font("Marlett", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVVLabel.Location = new System.Drawing.Point(214, 122);
            this.CVVLabel.Name = "CVVLabel";
            this.CVVLabel.Size = new System.Drawing.Size(63, 25);
            this.CVVLabel.TabIndex = 2;
            this.CVVLabel.Text = "CVV:";
            // 
            // CreditCardNumber
            // 
            this.CreditCardNumber.Font = new System.Drawing.Font("Marlett", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCardNumber.Location = new System.Drawing.Point(286, 82);
            this.CreditCardNumber.Name = "CreditCardNumber";
            this.CreditCardNumber.Size = new System.Drawing.Size(436, 27);
            this.CreditCardNumber.TabIndex = 24;
            this.CreditCardNumber.Click += new System.EventHandler(this.CreditCardNumber_Click);
            // 
            // CVV
            // 
            this.CVV.Font = new System.Drawing.Font("Marlett", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVV.Location = new System.Drawing.Point(286, 120);
            this.CVV.Name = "CVV";
            this.CVV.Size = new System.Drawing.Size(125, 27);
            this.CVV.TabIndex = 25;
            this.CVV.Click += new System.EventHandler(this.CVV_Click);
            // 
            // ZeroPinButton
            // 
            this.ZeroPinButton.BackColor = System.Drawing.Color.White;
            this.ZeroPinButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ZeroPinButton.FlatAppearance.BorderSize = 2;
            this.ZeroPinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZeroPinButton.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroPinButton.Location = new System.Drawing.Point(286, 417);
            this.ZeroPinButton.Name = "ZeroPinButton";
            this.ZeroPinButton.Size = new System.Drawing.Size(67, 61);
            this.ZeroPinButton.TabIndex = 42;
            this.ZeroPinButton.Text = "0";
            this.ZeroPinButton.UseVisualStyleBackColor = false;
            this.ZeroPinButton.Click += new System.EventHandler(this.ZeroPinButton_Click);
            // 
            // CorrectionButton
            // 
            this.CorrectionButton.BackColor = System.Drawing.Color.Yellow;
            this.CorrectionButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CorrectionButton.FlatAppearance.BorderSize = 3;
            this.CorrectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CorrectionButton.Font = new System.Drawing.Font("Marlett", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectionButton.Location = new System.Drawing.Point(483, 343);
            this.CorrectionButton.Name = "CorrectionButton";
            this.CorrectionButton.Size = new System.Drawing.Size(117, 59);
            this.CorrectionButton.TabIndex = 41;
            this.CorrectionButton.Text = "Correction";
            this.CorrectionButton.UseVisualStyleBackColor = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.Green;
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SubmitButton.FlatAppearance.BorderSize = 3;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Marlett", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(483, 180);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(117, 59);
            this.SubmitButton.TabIndex = 40;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Red;
            this.CancelButton.FlatAppearance.BorderSize = 3;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Marlett", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(483, 262);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(117, 59);
            this.CancelButton.TabIndex = 39;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // NinePinButton
            // 
            this.NinePinButton.BackColor = System.Drawing.Color.White;
            this.NinePinButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NinePinButton.FlatAppearance.BorderSize = 2;
            this.NinePinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NinePinButton.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NinePinButton.Location = new System.Drawing.Point(375, 341);
            this.NinePinButton.Name = "NinePinButton";
            this.NinePinButton.Size = new System.Drawing.Size(67, 61);
            this.NinePinButton.TabIndex = 38;
            this.NinePinButton.Text = "9";
            this.NinePinButton.UseVisualStyleBackColor = false;
            this.NinePinButton.Click += new System.EventHandler(this.NinePinButton_Click);
            // 
            // EightPinButton
            // 
            this.EightPinButton.BackColor = System.Drawing.Color.White;
            this.EightPinButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EightPinButton.FlatAppearance.BorderSize = 2;
            this.EightPinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EightPinButton.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightPinButton.Location = new System.Drawing.Point(286, 341);
            this.EightPinButton.Name = "EightPinButton";
            this.EightPinButton.Size = new System.Drawing.Size(67, 61);
            this.EightPinButton.TabIndex = 37;
            this.EightPinButton.Text = "8";
            this.EightPinButton.UseVisualStyleBackColor = false;
            this.EightPinButton.Click += new System.EventHandler(this.EightPinButton_Click);
            // 
            // SevenPinButton
            // 
            this.SevenPinButton.BackColor = System.Drawing.Color.White;
            this.SevenPinButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SevenPinButton.FlatAppearance.BorderSize = 2;
            this.SevenPinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SevenPinButton.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenPinButton.Location = new System.Drawing.Point(194, 341);
            this.SevenPinButton.Name = "SevenPinButton";
            this.SevenPinButton.Size = new System.Drawing.Size(67, 61);
            this.SevenPinButton.TabIndex = 36;
            this.SevenPinButton.Text = "7";
            this.SevenPinButton.UseVisualStyleBackColor = false;
            this.SevenPinButton.Click += new System.EventHandler(this.SevenPinButton_Click);
            // 
            // SixPinButton
            // 
            this.SixPinButton.BackColor = System.Drawing.Color.White;
            this.SixPinButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SixPinButton.FlatAppearance.BorderSize = 2;
            this.SixPinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SixPinButton.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixPinButton.Location = new System.Drawing.Point(375, 260);
            this.SixPinButton.Name = "SixPinButton";
            this.SixPinButton.Size = new System.Drawing.Size(67, 61);
            this.SixPinButton.TabIndex = 35;
            this.SixPinButton.Text = "6";
            this.SixPinButton.UseVisualStyleBackColor = false;
            this.SixPinButton.Click += new System.EventHandler(this.SixPinButton_Click);
            // 
            // FivePinButton
            // 
            this.FivePinButton.BackColor = System.Drawing.Color.White;
            this.FivePinButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FivePinButton.FlatAppearance.BorderSize = 2;
            this.FivePinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FivePinButton.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FivePinButton.Location = new System.Drawing.Point(286, 260);
            this.FivePinButton.Name = "FivePinButton";
            this.FivePinButton.Size = new System.Drawing.Size(67, 61);
            this.FivePinButton.TabIndex = 34;
            this.FivePinButton.Text = "5";
            this.FivePinButton.UseVisualStyleBackColor = false;
            this.FivePinButton.Click += new System.EventHandler(this.FivePinButton_Click);
            // 
            // FourPinButton
            // 
            this.FourPinButton.BackColor = System.Drawing.Color.White;
            this.FourPinButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.FourPinButton.FlatAppearance.BorderSize = 2;
            this.FourPinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourPinButton.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourPinButton.Location = new System.Drawing.Point(194, 260);
            this.FourPinButton.Name = "FourPinButton";
            this.FourPinButton.Size = new System.Drawing.Size(67, 61);
            this.FourPinButton.TabIndex = 33;
            this.FourPinButton.Text = "4";
            this.FourPinButton.UseVisualStyleBackColor = false;
            this.FourPinButton.Click += new System.EventHandler(this.FourPinButton_Click);
            // 
            // ThreePinButton
            // 
            this.ThreePinButton.BackColor = System.Drawing.Color.White;
            this.ThreePinButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ThreePinButton.FlatAppearance.BorderSize = 2;
            this.ThreePinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThreePinButton.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreePinButton.Location = new System.Drawing.Point(375, 178);
            this.ThreePinButton.Name = "ThreePinButton";
            this.ThreePinButton.Size = new System.Drawing.Size(67, 61);
            this.ThreePinButton.TabIndex = 32;
            this.ThreePinButton.Text = "3";
            this.ThreePinButton.UseVisualStyleBackColor = false;
            this.ThreePinButton.Click += new System.EventHandler(this.ThreePinButton_Click);
            // 
            // TwoPinButton
            // 
            this.TwoPinButton.BackColor = System.Drawing.Color.White;
            this.TwoPinButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TwoPinButton.FlatAppearance.BorderSize = 2;
            this.TwoPinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoPinButton.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoPinButton.Location = new System.Drawing.Point(286, 178);
            this.TwoPinButton.Name = "TwoPinButton";
            this.TwoPinButton.Size = new System.Drawing.Size(67, 61);
            this.TwoPinButton.TabIndex = 31;
            this.TwoPinButton.Text = "2";
            this.TwoPinButton.UseVisualStyleBackColor = false;
            this.TwoPinButton.Click += new System.EventHandler(this.TwoPinButton_Click);
            // 
            // OnePinButton
            // 
            this.OnePinButton.BackColor = System.Drawing.Color.White;
            this.OnePinButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.OnePinButton.FlatAppearance.BorderSize = 2;
            this.OnePinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OnePinButton.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnePinButton.Location = new System.Drawing.Point(194, 178);
            this.OnePinButton.Name = "OnePinButton";
            this.OnePinButton.Size = new System.Drawing.Size(67, 61);
            this.OnePinButton.TabIndex = 30;
            this.OnePinButton.Text = "1";
            this.OnePinButton.UseVisualStyleBackColor = false;
            this.OnePinButton.Click += new System.EventHandler(this.OnePinButton_Click);
            // 
            // CardInvalidLabel
            // 
            this.CardInvalidLabel.AutoSize = true;
            this.CardInvalidLabel.Font = new System.Drawing.Font("Marlett", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardInvalidLabel.Location = new System.Drawing.Point(40, 490);
            this.CardInvalidLabel.Name = "CardInvalidLabel";
            this.CardInvalidLabel.Size = new System.Drawing.Size(692, 27);
            this.CardInvalidLabel.TabIndex = 43;
            this.CardInvalidLabel.Text = "Credentials entered are incorrect. Please enter valid credentials";
            // 
            // CardManualEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(744, 635);
            this.Controls.Add(this.CardInvalidLabel);
            this.Controls.Add(this.ZeroPinButton);
            this.Controls.Add(this.CorrectionButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NinePinButton);
            this.Controls.Add(this.EightPinButton);
            this.Controls.Add(this.SevenPinButton);
            this.Controls.Add(this.SixPinButton);
            this.Controls.Add(this.FivePinButton);
            this.Controls.Add(this.FourPinButton);
            this.Controls.Add(this.ThreePinButton);
            this.Controls.Add(this.TwoPinButton);
            this.Controls.Add(this.OnePinButton);
            this.Controls.Add(this.CVV);
            this.Controls.Add(this.CreditCardNumber);
            this.Controls.Add(this.CVVLabel);
            this.Controls.Add(this.label1);
            this.Name = "CardManualEntry";
            this.Text = "CardManualEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CVVLabel;
        private System.Windows.Forms.TextBox CreditCardNumber;
        private System.Windows.Forms.TextBox CVV;
        private System.Windows.Forms.Button ZeroPinButton;
        private System.Windows.Forms.Button CorrectionButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NinePinButton;
        private System.Windows.Forms.Button EightPinButton;
        private System.Windows.Forms.Button SevenPinButton;
        private System.Windows.Forms.Button SixPinButton;
        private System.Windows.Forms.Button FivePinButton;
        private System.Windows.Forms.Button FourPinButton;
        private System.Windows.Forms.Button ThreePinButton;
        private System.Windows.Forms.Button TwoPinButton;
        private System.Windows.Forms.Button OnePinButton;
        private System.Windows.Forms.Label CardInvalidLabel;
    }
}