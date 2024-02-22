namespace GroupProject.Forms
{
    partial class PlayerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.btnGeneratePDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Form";
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Location = new System.Drawing.Point(52, 118);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.Size = new System.Drawing.Size(705, 150);
            this.dgvPlayers.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Location = new System.Drawing.Point(122, 296);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 50);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(327, 296);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerName.TabIndex = 3;
            // 
            // btnGeneratePDF
            // 
            this.btnGeneratePDF.Location = new System.Drawing.Point(579, 310);
            this.btnGeneratePDF.Name = "btnGeneratePDF";
            this.btnGeneratePDF.Size = new System.Drawing.Size(75, 23);
            this.btnGeneratePDF.TabIndex = 4;
            this.btnGeneratePDF.Text = "Player Info";
            this.btnGeneratePDF.UseVisualStyleBackColor = true;
            this.btnGeneratePDF.Click += new System.EventHandler(this.btnGeneratePDF_Click);
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnGeneratePDF);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.label1);
            this.Name = "PlayerForm";
            this.Text = "your Player sucks";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Button btnGeneratePDF;
    }
}