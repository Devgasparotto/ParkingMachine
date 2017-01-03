namespace ParkingMachine
{
    partial class RefundAmount
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
            this.RefundAmountLabel = new System.Windows.Forms.Label();
            this.RefundButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.RefundAmountBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RefundAmountLabel
            // 
            this.RefundAmountLabel.AutoSize = true;
            this.RefundAmountLabel.Font = new System.Drawing.Font("Marlett", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefundAmountLabel.Location = new System.Drawing.Point(12, 48);
            this.RefundAmountLabel.Name = "RefundAmountLabel";
            this.RefundAmountLabel.Size = new System.Drawing.Size(339, 25);
            this.RefundAmountLabel.TabIndex = 0;
            this.RefundAmountLabel.Text = "Amount To Be Refunded in Coins:";
            // 
            // RefundButton
            // 
            this.RefundButton.BackColor = System.Drawing.Color.White;
            this.RefundButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RefundButton.FlatAppearance.BorderSize = 3;
            this.RefundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefundButton.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefundButton.Location = new System.Drawing.Point(70, 120);
            this.RefundButton.Name = "RefundButton";
            this.RefundButton.Size = new System.Drawing.Size(101, 45);
            this.RefundButton.TabIndex = 1;
            this.RefundButton.Text = "Refund";
            this.RefundButton.UseVisualStyleBackColor = false;
            this.RefundButton.Click += new System.EventHandler(this.RefundButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CancelButton.FlatAppearance.BorderSize = 3;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Marlett", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(228, 120);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(101, 45);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RefundAmountBox
            // 
            this.RefundAmountBox.AutoSize = true;
            this.RefundAmountBox.Font = new System.Drawing.Font("Marlett", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefundAmountBox.Location = new System.Drawing.Point(367, 48);
            this.RefundAmountBox.Name = "RefundAmountBox";
            this.RefundAmountBox.Size = new System.Drawing.Size(0, 25);
            this.RefundAmountBox.TabIndex = 3;
            // 
            // RefundAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(478, 457);
            this.Controls.Add(this.RefundAmountBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RefundButton);
            this.Controls.Add(this.RefundAmountLabel);
            this.Name = "RefundAmount";
            this.Text = "RefundAmount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RefundAmountLabel;
        private System.Windows.Forms.Button RefundButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label RefundAmountBox;
    }
}