using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using static GroupProject.SportsDbClient;

namespace GroupProject.Forms
{
    public partial class FormTeams : Form
    {
        // Make the DB object
        private readonly SportsDbClient _sportsDbClient = new SportsDbClient();


        public FormTeams()
        {
            InitializeComponent();
            InitializeDataGridView();
            this.Load += PlayerForm_Load;
        }

        private void btnCoolLook_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(25, 118, 210); // Darker shade when hovered
            btnGeneratePDF.BackColor = Color.FromArgb(25, 118, 210);
        }
        private void btnCoolLook_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.FromArgb(33, 150, 243); // Original color
            btnGeneratePDF.BackColor = Color.FromArgb(33, 150, 243);
        }
        private async void PlayerForm_Load(object sender, EventArgs e)
        {

            // Placeholder for future async operations
            await Task.Delay(1); // Not recommended for production code without a good reason
        }

        private void InitializeDataGridView()
        {
            dgvTeams.AutoGenerateColumns = false;

            // Create and add columns for each field you want to display
            AddColumn("strPlayer", "Name");
            AddColumn("strTeam", "Team");
            AddColumn("strSport", "Sport");
            AddColumn("strNationality", "Nationality");
            AddColumn("strBirthLocation", "Birth Location");
            AddColumn("strPosition", "Position");
            AddColumn("dateBorn", "Date of Birth");
            AddColumn("strSigning", "Signing");
            AddColumn("strWage", "Wage");
            AddColumn("strDescriptionEN", "Description");
            // Continue adding columns as needed
        }

        private void AddColumn(string dataPropertyName, string headerText)
        {
            dgvTeams.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = dataPropertyName,
                HeaderText = headerText,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void FormTeams_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportsDataDataSet.Baseball' table. You can move, or remove it, as needed.
            this.baseballTableAdapter.Fill(this.sportsDataDataSet.Baseball);

        }
    }
}
