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
            dataGridViewSports.AutoGenerateColumns = true;
            InitializeComboBox(); 
            this.Load += PlayerForm_Load;
        }
        private async void ComboBoxSports_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedSport = comboBoxSports.SelectedItem.ToString();
            switch (selectedSport)
            {
                case "NBA":
                    LoadDataFromDataContext(new NBADataClassesDataContext());
                    break;
                case "WNBA":
                    LoadDataFromDataContext(new WNBADataClassesDataContext());
                    break;
                case "Baseball":
                    LoadDataFromDataContext(new BaseballDataClassesDataContext());
                    break;
            }
        }
        private void InitializeComboBox()
        {
            
            comboBoxSports.Items.Add("Baseball");
            comboBoxSports.Items.Add("NBA");
            comboBoxSports.Items.Add("WNBA");
            comboBoxSports.SelectedIndex = 0; // Select the first item by default
            comboBoxSports.SelectedIndexChanged += ComboBoxSports_SelectedIndexChanged;
        }
        private async void PlayerForm_Load(object sender, EventArgs e)
        {

            // Placeholder for future async operations
            await Task.Delay(1); // Not recommended for production code without a good reason
        }
    }
}
