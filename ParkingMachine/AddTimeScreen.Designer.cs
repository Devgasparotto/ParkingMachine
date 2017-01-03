namespace ParkingMachine
{
    partial class AddTimeScreen
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
            this.AddTimeButton = new System.Windows.Forms.Button();
            this.SubtractTimeButton = new System.Windows.Forms.Button();
            this.ValidTillLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.ValidDate = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.HoursDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddTimeButton
            // 
            this.AddTimeButton.BackColor = System.Drawing.Color.White;
            this.AddTimeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddTimeButton.FlatAppearance.BorderSize = 3;
            this.AddTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTimeButton.Font = new System.Drawing.Font("Marlett", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTimeButton.Location = new System.Drawing.Point(100, 244);
            this.AddTimeButton.Name = "AddTimeButton";
            this.AddTimeButton.Size = new System.Drawing.Size(198, 88);
            this.AddTimeButton.TabIndex = 0;
            this.AddTimeButton.Text = "Add 15 minutes";
            this.AddTimeButton.UseVisualStyleBackColor = false;
            this.AddTimeButton.Click += new System.EventHandler(this.AddTimeButton_Click);
            // 
            // SubtractTimeButton
            // 
            this.SubtractTimeButton.BackColor = System.Drawing.Color.White;
            this.SubtractTimeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SubtractTimeButton.FlatAppearance.BorderSize = 3;
            this.SubtractTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubtractTimeButton.Font = new System.Drawing.Font("Marlett", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractTimeButton.Location = new System.Drawing.Point(100, 352);
            this.SubtractTimeButton.Name = "SubtractTimeButton";
            this.SubtractTimeButton.Size = new System.Drawing.Size(198, 86);
            this.SubtractTimeButton.TabIndex = 1;
            this.SubtractTimeButton.Text = "Remove 15 minutes";
            this.SubtractTimeButton.UseVisualStyleBackColor = false;
            this.SubtractTimeButton.Click += new System.EventHandler(this.SubtractTimeButton_Click);
            // 
            // ValidTillLabel
            // 
            this.ValidTillLabel.AutoSize = true;
            this.ValidTillLabel.Font = new System.Drawing.Font("Marlett", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidTillLabel.Location = new System.Drawing.Point(320, 262);
            this.ValidTillLabel.Name = "ValidTillLabel";
            this.ValidTillLabel.Size = new System.Drawing.Size(133, 35);
            this.ValidTillLabel.TabIndex = 2;
            this.ValidTillLabel.Text = "Valid Till:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Marlett", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(369, 366);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(84, 35);
            this.CostLabel.TabIndex = 3;
            this.CostLabel.Text = "Cost:";
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cost.Location = new System.Drawing.Point(484, 368);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(71, 33);
            this.Cost.TabIndex = 4;
            this.Cost.Text = "0.00";
            // 
            // ValidDate
            // 
            this.ValidDate.AutoSize = true;
            this.ValidDate.Font = new System.Drawing.Font("Marlett", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidDate.Location = new System.Drawing.Point(484, 264);
            this.ValidDate.Name = "ValidDate";
            this.ValidDate.Size = new System.Drawing.Size(31, 33);
            this.ValidDate.TabIndex = 5;
            this.ValidDate.Text = "0";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.White;
            this.ConfirmButton.FlatAppearance.BorderSize = 3;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.Font = new System.Drawing.Font("Marlett", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(100, 103);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(198, 68);
            this.ConfirmButton.TabIndex = 6;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.White;
            this.ReturnButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ReturnButton.FlatAppearance.BorderSize = 3;
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Font = new System.Drawing.Font("Marlett", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(375, 103);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(198, 68);
            this.ReturnButton.TabIndex = 7;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Font = new System.Drawing.Font("Marlett", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursLabel.Location = new System.Drawing.Point(350, 315);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(103, 35);
            this.HoursLabel.TabIndex = 8;
            this.HoursLabel.Text = "Hours:";
            // 
            // HoursDisplay
            // 
            this.HoursDisplay.AutoSize = true;
            this.HoursDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursDisplay.Location = new System.Drawing.Point(484, 315);
            this.HoursDisplay.Name = "HoursDisplay";
            this.HoursDisplay.Size = new System.Drawing.Size(71, 33);
            this.HoursDisplay.TabIndex = 9;
            this.HoursDisplay.Text = "0.00";
            // 
            // AddTimeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(744, 635);
            this.Controls.Add(this.HoursDisplay);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.ValidDate);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ValidTillLabel);
            this.Controls.Add(this.SubtractTimeButton);
            this.Controls.Add(this.AddTimeButton);
            this.Name = "AddTimeScreen";
            this.Text = "AddTimeScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTimeButton;
        private System.Windows.Forms.Button SubtractTimeButton;
        private System.Windows.Forms.Label ValidTillLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label ValidDate;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.Label HoursDisplay;
    }
}