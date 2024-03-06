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
            ascRadioButton.Checked = true;
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
        public void MakeSortComboBox(string league) //and search
        {
            SDataSet sd = new SDataSet();
            switch (league)
            {
                case "Baseball":
                    columnNames = (from s in sd.Baseball.Columns.Cast<DataColumn>()
                                   select s.ColumnName).ToArray();
                    break;

                case "NBA":
                    columnNames = (from s in sd.NBA.Columns.Cast<DataColumn>()
                                   select s.ColumnName).ToArray();
                    break;

                case "WNBA":
                    columnNames = (from s in sd.WNBA.Columns.Cast<DataColumn>()
                                   select s.ColumnName).ToArray();
                    break;

                default:
                    MessageBox.Show("The sortComboBox did not populate correctly. Check the \"MakeSortComboBox\" method for errors.");
                    break;
            } // edn switch (league)

            sortComboBox.Items.Clear();
            sortComboBox.Items.AddRange(columnNames);
            sortComboBox.SelectedIndex = -1;

            searchComboBox.Items.Clear();
            searchComboBox.Items.AddRange(columnNames);
            searchComboBox.SelectedIndex = -1;

        } // end MakeSortComboBox()

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
            comboBoxSports.SelectedIndex = -1; // Select the first item by default
            comboBoxSports.SelectedIndexChanged += ComboBoxSports_SelectedIndexChanged;
        }

        private async void PlayerForm_Load(object sender, EventArgs e)
        {
            // Placeholder for future async operations
            await Task.Delay(1); // Not recommended for production code without a good reason
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (ascRadioButton.Checked)
            {
                isAsc = true;
            }
            else
            {
                isAsc = false;
            }
            try
            {
                dataGridViewSports.DataSource = sortLib.HowToSort(comboBoxSports.SelectedItem.ToString(), sortComboBox.SelectedItem.ToString(), isAsc);
            }
            catch
            {
                MessageBox.Show("Please make sure to pick a Sport from the \"Sport dropdown box\" then select a stat to sort by, before clicking the sort button.");
            }

        }// end sortButton_Click()

        private void searchButton_Click(object sender, EventArgs e)
        {
            {
                if (searchTextBox.Text.Length != 0 && minValTextBox.Text.Length != 0 && maxValTextBox.Text.Length != 0)
                {
                    MessageBox.Show("Please make sure to put data only in the min and max value boxes OR in the search containing box.");
                }
                else if (searchTextBox.Text.Length != 0 && minValTextBox.Text.Length == 0 && maxValTextBox.Text.Length == 0)
                {
                    try
                    {
                        dataGridViewSports.DataSource = searchLib.WhatToSearch("Baseball", searchComboBox.SelectedItem.ToString(), searchTextBox.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Please make sure to pick a Sport from the \"Sport dropdown box\" then select a stat to search for, before clicking the search button.");
                    }
                }
                else if (minValTextBox.Text.Length != 0 && maxValTextBox.Text.Length != 0 && searchTextBox.Text.Length == 0)
                {
                    try
                    {
                        dataGridViewSports.DataSource = searchLib.WhatToSearch("Baseball", searchComboBox.SelectedItem.ToString(), minValTextBox.Text, maxValTextBox.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Please make sure to pick a Sport from the \"Sport dropdown box\" then select a stat to search for, before clicking the search button.");
                    }
                }
                else
                {
                    MessageBox.Show("Please make sure to enter both a minimum and maximum value if searching for a numerical value or letters to search in the search box for a player name, team or position..");
                }
                
            } // end searchButton
        }

    }
}
