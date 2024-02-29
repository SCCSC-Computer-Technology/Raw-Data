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
        private readonly SportsDbClient _sportsDbClient = new SportsDbClient(); // can this be removed it is not used?

        public SportsDataDataSet sd = new SportsDataDataSet();
        public string[] columnNames;
        public SearchLibrary searchLib = new SearchLibrary();
        public SortLibrary sortLib = new SortLibrary();
        public bool isAsc;

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
                    MakeSortComboBox("NBA");
                    break;
                case "WNBA":
                    LoadDataFromDataContext(new WNBADataClassesDataContext());
                    MakeSortComboBox("WNBA");
                    break;
                case "Baseball":
                    LoadDataFromDataContext(new BaseballDataClassesDataContext());
                    MakeSortComboBox("Baseball");
                    break;
            }
        }

        private void LoadDataFromDataContext<T>(T dataContext) where T : System.Data.Linq.DataContext
        {

            if (dataContext is NBADataClassesDataContext nbaContext)
            {
                var nbaData = nbaContext.NBAs.ToList();
                dataGridViewSports.DataSource = nbaData;
            }
            else if (dataContext is WNBADataClassesDataContext wnbaContext)
            {
                var wnbaData = wnbaContext.WNBAs.ToList(); // Adjust accordingly
                dataGridViewSports.DataSource = wnbaData;
            }
            else if (dataContext is BaseballDataClassesDataContext baseballContext)
            {
                var baseballData = baseballContext.Baseballs.ToList(); // Adjust accordingly
                dataGridViewSports.DataSource = baseballData;
            }

            // Adjust the DataGridView's columns or use AutoGenerateColumns=true based on your data structure
        }
        private void InitializeComboBox()
        {
            
            comboBoxSports.Items.Add("Baseball");
            comboBoxSports.Items.Add("NBA");
            comboBoxSports.Items.Add("WNBA");
            comboBoxSports.SelectedIndex = 0; // Select the first item by default
            comboBoxSports.SelectedIndexChanged += ComboBoxSports_SelectedIndexChanged;
        }

        public void MakeSortComboBox(string league)
        {
            switch (league)
            {
                case "NBA":
                    columnNames = (from s in sd.NBA.Columns.Cast<DataColumn>()
                                            select s.ColumnName).ToArray();
                    break;

                case "WNBA":
                    columnNames = (from s in sd.NBA.Columns.Cast<DataColumn>()
                                   select s.ColumnName).ToArray();
                    break;

                case "Baseball":
                    columnNames = (from s in sd.NBA.Columns.Cast<DataColumn>()
                                   select s.ColumnName).ToArray();
                    break;

                default:
                    MessageBox.Show("The sortComboBox did not populate correctly. Check the \"MakeSortComboBox\" method for errors.");
                    break;
            } // edn switch (league)

            sortComboBox.Items.Clear();
            sortComboBox.Items.AddRange(columnNames);
            sortComboBox.SelectedIndex = -1;
            
        } // end MakeSortComboBox()
        private async void PlayerForm_Load(object sender, EventArgs e)
        {

            // Placeholder for future async operations
            await Task.Delay(1); // Not recommended for production code without a good reason
        }

        public void sortButton_Click(object sender, EventArgs e)
        {
            if (ascRadioButton.Checked)
            {
                isAsc = true;
            }
            else
            {
                isAsc = false;
            }

            dataGridViewSports.DataSource = sortLib.HowToSort(comboBoxSports.SelectedItem.ToString(), sortComboBox.SelectedItem.ToString(), isAsc);

        }// end sortButton_Click()
    } // end FormTeams : Form
}
