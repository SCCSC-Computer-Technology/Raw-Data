namespace GroupProject
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnTeams = new System.Windows.Forms.Button();
            this.btnMatch = new System.Windows.Forms.Button();
            this.btnPlayers = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.homeLable = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.btnMinumize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnCustom);
            this.panelMenu.Controls.Add(this.btnSearch);
            this.panelMenu.Controls.Add(this.btnTeams);
            this.panelMenu.Controls.Add(this.btnMatch);
            this.panelMenu.Controls.Add(this.btnPlayers);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 610);
            this.panelMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(3, 407);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(220, 60);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "   Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.FlatAppearance.BorderSize = 0;
            this.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCustom.Image = ((System.Drawing.Image)(resources.GetObject("btnCustom.Image")));
            this.btnCustom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustom.Location = new System.Drawing.Point(3, 341);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCustom.Size = new System.Drawing.Size(220, 60);
            this.btnCustom.TabIndex = 5;
            this.btnCustom.Text = "   Play Games";
            this.btnCustom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(0, 275);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(220, 60);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "   Our Leader";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnTeams
            // 
            this.btnTeams.FlatAppearance.BorderSize = 0;
            this.btnTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeams.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTeams.Image = ((System.Drawing.Image)(resources.GetObject("btnTeams.Image")));
            this.btnTeams.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeams.Location = new System.Drawing.Point(0, 146);
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTeams.Size = new System.Drawing.Size(220, 60);
            this.btnTeams.TabIndex = 3;
            this.btnTeams.Text = "   Teams Stats";
            this.btnTeams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeams.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeams.UseVisualStyleBackColor = true;
            this.btnTeams.Click += new System.EventHandler(this.btnTeams_Click);
            // 
            // btnMatch
            // 
            this.btnMatch.FlatAppearance.BorderSize = 0;
            this.btnMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMatch.Image = ((System.Drawing.Image)(resources.GetObject("btnMatch.Image")));
            this.btnMatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatch.Location = new System.Drawing.Point(0, 212);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMatch.Size = new System.Drawing.Size(220, 60);
            this.btnMatch.TabIndex = 2;
            this.btnMatch.Text = "   Game Schedules";
            this.btnMatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // btnPlayers
            // 
            this.btnPlayers.FlatAppearance.BorderSize = 0;
            this.btnPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPlayers.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayers.Image")));
            this.btnPlayers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayers.Location = new System.Drawing.Point(0, 83);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPlayers.Size = new System.Drawing.Size(220, 57);
            this.btnPlayers.TabIndex = 1;
            this.btnPlayers.Text = "   Player Search";
            this.btnPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlayers.UseVisualStyleBackColor = true;
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.homeLable);
            this.panelLogo.Location = new System.Drawing.Point(0, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // homeLable
            // 
            this.homeLable.AutoSize = true;
            this.homeLable.Font = new System.Drawing.Font("AniMe Matrix - MB_EN", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homeLable.Location = new System.Drawing.Point(25, 22);
            this.homeLable.Name = "homeLable";
            this.homeLable.Size = new System.Drawing.Size(165, 25);
            this.homeLable.TabIndex = 0;
            this.homeLable.Text = "Raw Data";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnMinumize);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(872, 83);
            this.panelTitleBar.TabIndex = 1;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.BackgroundImage")));
            this.btnCloseChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Location = new System.Drawing.Point(7, 13);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 23);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(398, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 83);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(872, 527);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // btnMinumize
            // 
            this.btnMinumize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinumize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinumize.Image")));
            this.btnMinumize.Location = new System.Drawing.Point(724, 30);
            this.btnMinumize.Name = "btnMinumize";
            this.btnMinumize.Size = new System.Drawing.Size(22, 23);
            this.btnMinumize.TabIndex = 2;
            this.btnMinumize.UseVisualStyleBackColor = true;
            this.btnMinumize.Click += new System.EventHandler(this.bntMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(762, 30);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(27, 23);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1092, 610);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMainMenu";
            this.Text = "Group";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnPlayers;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnTeams;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label homeLable;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinumize;
    }
}

