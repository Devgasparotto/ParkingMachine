namespace ParkingMachine
{
    partial class MainScreen
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
            this.BuyTicketButton = new System.Windows.Forms.Button();
            this.RefundTicketButton = new System.Windows.Forms.Button();
            this.AddTimeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BuyTicketButton
            // 
            this.BuyTicketButton.BackColor = System.Drawing.Color.White;
            this.BuyTicketButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BuyTicketButton.FlatAppearance.BorderSize = 3;
            this.BuyTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyTicketButton.Font = new System.Drawing.Font("Marlett", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyTicketButton.Location = new System.Drawing.Point(185, 88);
            this.BuyTicketButton.Name = "BuyTicketButton";
            this.BuyTicketButton.Size = new System.Drawing.Size(317, 119);
            this.BuyTicketButton.TabIndex = 0;
            this.BuyTicketButton.Text = "Buy Ticket";
            this.BuyTicketButton.UseVisualStyleBackColor = false;
            this.BuyTicketButton.Click += new System.EventHandler(this.BuyTicketButton_Click);
            // 
            // RefundTicketButton
            // 
            this.RefundTicketButton.BackColor = System.Drawing.Color.White;
            this.RefundTicketButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RefundTicketButton.FlatAppearance.BorderSize = 3;
            this.RefundTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefundTicketButton.Font = new System.Drawing.Font("Marlett", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefundTicketButton.Location = new System.Drawing.Point(185, 245);
            this.RefundTicketButton.Name = "RefundTicketButton";
            this.RefundTicketButton.Size = new System.Drawing.Size(317, 113);
            this.RefundTicketButton.TabIndex = 1;
            this.RefundTicketButton.Text = "Refund Ticket";
            this.RefundTicketButton.UseVisualStyleBackColor = false;
            this.RefundTicketButton.Click += new System.EventHandler(this.RefundTicketButton_Click);
            // 
            // AddTimeButton
            // 
            this.AddTimeButton.BackColor = System.Drawing.Color.White;
            this.AddTimeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddTimeButton.FlatAppearance.BorderSize = 3;
            this.AddTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTimeButton.Font = new System.Drawing.Font("Marlett", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTimeButton.Location = new System.Drawing.Point(185, 399);
            this.AddTimeButton.Name = "AddTimeButton";
            this.AddTimeButton.Size = new System.Drawing.Size(317, 111);
            this.AddTimeButton.TabIndex = 2;
            this.AddTimeButton.Text = "Add Time to Ticket";
            this.AddTimeButton.UseVisualStyleBackColor = false;
            this.AddTimeButton.Click += new System.EventHandler(this.AddTimeButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(744, 635);
            this.Controls.Add(this.AddTimeButton);
            this.Controls.Add(this.RefundTicketButton);
            this.Controls.Add(this.BuyTicketButton);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BuyTicketButton;
        private System.Windows.Forms.Button RefundTicketButton;
        private System.Windows.Forms.Button AddTimeButton;
    }
}