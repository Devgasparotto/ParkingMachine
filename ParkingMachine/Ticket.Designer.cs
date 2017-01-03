namespace ParkingMachine
{
    partial class Ticket
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
            this.TicketLabel = new System.Windows.Forms.Label();
            this.IssuedAtLabel = new System.Windows.Forms.Label();
            this.TicketIDLabel = new System.Windows.Forms.Label();
            this.ExpiresLabel = new System.Windows.Forms.Label();
            this.IssuedDate = new System.Windows.Forms.Label();
            this.TicketID = new System.Windows.Forms.Label();
            this.ExpiryDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TicketLabel
            // 
            this.TicketLabel.AutoSize = true;
            this.TicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketLabel.Location = new System.Drawing.Point(5, 9);
            this.TicketLabel.Name = "TicketLabel";
            this.TicketLabel.Size = new System.Drawing.Size(118, 42);
            this.TicketLabel.TabIndex = 0;
            this.TicketLabel.Text = "Ticket";
            // 
            // IssuedAtLabel
            // 
            this.IssuedAtLabel.AutoSize = true;
            this.IssuedAtLabel.Font = new System.Drawing.Font("Marlett", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssuedAtLabel.Location = new System.Drawing.Point(16, 78);
            this.IssuedAtLabel.Name = "IssuedAtLabel";
            this.IssuedAtLabel.Size = new System.Drawing.Size(118, 27);
            this.IssuedAtLabel.TabIndex = 1;
            this.IssuedAtLabel.Text = "Issued At:";
            // 
            // TicketIDLabel
            // 
            this.TicketIDLabel.AutoSize = true;
            this.TicketIDLabel.Font = new System.Drawing.Font("Marlett", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketIDLabel.Location = new System.Drawing.Point(16, 120);
            this.TicketIDLabel.Name = "TicketIDLabel";
            this.TicketIDLabel.Size = new System.Drawing.Size(111, 27);
            this.TicketIDLabel.TabIndex = 2;
            this.TicketIDLabel.Text = "Ticket ID:";
            // 
            // ExpiresLabel
            // 
            this.ExpiresLabel.AutoSize = true;
            this.ExpiresLabel.Font = new System.Drawing.Font("Marlett", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiresLabel.Location = new System.Drawing.Point(15, 171);
            this.ExpiresLabel.Name = "ExpiresLabel";
            this.ExpiresLabel.Size = new System.Drawing.Size(146, 33);
            this.ExpiresLabel.TabIndex = 5;
            this.ExpiresLabel.Text = "EXPIRES:";
            // 
            // IssuedDate
            // 
            this.IssuedDate.AutoSize = true;
            this.IssuedDate.Font = new System.Drawing.Font("Marlett", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssuedDate.Location = new System.Drawing.Point(211, 78);
            this.IssuedDate.Name = "IssuedDate";
            this.IssuedDate.Size = new System.Drawing.Size(25, 27);
            this.IssuedDate.TabIndex = 6;
            this.IssuedDate.Text = "0";
            // 
            // TicketID
            // 
            this.TicketID.AutoSize = true;
            this.TicketID.Font = new System.Drawing.Font("Marlett", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketID.Location = new System.Drawing.Point(211, 120);
            this.TicketID.Name = "TicketID";
            this.TicketID.Size = new System.Drawing.Size(25, 27);
            this.TicketID.TabIndex = 7;
            this.TicketID.Text = "0";
            // 
            // ExpiryDate
            // 
            this.ExpiryDate.AutoSize = true;
            this.ExpiryDate.Font = new System.Drawing.Font("Marlett", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryDate.Location = new System.Drawing.Point(210, 171);
            this.ExpiryDate.Name = "ExpiryDate";
            this.ExpiryDate.Size = new System.Drawing.Size(31, 33);
            this.ExpiryDate.TabIndex = 8;
            this.ExpiryDate.Text = "0";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(612, 261);
            this.Controls.Add(this.ExpiryDate);
            this.Controls.Add(this.TicketID);
            this.Controls.Add(this.IssuedDate);
            this.Controls.Add(this.ExpiresLabel);
            this.Controls.Add(this.TicketIDLabel);
            this.Controls.Add(this.IssuedAtLabel);
            this.Controls.Add(this.TicketLabel);
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TicketLabel;
        private System.Windows.Forms.Label IssuedAtLabel;
        private System.Windows.Forms.Label TicketIDLabel;
        private System.Windows.Forms.Label ExpiresLabel;
        private System.Windows.Forms.Label IssuedDate;
        private System.Windows.Forms.Label TicketID;
        private System.Windows.Forms.Label ExpiryDate;
    }
}