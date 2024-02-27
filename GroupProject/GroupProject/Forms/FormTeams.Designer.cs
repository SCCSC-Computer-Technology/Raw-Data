namespace GroupProject.Forms
{
    partial class FormTeams
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTeams = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.btnGeneratePDF = new System.Windows.Forms.Button();
            this.sportsDataDataSet = new GroupProject.SportsDataDataSet();
            this.baseballBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseballTableAdapter = new GroupProject.SportsDataDataSetTableAdapters.BaseballTableAdapter();
            this.tableAdapterManager = new GroupProject.SportsDataDataSetTableAdapters.TableAdapterManager();
            this.playerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rBIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSMATimeStampDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseballBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Teams";
            // 
            // dgvTeams
            // 
            this.dgvTeams.AutoGenerateColumns = false;
            this.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerNameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.gPDataGridViewTextBoxColumn,
            this.aBDataGridViewTextBoxColumn,
            this.rDataGridViewTextBoxColumn,
            this.hDataGridViewTextBoxColumn,
            this.bDataGridViewTextBoxColumn,
            this.bDataGridViewTextBoxColumn1,
            this.hRDataGridViewTextBoxColumn,
            this.rBIDataGridViewTextBoxColumn,
            this.tBDataGridViewTextBoxColumn,
            this.bBDataGridViewTextBoxColumn,
            this.sODataGridViewTextBoxColumn,
            this.sBDataGridViewTextBoxColumn,
            this.aVGDataGridViewTextBoxColumn,
            this.oBPDataGridViewTextBoxColumn,
            this.sLGDataGridViewTextBoxColumn,
            this.oPSDataGridViewTextBoxColumn,
            this.wARDataGridViewTextBoxColumn,
            this.teamNameDataGridViewTextBoxColumn,
            this.sSMATimeStampDataGridViewImageColumn});
            this.dgvTeams.DataSource = this.baseballBindingSource;
            this.dgvTeams.Location = new System.Drawing.Point(-1, -1);
            this.dgvTeams.Name = "dgvTeams";
            this.dgvTeams.Size = new System.Drawing.Size(797, 266);
            this.dgvTeams.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Location = new System.Drawing.Point(57, 271);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(141, 50);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(262, 271);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(100, 20);
            this.txtTeamName.TabIndex = 5;
            // 
            // btnGeneratePDF
            // 
            this.btnGeneratePDF.Location = new System.Drawing.Point(487, 271);
            this.btnGeneratePDF.Name = "btnGeneratePDF";
            this.btnGeneratePDF.Size = new System.Drawing.Size(75, 23);
            this.btnGeneratePDF.TabIndex = 6;
            this.btnGeneratePDF.Text = "Team Info";
            this.btnGeneratePDF.UseVisualStyleBackColor = true;
            // 
            // sportsDataDataSet
            // 
            this.sportsDataDataSet.DataSetName = "SportsDataDataSet";
            this.sportsDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baseballBindingSource
            // 
            this.baseballBindingSource.DataMember = "Baseball";
            this.baseballBindingSource.DataSource = this.sportsDataDataSet;
            // 
            // baseballTableAdapter
            // 
            this.baseballTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BaseballTableAdapter = this.baseballTableAdapter;
            this.tableAdapterManager.NBATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GroupProject.SportsDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WNBATableAdapter = null;
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            this.playerNameDataGridViewTextBoxColumn.DataPropertyName = "Player Name";
            this.playerNameDataGridViewTextBoxColumn.HeaderText = "Player Name";
            this.playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // gPDataGridViewTextBoxColumn
            // 
            this.gPDataGridViewTextBoxColumn.DataPropertyName = "GP";
            this.gPDataGridViewTextBoxColumn.HeaderText = "GP";
            this.gPDataGridViewTextBoxColumn.Name = "gPDataGridViewTextBoxColumn";
            // 
            // aBDataGridViewTextBoxColumn
            // 
            this.aBDataGridViewTextBoxColumn.DataPropertyName = "AB";
            this.aBDataGridViewTextBoxColumn.HeaderText = "AB";
            this.aBDataGridViewTextBoxColumn.Name = "aBDataGridViewTextBoxColumn";
            // 
            // rDataGridViewTextBoxColumn
            // 
            this.rDataGridViewTextBoxColumn.DataPropertyName = "R";
            this.rDataGridViewTextBoxColumn.HeaderText = "R";
            this.rDataGridViewTextBoxColumn.Name = "rDataGridViewTextBoxColumn";
            // 
            // hDataGridViewTextBoxColumn
            // 
            this.hDataGridViewTextBoxColumn.DataPropertyName = "H";
            this.hDataGridViewTextBoxColumn.HeaderText = "H";
            this.hDataGridViewTextBoxColumn.Name = "hDataGridViewTextBoxColumn";
            // 
            // bDataGridViewTextBoxColumn
            // 
            this.bDataGridViewTextBoxColumn.DataPropertyName = "2B";
            this.bDataGridViewTextBoxColumn.HeaderText = "2B";
            this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
            // 
            // bDataGridViewTextBoxColumn1
            // 
            this.bDataGridViewTextBoxColumn1.DataPropertyName = "3B";
            this.bDataGridViewTextBoxColumn1.HeaderText = "3B";
            this.bDataGridViewTextBoxColumn1.Name = "bDataGridViewTextBoxColumn1";
            // 
            // hRDataGridViewTextBoxColumn
            // 
            this.hRDataGridViewTextBoxColumn.DataPropertyName = "HR";
            this.hRDataGridViewTextBoxColumn.HeaderText = "HR";
            this.hRDataGridViewTextBoxColumn.Name = "hRDataGridViewTextBoxColumn";
            // 
            // rBIDataGridViewTextBoxColumn
            // 
            this.rBIDataGridViewTextBoxColumn.DataPropertyName = "RBI";
            this.rBIDataGridViewTextBoxColumn.HeaderText = "RBI";
            this.rBIDataGridViewTextBoxColumn.Name = "rBIDataGridViewTextBoxColumn";
            // 
            // tBDataGridViewTextBoxColumn
            // 
            this.tBDataGridViewTextBoxColumn.DataPropertyName = "TB";
            this.tBDataGridViewTextBoxColumn.HeaderText = "TB";
            this.tBDataGridViewTextBoxColumn.Name = "tBDataGridViewTextBoxColumn";
            // 
            // bBDataGridViewTextBoxColumn
            // 
            this.bBDataGridViewTextBoxColumn.DataPropertyName = "BB";
            this.bBDataGridViewTextBoxColumn.HeaderText = "BB";
            this.bBDataGridViewTextBoxColumn.Name = "bBDataGridViewTextBoxColumn";
            // 
            // sODataGridViewTextBoxColumn
            // 
            this.sODataGridViewTextBoxColumn.DataPropertyName = "SO";
            this.sODataGridViewTextBoxColumn.HeaderText = "SO";
            this.sODataGridViewTextBoxColumn.Name = "sODataGridViewTextBoxColumn";
            // 
            // sBDataGridViewTextBoxColumn
            // 
            this.sBDataGridViewTextBoxColumn.DataPropertyName = "SB";
            this.sBDataGridViewTextBoxColumn.HeaderText = "SB";
            this.sBDataGridViewTextBoxColumn.Name = "sBDataGridViewTextBoxColumn";
            // 
            // aVGDataGridViewTextBoxColumn
            // 
            this.aVGDataGridViewTextBoxColumn.DataPropertyName = "AVG";
            this.aVGDataGridViewTextBoxColumn.HeaderText = "AVG";
            this.aVGDataGridViewTextBoxColumn.Name = "aVGDataGridViewTextBoxColumn";
            // 
            // oBPDataGridViewTextBoxColumn
            // 
            this.oBPDataGridViewTextBoxColumn.DataPropertyName = "OBP";
            this.oBPDataGridViewTextBoxColumn.HeaderText = "OBP";
            this.oBPDataGridViewTextBoxColumn.Name = "oBPDataGridViewTextBoxColumn";
            // 
            // sLGDataGridViewTextBoxColumn
            // 
            this.sLGDataGridViewTextBoxColumn.DataPropertyName = "SLG";
            this.sLGDataGridViewTextBoxColumn.HeaderText = "SLG";
            this.sLGDataGridViewTextBoxColumn.Name = "sLGDataGridViewTextBoxColumn";
            // 
            // oPSDataGridViewTextBoxColumn
            // 
            this.oPSDataGridViewTextBoxColumn.DataPropertyName = "OPS";
            this.oPSDataGridViewTextBoxColumn.HeaderText = "OPS";
            this.oPSDataGridViewTextBoxColumn.Name = "oPSDataGridViewTextBoxColumn";
            // 
            // wARDataGridViewTextBoxColumn
            // 
            this.wARDataGridViewTextBoxColumn.DataPropertyName = "WAR";
            this.wARDataGridViewTextBoxColumn.HeaderText = "WAR";
            this.wARDataGridViewTextBoxColumn.Name = "wARDataGridViewTextBoxColumn";
            // 
            // teamNameDataGridViewTextBoxColumn
            // 
            this.teamNameDataGridViewTextBoxColumn.DataPropertyName = "Team Name";
            this.teamNameDataGridViewTextBoxColumn.HeaderText = "Team Name";
            this.teamNameDataGridViewTextBoxColumn.Name = "teamNameDataGridViewTextBoxColumn";
            // 
            // sSMATimeStampDataGridViewImageColumn
            // 
            this.sSMATimeStampDataGridViewImageColumn.DataPropertyName = "SSMA_TimeStamp";
            this.sSMATimeStampDataGridViewImageColumn.HeaderText = "SSMA_TimeStamp";
            this.sSMATimeStampDataGridViewImageColumn.Name = "sSMATimeStampDataGridViewImageColumn";
            this.sSMATimeStampDataGridViewImageColumn.ReadOnly = true;
            // 
            // FormTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeneratePDF);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.dgvTeams);
            this.Controls.Add(this.label1);
            this.Name = "FormTeams";
            this.Text = "Team Form";
            this.Load += new System.EventHandler(this.FormTeams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseballBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTeams;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Button btnGeneratePDF;
        private SportsDataDataSet sportsDataDataSet;
        private System.Windows.Forms.BindingSource baseballBindingSource;
        private SportsDataDataSetTableAdapters.BaseballTableAdapter baseballTableAdapter;
        private SportsDataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rBIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn sSMATimeStampDataGridViewImageColumn;
    }
}