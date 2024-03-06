namespace GroupProject.Forms
{
    partial class FormScedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScedule));
            this.sportComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayScheduleButton = new System.Windows.Forms.Button();
            this.scheduleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sportComboBox
            // 
            this.sportComboBox.FormattingEnabled = true;
            this.sportComboBox.Location = new System.Drawing.Point(12, 12);
            this.sportComboBox.Name = "sportComboBox";
            this.sportComboBox.Size = new System.Drawing.Size(121, 21);
            this.sportComboBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(84)))), ((int)(((byte)(196)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 62);
            this.panel1.TabIndex = 2;
            // 
            // displayScheduleButton
            // 
            this.displayScheduleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(84)))), ((int)(((byte)(196)))));
            this.displayScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.displayScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayScheduleButton.ForeColor = System.Drawing.Color.White;
            this.displayScheduleButton.Image = ((System.Drawing.Image)(resources.GetObject("displayScheduleButton.Image")));
            this.displayScheduleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayScheduleButton.Location = new System.Drawing.Point(94, 388);
            this.displayScheduleButton.Name = "displayScheduleButton";
            this.displayScheduleButton.Size = new System.Drawing.Size(219, 62);
            this.displayScheduleButton.TabIndex = 0;
            this.displayScheduleButton.Text = "Display Schedule";
            this.displayScheduleButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.displayScheduleButton.UseVisualStyleBackColor = false;
            this.displayScheduleButton.Click += new System.EventHandler(this.displayScheduleButton_Click);
            // 
            // scheduleTextBox
            // 
            this.scheduleTextBox.Location = new System.Drawing.Point(94, 63);
            this.scheduleTextBox.Multiline = true;
            this.scheduleTextBox.Name = "scheduleTextBox";
            this.scheduleTextBox.Size = new System.Drawing.Size(604, 292);
            this.scheduleTextBox.TabIndex = 4;
            // 
            // FormMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scheduleTextBox);
            this.Controls.Add(this.displayScheduleButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sportComboBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormMatch";
            this.Text = "Match Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox sportComboBox;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button displayScheduleButton;
      
        private System.Windows.Forms.TextBox scheduleTextBox;
    }
}