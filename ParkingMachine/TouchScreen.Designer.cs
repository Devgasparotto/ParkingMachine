namespace ParkingMachine
{
    partial class TouchScreen
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
            this.CurrentScreenPanel = new System.Windows.Forms.Panel();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.CurrentRate = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentScreenPanel
            // 
            this.CurrentScreenPanel.AutoSize = true;
            this.CurrentScreenPanel.Location = new System.Drawing.Point(12, 70);
            this.CurrentScreenPanel.Name = "CurrentScreenPanel";
            this.CurrentScreenPanel.Size = new System.Drawing.Size(698, 516);
            this.CurrentScreenPanel.TabIndex = 0;
            this.CurrentScreenPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CurrentScreenPanel_Paint);
            // 
            // CurrentTime
            // 
            this.CurrentTime.AllowDrop = true;
            this.CurrentTime.AutoSize = true;
            this.CurrentTime.Font = new System.Drawing.Font("Marlett", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTime.Location = new System.Drawing.Point(12, 598);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(203, 33);
            this.CurrentTime.TabIndex = 1;
            this.CurrentTime.Text = "Time: 1:00 PM";
            this.CurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentRate
            // 
            this.CurrentRate.AllowDrop = true;
            this.CurrentRate.AutoSize = true;
            this.CurrentRate.Font = new System.Drawing.Font("Marlett", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentRate.Location = new System.Drawing.Point(515, 598);
            this.CurrentRate.Name = "CurrentRate";
            this.CurrentRate.Size = new System.Drawing.Size(195, 33);
            this.CurrentRate.TabIndex = 2;
            this.CurrentRate.Text = "Rate: $1/Hour";
            this.CurrentRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Marlett", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(147, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(84, 42);
            this.Title.TabIndex = 3;
            this.Title.Text = "Title";
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.White;
            this.HomeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HomeButton.FlatAppearance.BorderSize = 2;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Location = new System.Drawing.Point(12, 9);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(89, 42);
            this.HomeButton.TabIndex = 4;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // TouchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(722, 655);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CurrentRate);
            this.Controls.Add(this.CurrentTime);
            this.Controls.Add(this.CurrentScreenPanel);
            this.Name = "TouchScreen";
            this.Text = "TouchScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CurrentScreenPanel;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.Label CurrentRate;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button HomeButton;
    }
}