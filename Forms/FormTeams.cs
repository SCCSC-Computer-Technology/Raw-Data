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
        private void LoadBaseballData()
        {
            using (var context = new BaseballDataClassesDataContext())
            {
                
                var baseballData = context.Baseballs
                    .Select(player => new
                    {
                        player.Player_Name,
                        player.Position,
                        player.GP,
                        player.AB,
                        player.R,
                        player.H,
                        player._2B, 
                        player._3B, 
                        player.HR,
                        player.RBI,
                        player.TB,
                        player.BB,
                        player.SO,
                        player.SB,
                        player.AVG,  
                        player.OBP,
                        player.SLG,
                        player.OPS,
                        player.WAR,
                        player.Team_Name,
                        player.SSMA_TimeStamp 
                    })
                    .ToList();

                dataGridViewSports.DataSource = baseballData;
            }
        }
        private void LoadNbaData()
        {
            using (var context = new NBADataClassesDataContext())
            {
                var nbaData = context.NBAs
                    .Select(player => new
                    {
                        player.Player_Name,
                        player.Postion,
                        player.GP,
                        player.GS,
                        player.MIN,
                        player.PTS,
                        player.OR,
                        player.DR,
                        player.REB,
                        player.AST,
                        player.STL,
                        player.BLK,
                        player.TO,
                        player.PF,
                        player.AST_TO,
                        player.FGM,
                        player.FGA,
                        player.FG_,
                        player._3PM,
                        player._3PA,
                        player._3P_,
                        player.FTM,
                        player.FTA,
                        player.FT_,
                        player.Team_Name,
                        player.SSMA_TimeStamp 
                    })
                    .ToList();

                dataGridViewSports.DataSource = nbaData;
            }
        }

        private void LoadWnbaData()
        {
            using (var context = new WNBADataClassesDataContext())
            {
                var wnbaData = context.WNBAs
                    .Select(player => new
                    {
                        player.Player_Name,
                        player.Position,
                        player.GP,
                        player.GS,
                        player.MIN,
                        player.PTS,
                        player.OR,
                        player.DR,
                        player.REB,
                        player.AST,
                        player.STL,
                        player.BLK,
                        player.TO,
                        player.PF,
                        player.AST_TO,
                        player.FGM,
                        player.FGA,
                        player.FG_,
                        player._3PM,
                        player._3PA,
                        player._3P_,
                        player.FTM,
                        player.FTA,
                        player.FT_,
                        player.Team_Name,
                        player.SSMA_TimeStamp 
                    })
                    .ToList();

                dataGridViewSports.DataSource = wnbaData;
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




    }
}
