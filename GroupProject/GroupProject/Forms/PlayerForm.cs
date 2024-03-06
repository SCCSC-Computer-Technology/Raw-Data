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


    public partial class PlayerForm : Form
    {
        private readonly SportsDbClient _sportsDbClient = new SportsDbClient();
        

        public PlayerForm()
        {
            InitializeComponent();
            InitializeDataGridView();
            this.Load += PlayerForm_Load;
        }
        public void UpdateThemeColors(Color primaryColor, Color secondaryColor)
        {
            
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
            dgvPlayers.AutoGenerateColumns = false;

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
            dgvPlayers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = dataPropertyName,
                HeaderText = headerText,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }
        private void GeneratePlayerPDF(Player player)
        {
            Document document = new Document();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\PlayerDetails.pdf";
            PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
            document.Open();

            document.Add(new Paragraph("Player Details"));
            document.Add(new Paragraph($"Name: {player.strPlayer}"));
            document.Add(new Paragraph($"Team: {player.strTeam}"));
            document.Add(new Paragraph($"Position: {player.strPosition}"));
            
            document.Add(new Paragraph($"Description: {player.strDescriptionEN}"));

            document.Close();
            try
            {
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to open the PDF: {ex.Message}");
            }
        }

       



        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text.Trim(); 
            if (!string.IsNullOrEmpty(playerName))
            {
                try
                {
                    var players = await _sportsDbClient.SearchPlayersByNameAsync(playerName);
                    dgvPlayers.DataSource = players;
                    if (players == null || !players.Any())
                    {
                        MessageBox.Show("No players found. Try a different name.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a player name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            if (dgvPlayers.CurrentRow != null)
            {
                Player player = dgvPlayers.CurrentRow.DataBoundItem as Player;
                if (player != null)
                {
                    GeneratePlayerPDF(player);
                }
                else
                {
                    MessageBox.Show("Please select a player.");
                }
            }
        }


    }
}
