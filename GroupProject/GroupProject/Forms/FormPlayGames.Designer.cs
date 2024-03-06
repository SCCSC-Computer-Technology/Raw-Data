namespace GroupProject.Forms
{
    partial class FormPlayGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlayGames));
            this.soccerGame = new System.Windows.Forms.Button();
            this.baseballGame = new System.Windows.Forms.Button();
            this.basketBall = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.baseballGame.Location = new System.Drawing.Point(321, 373);
            this.baseballGame.Name = "baseballGame";
            this.baseballGame.Size = new System.Drawing.Size(75, 23);
            this.baseballGame.TabIndex = 1;
            this.baseballGame.Text = "Play Ball";
            this.baseballGame.UseVisualStyleBackColor = true;
            this.baseballGame.Click += new System.EventHandler(this.baseballGame_Click);
            // 
            // basketBall
            // 
            this.basketBall.Location = new System.Drawing.Point(642, 373);
            this.basketBall.Name = "basketBall";
            this.basketBall.Size = new System.Drawing.Size(75, 23);
            this.basketBall.TabIndex = 2;
            this.basketBall.Text = "Basket Ball";
            this.basketBall.UseVisualStyleBackColor = true;
            this.basketBall.Click += new System.EventHandler(this.basketBall_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(85, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 295);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormPlayGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.basketBall);
            this.Controls.Add(this.baseballGame);
            this.Controls.Add(this.soccerGame);
            this.Name = "FormPlayGames";
            this.Text = "Customize your teams";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button soccerGame;
        private System.Windows.Forms.Button baseballGame;
        private System.Windows.Forms.Button basketBall;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}