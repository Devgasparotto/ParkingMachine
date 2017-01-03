namespace ParkingMachine
{
    partial class CreditCard
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
            this.CreditCardNumber = new System.Windows.Forms.Label();
            this.CVVLabel = new System.Windows.Forms.Label();
            this.CVVValue = new System.Windows.Forms.Label();
            this.IsAcceptableLabel = new System.Windows.Forms.Label();
            this.CreditCardLabel = new System.Windows.Forms.Label();
            this.PINLabel = new System.Windows.Forms.Label();
            this.PIN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreditCardNumber
            // 
            this.CreditCardNumber.AutoSize = true;
            this.CreditCardNumber.Font = new System.Drawing.Font("Marlett", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCardNumber.Location = new System.Drawing.Point(23, 65);
            this.CreditCardNumber.Name = "CreditCardNumber";
            this.CreditCardNumber.Size = new System.Drawing.Size(349, 33);
            this.CreditCardNumber.TabIndex = 0;
            this.CreditCardNumber.Text = "XXXX-XXXX-XXXX-XXXX";
            // 
            // CVVLabel
            // 
            this.CVVLabel.AutoSize = true;
            this.CVVLabel.Font = new System.Drawing.Font("Marlett", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVVLabel.Location = new System.Drawing.Point(24, 118);
            this.CVVLabel.Name = "CVVLabel";
            this.CVVLabel.Size = new System.Drawing.Size(51, 24);
            this.CVVLabel.TabIndex = 1;
            this.CVVLabel.Text = "CVV";
            // 
            // CVVValue
            // 
            this.CVVValue.AutoSize = true;
            this.CVVValue.Font = new System.Drawing.Font("Marlett", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVVValue.Location = new System.Drawing.Point(121, 119);
            this.CVVValue.Name = "CVVValue";
            this.CVVValue.Size = new System.Drawing.Size(21, 22);
            this.CVVValue.TabIndex = 2;
            this.CVVValue.Text = "0";
            // 
            // IsAcceptableLabel
            // 
            this.IsAcceptableLabel.AutoSize = true;
            this.IsAcceptableLabel.Font = new System.Drawing.Font("Marlett", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsAcceptableLabel.Location = new System.Drawing.Point(26, 164);
            this.IsAcceptableLabel.Name = "IsAcceptableLabel";
            this.IsAcceptableLabel.Size = new System.Drawing.Size(97, 24);
            this.IsAcceptableLabel.TabIndex = 3;
            this.IsAcceptableLabel.Text = "Accepted";
            // 
            // CreditCardLabel
            // 
            this.CreditCardLabel.AutoSize = true;
            this.CreditCardLabel.Font = new System.Drawing.Font("Marlett", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCardLabel.Location = new System.Drawing.Point(12, 9);
            this.CreditCardLabel.Name = "CreditCardLabel";
            this.CreditCardLabel.Size = new System.Drawing.Size(91, 40);
            this.CreditCardLabel.TabIndex = 4;
            this.CreditCardLabel.Text = "Card";
            // 
            // PINLabel
            // 
            this.PINLabel.AutoSize = true;
            this.PINLabel.Font = new System.Drawing.Font("Marlett", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINLabel.Location = new System.Drawing.Point(353, 164);
            this.PINLabel.Name = "PINLabel";
            this.PINLabel.Size = new System.Drawing.Size(40, 24);
            this.PINLabel.TabIndex = 5;
            this.PINLabel.Text = "Pin";
            // 
            // PIN
            // 
            this.PIN.AutoSize = true;
            this.PIN.Font = new System.Drawing.Font("Marlett", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIN.Location = new System.Drawing.Point(402, 164);
            this.PIN.Name = "PIN";
            this.PIN.Size = new System.Drawing.Size(58, 24);
            this.PIN.TabIndex = 6;
            this.PIN.Text = "0000";
            // 
            // CreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(500, 211);
            this.Controls.Add(this.PIN);
            this.Controls.Add(this.PINLabel);
            this.Controls.Add(this.CreditCardLabel);
            this.Controls.Add(this.IsAcceptableLabel);
            this.Controls.Add(this.CVVValue);
            this.Controls.Add(this.CVVLabel);
            this.Controls.Add(this.CreditCardNumber);
            this.Name = "CreditCard";
            this.Text = "CreditCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreditCardNumber;
        private System.Windows.Forms.Label CVVLabel;
        private System.Windows.Forms.Label CVVValue;
        private System.Windows.Forms.Label IsAcceptableLabel;
        private System.Windows.Forms.Label CreditCardLabel;
        private System.Windows.Forms.Label PINLabel;
        private System.Windows.Forms.Label PIN;
    }
}