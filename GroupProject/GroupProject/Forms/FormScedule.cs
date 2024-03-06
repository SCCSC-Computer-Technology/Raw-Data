using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject.Forms
{
    public partial class FormScedule : Form
    {
        public FormScedule()
        {
            InitializeComponent();
            InitializeComboBox();
        }
        private void InitializeComboBox()
        {
            
            sportComboBox.Items.Add("WNBA");
            sportComboBox.Items.Add("NBA");
            sportComboBox.Items.Add("MLB");
            sportComboBox.SelectedIndex = 0; 
        }

        private void displayScheduleButton_Click(object sender, EventArgs e)
        {
            string selectedSport = sportComboBox.SelectedItem.ToString();
            DisplaySchedule(selectedSport);
        }

        private void DisplaySchedule(string sport)
        {
            string fileName = string.Empty;

            switch (sport)
            {
                case "WNBA":
                    fileName = "WNBA_Schedule.csv";
                    break;
                case "NBA":
                    fileName = "NBA_Schedule.csv";
                    break;
                case "MLB":
                    fileName = "MLB_Schedule.csv";
                    break;
            }

            // Constructs a file path relative to the executable's location
            string filePath = Path.Combine(Application.StartupPath, fileName);

            if (!File.Exists(filePath))
            {
                MessageBox.Show($"File not found: {filePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var scheduleLines = ReadSchedule(filePath);

            scheduleTextBox.Clear();
            foreach (var line in scheduleLines)
            {
                scheduleTextBox.AppendText(line + Environment.NewLine);
            }
        }



        private List<string> ReadSchedule(string filePath)
        {
            List<string> scheduleLines = new List<string>();

            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line) && !line.StartsWith("Date")) // Skip header line
                    {
                        scheduleLines.Add(line);
                    }
                }
            }

            return scheduleLines;
        }

        
    }
}
