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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static iTextSharp.awt.geom.Point2D;

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
            
        }
        private void btnCoolLook_MouseLeave(object sender, EventArgs e)
        {
            
        }
        private async void PlayerForm_Load(object sender, EventArgs e)
        {

            // Placeholder for future async operations
            await Task.Delay(1); // Not recommended for production code without a good reason
        }

        private void SearchBaseballData()
        {
            using (var context = new BaseballDataClassesDataContext())
            {
                var playerName = textBoxPlayerName.Text;
                var position = textBoxPosition.Text;
                var gamesPlayedText = textBoxgamesplayed.Text;
                var atBatsText = textBoxatbats.Text;
                var runText = textBoxruns.Text;
                var hitsText = textBoxhits.Text;
                var doublesText = textBoxdoubles.Text;
                var triplesText = textBoxtriples.Text;
                var homeRunsText = textBoxhomeruns.Text;
                var rbisText = textBoxrbis.Text;
                var totalBasesText = textBoxtotalbases.Text;
                var walksText = textBoxwalks.Text;
                var strikeoutsText = textBoxstrikeouts.Text;
                var stolenBasesText = textBoxstolenbases.Text;
                var battingAverageText = textBoxbattingaverage.Text;
                var obpText = textBoxobp.Text;
                var slgText = textBoxslg.Text;
                var opsText = textBoxops.Text;
                var warText = textBoxwar.Text;
                var teamName = textBoxteamname.Text;

                int? gamesPlayed = null;
                int? atBats = null;
                int? run = null;
                int? hits = null;
                int? doubles = null;
                int? triples = null;
                int? homeRuns = null;
                int? rbis = null;
                int? totalBases = null;
                int? walks = null;
                int? strikeouts = null;
                int? stolenBases = null;
                double? battingAverage = null;
                double? obp = null;
                double? slg = null;
                double? ops = null;
                double? war = null;

                if (!string.IsNullOrWhiteSpace(gamesPlayedText))
                {
                    int parsedGamesPlayed;
                    if (int.TryParse(gamesPlayedText, out parsedGamesPlayed))
                    {
                        gamesPlayed = parsedGamesPlayed;
                    }
                }
                if (!string.IsNullOrWhiteSpace(atBatsText))
                {
                    int parsedAtBats;
                    if (int.TryParse(atBatsText, out parsedAtBats))
                    {
                        atBats = parsedAtBats;
                    }
                }
                if (!string.IsNullOrWhiteSpace(runText))
                {
                    int parsedRun;
                    if (int.TryParse(runText, out parsedRun))
                    {
                        run = parsedRun;
                    }
                }
                if (!string.IsNullOrWhiteSpace(hitsText))
                {
                    int parsedHits;
                    if (int.TryParse(hitsText, out parsedHits))
                    {
                        hits = parsedHits;
                    }
                }
                if (!string.IsNullOrWhiteSpace(doublesText))
                {
                    int parsedDoubles;
                    if (int.TryParse(doublesText, out parsedDoubles))
                    {
                        doubles = parsedDoubles;
                    }
                }
                if (!string.IsNullOrWhiteSpace(triplesText))
                {
                    int parsedTriples;
                    if (int.TryParse(triplesText, out parsedTriples))
                    {
                        triples = parsedTriples;
                    }
                }
                if (!string.IsNullOrWhiteSpace(homeRunsText))
                {
                    int parsedHomeRuns;
                    if (int.TryParse(homeRunsText, out parsedHomeRuns))
                    {
                        homeRuns = parsedHomeRuns;
                    }
                }
                if (!string.IsNullOrWhiteSpace(rbisText))
                {
                    int parsedRbis;
                    if (int.TryParse(rbisText, out parsedRbis))
                    {
                        rbis = parsedRbis;
                    }
                }
                if (!string.IsNullOrWhiteSpace(totalBasesText))
                {
                    int parsedTotalBases;
                    if (int.TryParse(totalBasesText, out parsedTotalBases))
                    {
                        totalBases = parsedTotalBases;
                    }
                }
                if (!string.IsNullOrWhiteSpace(walksText))
                {
                    int parsedWalks;
                    if (int.TryParse(walksText, out parsedWalks))
                    {
                        walks = parsedWalks;
                    }
                }
                if (!string.IsNullOrWhiteSpace(strikeoutsText))
                {
                    int parsedStrikeouts;
                    if (int.TryParse(strikeoutsText, out parsedStrikeouts))
                    {
                        strikeouts = parsedStrikeouts;
                    }
                }
                if (!string.IsNullOrWhiteSpace(stolenBasesText))
                {
                    int parsedStolenBases;
                    if (int.TryParse(stolenBasesText, out parsedStolenBases))
                    {
                        stolenBases = parsedStolenBases;
                    }
                }
                

                if (!string.IsNullOrWhiteSpace(battingAverageText))
                {
                    double parsedBattingAverage;
                    if (double.TryParse(battingAverageText, out parsedBattingAverage))
                    {
                        battingAverage = parsedBattingAverage;
                    }
                }
                if (!string.IsNullOrWhiteSpace(obpText))
                {
                    double parsedObp;
                    if (double.TryParse(obpText, out parsedObp))
                    {
                        obp = parsedObp;
                    }
                }
                if (!string.IsNullOrWhiteSpace(slgText))
                {
                    double parsedSlg;
                    if (double.TryParse(slgText, out parsedSlg))
                    {
                        slg = parsedSlg;
                    }
                }
                if (!string.IsNullOrWhiteSpace(opsText))
                {
                    double parsedOps;
                    if (double.TryParse(opsText, out parsedOps))
                    {
                        ops = parsedOps;
                    }
                }
                if (!string.IsNullOrWhiteSpace(warText))
                {
                    double parsedWar;
                    if (double.TryParse(warText, out parsedWar))
                    {
                        war = parsedWar;
                    }
                }
                // Repeat for other double TextBoxes

                var baseballData = context.Baseballs
                    .Where(player =>
                        (string.IsNullOrEmpty(playerName) || player.Player_Name.Contains(playerName)) &&
                        (string.IsNullOrEmpty(position) || player.Position.Contains(position)) &&
                        (!gamesPlayed.HasValue || player.GP == gamesPlayed.Value) &&
                        (!atBats.HasValue || player.AB == atBats.Value) &&
                        (!run.HasValue || player.R == run.Value) &&
                        (!hits.HasValue || player.H == hits.Value) &&
                        (!doubles.HasValue || player._2B == doubles.Value) &&
                        (!triples.HasValue || player._3B == triples.Value) &&
                        (!homeRuns.HasValue || player.HR == homeRuns.Value) &&
                        (!rbis.HasValue || player.RBI == rbis.Value) &&
                        (!totalBases.HasValue || player.TB == totalBases.Value) &&
                        (!walks.HasValue || player.BB == walks.Value) &&
                        (!strikeouts.HasValue || player.SO == strikeouts.Value) &&
                        (!stolenBases.HasValue || player.SB == stolenBases.Value) &&
                        (!battingAverage.HasValue || player.AVG == battingAverage.Value) &&
                        (!obp.HasValue || player.OBP == obp.Value) &&
                        (!slg.HasValue || player.SLG == slg.Value) &&
                        (!ops.HasValue || player.OPS == ops.Value) &&
                        (!war.HasValue || player.WAR == war.Value) &&
                        (string.IsNullOrEmpty(teamName) || player.Team_Name.Contains(teamName))
                        )
                    
                    
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
        private void SearchWnbaData()
        {
            using (var context = new WNBADataClassesDataContext())
            {
                var playerName = textBoxPlayerName.Text;
                var position = textBoxPosition.Text;
                var gamesPlayedText = textBoxgamesplayed.Text;
                var gamesStartedText = textBoxGamesStarted.Text;
                var minutesText = textBoxMinutes.Text;
                var pointsText = textBoxPoints.Text;
                var offensiveReboundsText = textBoxOffensiveRebounds.Text;
                var defensiveReboundsText = textBoxDefensiveRebounds.Text;
                var totalReboundsText = textBoxTotalRebounds.Text;
                var assistsText = textBoxAssists.Text;
                var stealsText = textBoxSteals.Text;
                var blocksText = textBoxBlocks.Text;
                var turnoversText = textBoxTurnovers.Text;
                var pfText = textBoxPF.Text;
                var astToText = textBoxAstTo.Text;
                var fgmText = textBoxFgm.Text;
                var fgaText = textBoxFga.Text;
                var fg_Text = textBoxFg_.Text;
                var _3pmText = textBox_3pm.Text;
                var _3paText = textBox_3pa.Text;
                var _3p_Text = textBox_3p_.Text;
                var ftmText = textBoxFtm.Text;
                var ftaText = textBoxFta.Text;
                var ft_Text = textBoxFt_.Text;
                var teamName = textBoxteamname.Text;

                int? gamesPlayed = null;
                int? gamesStarted = null;
                int? minutes = null;
                int? points = null;
                int? offensiveRebounds = null;
                int? defensiveRebounds = null;
                int? totalRebounds = null;
                int? assists = null;
                int? steals = null;
                int? blocks = null;
                int? turnovers = null;
                int? pf = null;
                double? astTo = null;
                double? fgm = null;
                double? fga = null;
                double? fg_ = null;
                double? _3pm = null;
                double? _3pa = null;
                double? _3p_ = null;
                double? ftm = null;
                double? fta = null;
                double? ft_ = null;

                if (!string.IsNullOrWhiteSpace(gamesPlayedText))
                {
                    int parsedGamesPlayed;
                    if (int.TryParse(gamesPlayedText, out parsedGamesPlayed))
                    {
                        gamesPlayed = parsedGamesPlayed;
                    }
                }
                if (!string.IsNullOrWhiteSpace(gamesStartedText))
                {
                    int parsedGamesStarted;
                    if (int.TryParse(gamesStartedText, out parsedGamesStarted))
                    {
                        gamesStarted = parsedGamesStarted;
                    }
                }
                if (!string.IsNullOrWhiteSpace(minutesText))
                {
                    int parsedMinutes;
                    if (int.TryParse(minutesText, out parsedMinutes))
                    {
                        minutes = parsedMinutes;
                    }
                }
                if (!string.IsNullOrWhiteSpace(pointsText))
                {
                    int parsedPoints;
                    if (int.TryParse(pointsText, out parsedPoints))
                    {
                        points = parsedPoints;
                    }
                }
                if (!string.IsNullOrWhiteSpace(offensiveReboundsText))
                {
                    int parsedOffensiveRebounds;
                    if (int.TryParse(offensiveReboundsText, out parsedOffensiveRebounds))
                    {
                        offensiveRebounds = parsedOffensiveRebounds;
                    }
                }
                if (!string.IsNullOrWhiteSpace(defensiveReboundsText))
                {
                    int parsedDefensiveRebounds;
                    if (int.TryParse(defensiveReboundsText, out parsedDefensiveRebounds))
                    {
                        defensiveRebounds = parsedDefensiveRebounds;
                    }
                }
                if (!string.IsNullOrWhiteSpace(totalReboundsText))
                {
                    int parsedTotalRebounds;
                    if (int.TryParse(totalReboundsText, out parsedTotalRebounds))
                    {
                        totalRebounds = parsedTotalRebounds;
                    }
                }
                if (!string.IsNullOrWhiteSpace(assistsText))
                {
                    int parsedAssists;
                    if (int.TryParse(assistsText, out parsedAssists))
                    {
                        assists = parsedAssists;
                    }
                }
                if (!string.IsNullOrWhiteSpace(stealsText))
                {
                    int parsedSteals;
                    if (int.TryParse(stealsText, out parsedSteals))
                    {
                        steals = parsedSteals;
                    }
                }
                if (!string.IsNullOrWhiteSpace(blocksText))
                {
                    int parsedBlocks;
                    if (int.TryParse(blocksText, out parsedBlocks))
                    {
                        blocks = parsedBlocks;
                    }
                }
                if (!string.IsNullOrWhiteSpace(turnoversText))
                {
                    int parsedTurnovers;
                    if (int.TryParse(turnoversText, out parsedTurnovers))
                    {
                        turnovers = parsedTurnovers;
                    }
                }
                if (!string.IsNullOrWhiteSpace(pfText))
                {
                    int parsedPf;
                    if (int.TryParse(pfText, out parsedPf))
                    {
                        pf = parsedPf;
                    }
                }
                if (!string.IsNullOrWhiteSpace(astToText))
                {
                    double parsedAstTo;
                    if (double.TryParse(astToText, out parsedAstTo))
                    {
                        astTo = parsedAstTo;
                    }
                }
                if (!string.IsNullOrWhiteSpace(fgmText))
                {
                    double parsedFgm;
                    if (double.TryParse(fgmText, out parsedFgm))
                    {
                        fgm = parsedFgm;
                    }
                }
                if (!string.IsNullOrWhiteSpace(fgaText))
                {
                    double parsedFga;
                    if (double.TryParse(fgaText, out parsedFga))
                    {
                        fga = parsedFga;
                    }
                }
                if (!string.IsNullOrWhiteSpace(fg_Text))
                {
                    double parsedFgPercent;
                    if (double.TryParse(fg_Text, out parsedFgPercent))
                    {
                        fg_ = parsedFgPercent;
                    }
                }
                if (!string.IsNullOrWhiteSpace(_3pmText))
                {
                    double parsed3pm;
                    if (double.TryParse(_3pmText, out parsed3pm))
                    {
                        _3pm = parsed3pm;
                    }
                }
                if (!string.IsNullOrWhiteSpace(_3paText))
                {
                    double parsed3pa;
                    if (double.TryParse(_3paText, out parsed3pa))
                    {
                        _3pa = parsed3pa;
                    }
                }
                if (!string.IsNullOrWhiteSpace(_3p_Text))
                {
                    double parsed3pPercent;
                    if (double.TryParse(_3p_Text, out parsed3pPercent))
                    {
                        _3p_ = parsed3pPercent;
                    }
                }
                if (!string.IsNullOrWhiteSpace(ftmText))
                {
                    double parsedFtm;
                    if (double.TryParse(ftmText, out parsedFtm))
                    {
                        ftm = parsedFtm;
                    }
                }
                if (!string.IsNullOrWhiteSpace(ftaText))
                {
                    double parsedFta;
                    if (double.TryParse(ftaText, out parsedFta))
                    {
                        fta = parsedFta;
                    }
                }
                if (!string.IsNullOrWhiteSpace(ft_Text))
                {
                    double parsedFtPercent;
                    if (double.TryParse(ft_Text, out parsedFtPercent))
                    {
                        ft_ = parsedFtPercent;
                    }
                }


                var wnbaData = context.WNBAs
                    .Where(player =>
                        (string.IsNullOrEmpty(playerName) || player.Player_Name.Contains(playerName)) &&
                        (string.IsNullOrEmpty(position) || player.Position.Contains(position)) &&
                        (!gamesPlayed.HasValue || player.GP == gamesPlayed.Value) &&
                        (!gamesStarted.HasValue || player.GS == gamesStarted.Value) &&
                        (!minutes.HasValue || player.MIN == minutes.Value) &&
                        (!points.HasValue || player.PTS == points.Value) &&
                        (!offensiveRebounds.HasValue || player.OR == offensiveRebounds.Value) &&
                        (!defensiveRebounds.HasValue || player.DR == defensiveRebounds.Value) &&
                        (!totalRebounds.HasValue || player.REB == totalRebounds.Value) &&
                        (!assists.HasValue || player.AST == assists.Value) &&
                        (!steals.HasValue || player.STL == steals.Value) &&
                        (!blocks.HasValue || player.BLK == blocks.Value) &&
                        (!turnovers.HasValue || player.TO == turnovers.Value) &&
                        (!pf.HasValue || player.PF == pf.Value) &&
                        (!astTo.HasValue || player.AST_TO == astTo.Value) &&
                        (!fgm.HasValue || player.FGM == fgm.Value) &&
                        (!fga.HasValue || player.FGA == fga.Value) &&
                        (!fg_.HasValue || player.FG_ == fg_.Value) &&
                        (!_3pm.HasValue || player._3PM == _3pm.Value) &&
                        (!_3pa.HasValue || player._3PA == _3pa.Value) &&
                        (!_3p_.HasValue || player._3P_ == _3p_.Value) &&
                        (!ftm.HasValue || player.FTM == ftm.Value) &&
                        (!fta.HasValue || player.FTA == fta.Value) &&
                        (!ft_.HasValue || player.FT_ == ft_.Value) &&
                        (string.IsNullOrEmpty(teamName) || player.Team_Name.Contains(teamName))
                    )
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
        private void SearchNbaData()
        {
            using (var context = new NBADataClassesDataContext())
            {
                var playerName = textBoxPlayerName.Text;
                var position = textBoxPosition.Text;
                var gamesPlayedText = textBoxgamesplayed.Text;
                var gamesStartedText = textBoxGamesStarted.Text;
                var minutesText = textBoxMinutes.Text;
                var pointsText = textBoxPoints.Text;
                var offensiveReboundsText = textBoxOffensiveRebounds.Text;
                var defensiveReboundsText = textBoxDefensiveRebounds.Text;
                var totalReboundsText = textBoxTotalRebounds.Text;
                var assistsText = textBoxAssists.Text;
                var stealsText = textBoxSteals.Text;
                var blocksText = textBoxBlocks.Text;
                var turnoversText = textBoxTurnovers.Text;
                var pfText = textBoxPF.Text;
                var astToText = textBoxAstTo.Text;
                var fgmText = textBoxFgm.Text;
                var fgaText = textBoxFga.Text;
                var fg_Text = textBoxFg_.Text;
                var _3pmText = textBox_3pm.Text;
                var _3paText = textBox_3pa.Text;
                var _3p_Text = textBox_3p_.Text;
                var ftmText = textBoxFtm.Text;
                var ftaText = textBoxFta.Text;
                var ft_Text = textBoxFt_.Text;
                var teamName = textBoxteamname.Text;

                int? gamesPlayed = null;
                int? gamesStarted = null;
                int? minutes = null;
                int? points = null;
                int? offensiveRebounds = null;
                int? defensiveRebounds = null;
                int? totalRebounds = null;
                int? assists = null;
                int? steals = null;
                int? blocks = null;
                int? turnovers = null;
                int? pf = null;
                double? astTo = null;
                double? fgm = null;
                double? fga = null;
                double? fg_ = null;
                double? _3pm = null;
                double? _3pa = null;
                double? _3p_ = null;
                double? ftm = null;
                double? fta = null;
                double? ft_ = null;

                if (!string.IsNullOrWhiteSpace(gamesPlayedText))
                {
                    int parsedGamesPlayed;
                    if (int.TryParse(gamesPlayedText, out parsedGamesPlayed))
                    {
                        gamesPlayed = parsedGamesPlayed;
                    }
                }
                if (!string.IsNullOrWhiteSpace(gamesStartedText))
                {
                    int parsedGamesStarted;
                    if (int.TryParse(gamesStartedText, out parsedGamesStarted))
                    {
                        gamesStarted = parsedGamesStarted;
                    }
                }
                if (!string.IsNullOrWhiteSpace(minutesText))
                {
                    int parsedMinutes;
                    if (int.TryParse(minutesText, out parsedMinutes))
                    {
                        minutes = parsedMinutes;
                    }
                }
                if (!string.IsNullOrWhiteSpace(pointsText))
                {
                    int parsedPoints;
                    if (int.TryParse(pointsText, out parsedPoints))
                    {
                        points = parsedPoints;
                    }
                }
                if (!string.IsNullOrWhiteSpace(offensiveReboundsText))
                {
                    int parsedOffensiveRebounds;
                    if (int.TryParse(offensiveReboundsText, out parsedOffensiveRebounds))
                    {
                        offensiveRebounds = parsedOffensiveRebounds;
                    }
                }
                if (!string.IsNullOrWhiteSpace(defensiveReboundsText))
                {
                    int parsedDefensiveRebounds;
                    if (int.TryParse(defensiveReboundsText, out parsedDefensiveRebounds))
                    {
                        defensiveRebounds = parsedDefensiveRebounds;
                    }
                }
                if (!string.IsNullOrWhiteSpace(totalReboundsText))
                {
                    int parsedTotalRebounds;
                    if (int.TryParse(totalReboundsText, out parsedTotalRebounds))
                    {
                        totalRebounds = parsedTotalRebounds;
                    }
                }
                if (!string.IsNullOrWhiteSpace(assistsText))
                {
                    int parsedAssists;
                    if (int.TryParse(assistsText, out parsedAssists))
                    {
                        assists = parsedAssists;
                    }
                }
                if (!string.IsNullOrWhiteSpace(stealsText))
                {
                    int parsedSteals;
                    if (int.TryParse(stealsText, out parsedSteals))
                    {
                        steals = parsedSteals;
                    }
                }
                if (!string.IsNullOrWhiteSpace(blocksText))
                {
                    int parsedBlocks;
                    if (int.TryParse(blocksText, out parsedBlocks))
                    {
                        blocks = parsedBlocks;
                    }
                }
                if (!string.IsNullOrWhiteSpace(turnoversText))
                {
                    int parsedTurnovers;
                    if (int.TryParse(turnoversText, out parsedTurnovers))
                    {
                        turnovers = parsedTurnovers;
                    }
                }
                if (!string.IsNullOrWhiteSpace(pfText))
                {
                    int parsedPf;
                    if (int.TryParse(pfText, out parsedPf))
                    {
                        pf = parsedPf;
                    }
                }
                if (!string.IsNullOrWhiteSpace(astToText))
                {
                    double parsedAstTo;
                    if (double.TryParse(astToText, out parsedAstTo))
                    {
                        astTo = parsedAstTo;
                    }
                }
                if (!string.IsNullOrWhiteSpace(fgmText))
                {
                    double parsedFgm;
                    if (double.TryParse(fgmText, out parsedFgm))
                    {
                        fgm = parsedFgm;
                    }
                }
                if (!string.IsNullOrWhiteSpace(fgaText))
                {
                    double parsedFga;
                    if (double.TryParse(fgaText, out parsedFga))
                    {
                        fga = parsedFga;
                    }
                }
                if (!string.IsNullOrWhiteSpace(fg_Text))
                {
                    double parsedFgPercent;
                    if (double.TryParse(fg_Text, out parsedFgPercent))
                    {
                        fg_ = parsedFgPercent;
                    }
                }
                if (!string.IsNullOrWhiteSpace(_3pmText))
                {
                    double parsed3pm;
                    if (double.TryParse(_3pmText, out parsed3pm))
                    {
                        _3pm = parsed3pm;
                    }
                }
                if (!string.IsNullOrWhiteSpace(_3paText))
                {
                    double parsed3pa;
                    if (double.TryParse(_3paText, out parsed3pa))
                    {
                        _3pa = parsed3pa;
                    }
                }
                if (!string.IsNullOrWhiteSpace(_3p_Text))
                {
                    double parsed3pPercent;
                    if (double.TryParse(_3p_Text, out parsed3pPercent))
                    {
                        _3p_ = parsed3pPercent;
                    }
                }
                if (!string.IsNullOrWhiteSpace(ftmText))
                {
                    double parsedFtm;
                    if (double.TryParse(ftmText, out parsedFtm))
                    {
                        ftm = parsedFtm;
                    }
                }
                if (!string.IsNullOrWhiteSpace(ftaText))
                {
                    double parsedFta;
                    if (double.TryParse(ftaText, out parsedFta))
                    {
                        fta = parsedFta;
                    }
                }
                if (!string.IsNullOrWhiteSpace(ft_Text))
                {
                    double parsedFtPercent;
                    if (double.TryParse(ft_Text, out parsedFtPercent))
                    {
                        ft_ = parsedFtPercent;
                    }
                }


                var wnbaData = context.NBAs
                    .Where(player =>
                        (string.IsNullOrEmpty(playerName) || player.Player_Name.Contains(playerName)) &&
                         (!gamesPlayed.HasValue || player.GP == gamesPlayed.Value) &&
                        (!gamesStarted.HasValue || player.GS == gamesStarted.Value) &&
                        (!minutes.HasValue || player.MIN == minutes.Value) &&
                        (!points.HasValue || player.PTS == points.Value) &&
                        (!offensiveRebounds.HasValue || player.OR == offensiveRebounds.Value) &&
                        (!defensiveRebounds.HasValue || player.DR == defensiveRebounds.Value) &&
                        (!totalRebounds.HasValue || player.REB == totalRebounds.Value) &&
                        (!assists.HasValue || player.AST == assists.Value) &&
                        (!steals.HasValue || player.STL == steals.Value) &&
                        (!blocks.HasValue || player.BLK == blocks.Value) &&
                        (!turnovers.HasValue || player.TO == turnovers.Value) &&
                        (!pf.HasValue || player.PF == pf.Value) &&
                        (!astTo.HasValue || player.AST_TO == astTo.Value) &&
                        (!fgm.HasValue || player.FGM == fgm.Value) &&
                        (!fga.HasValue || player.FGA == fga.Value) &&
                        (!fg_.HasValue || player.FG_ == fg_.Value) &&
                        (!_3pm.HasValue || player._3PM == _3pm.Value) &&
                        (!_3pa.HasValue || player._3PA == _3pa.Value) &&
                        (!_3p_.HasValue || player._3P_ == _3p_.Value) &&
                        (!ftm.HasValue || player.FTM == ftm.Value) &&
                        (!fta.HasValue || player.FTA == fta.Value) &&
                        (!ft_.HasValue || player.FT_ == ft_.Value) &&
                        (string.IsNullOrEmpty(teamName) || player.Team_Name.Contains(teamName))
                    )
                    .Select(player => new
                    {
                        player.Player_Name,
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

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedSport = comboBoxSports.SelectedItem.ToString();
            switch (selectedSport)
            {
                case "NBA":
                    SearchNbaData();
                    break;
                case "WNBA":
                    SearchWnbaData();
                    break;
                case "Baseball":
                    SearchBaseballData();
                    break;
            }
        }
    }
}
