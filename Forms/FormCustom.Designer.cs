namespace GroupProject.Forms
{
    partial class FormCustom
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
            this.soccerGame = new System.Windows.Forms.Button();
            this.baseballGame = new System.Windows.Forms.Button();
            this.basketBall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // soccerGame
            // 
            this.soccerGame.Location = new System.Drawing.Point(54, 373);
            this.soccerGame.Name = "soccerGame";
            this.soccerGame.Size = new System.Drawing.Size(75, 23);
            this.soccerGame.TabIndex = 0;
            this.soccerGame.Text = "Play Soccer";
            this.soccerGame.UseVisualStyleBackColor = true;
            this.soccerGame.Click += new System.EventHandler(this.soccerGame_Click);
            // 
            // baseballGame
            // 
            this.baseballGame.Location = new System.Drawing.Point(218, 373);
            this.baseballGame.Name = "baseballGame";
            this.baseballGame.Size = new System.Drawing.Size(75, 23);
            this.baseballGame.TabIndex = 1;
            this.baseballGame.Text = "Play Ball";
            this.baseballGame.UseVisualStyleBackColor = true;
            this.baseballGame.Click += new System.EventHandler(this.baseballGame_Click);
            // 
            // basketBall
            // 
            this.basketBall.Location = new System.Drawing.Point(431, 373);
            this.basketBall.Name = "basketBall";
            this.basketBall.Size = new System.Drawing.Size(75, 23);
            this.basketBall.TabIndex = 2;
            this.basketBall.Text = "Basket Ball";
            this.basketBall.UseVisualStyleBackColor = true;
            this.basketBall.Click += new System.EventHandler(this.basketBall_Click);
            // 
            // FormCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.basketBall);
            this.Controls.Add(this.baseballGame);
            this.Controls.Add(this.soccerGame);
            this.Name = "FormCustom";
            this.Text = "Customize your teams";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button soccerGame;
        private System.Windows.Forms.Button baseballGame;
        private System.Windows.Forms.Button basketBall;
    }
}