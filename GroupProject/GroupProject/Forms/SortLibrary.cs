using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject.Forms
{
    public class SortLibrary
    {
        // public variables go here

        // create the data context objects.
        public SportsDataDataSet sd = new SportsDataDataSet();

        public IQueryable HowToSort(string league, string column, bool isAsc )
        {
            if (league == "baseball" || league == "Baseball" || league == "BASEBALL")
            {
                BaseballDataClassesDataContext sd = new BaseballDataClassesDataContext();
                // generating a results variable here for scope, will actually fill in the swtich
                var results = from s in sd.Baseballs
                              where s.Player_Name == " "
                              select s;

                switch (column)
                {
                    case ("Player Name"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s.Player_Name ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s.Player_Name descending
                                      select s;
                        }
                        break;

                    case ("Position"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s.Position ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s.Position descending
                                      select s;
                        }
                        break;

                    case ("Team Name"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s.Team_Name ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s.Team_Name descending
                                      select s;
                        }
                        break;

                    case ("GP"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s.GP ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s.GP descending
                                      select s;
                        }
                        break;

                    case ("AB"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s.AB ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s.AB descending
                                      select s;
                        }
                        break;

                    case ("R"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s.R ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s.R descending
                                      select s;
                        }
                        break;

                    case ("H"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s.H ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s.H descending
                                      select s;
                        }
                        break;

                    case ("2B"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s._2B ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s._2B descending
                                      select s;
                        }
                        break;

                    case ("3B"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s._3B ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s._3B descending
                                      select s;
                        }
                        break;

                    case ("HR"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s.HR ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s.HR descending
                                      select s;
                        }
                        break;

                    case ("RBI"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s.RBI ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s.RBI descending
                                      select s;
                        }
                        break;

                    case ("TB"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s.TB ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s.TB descending
                                      select s;
                        }
                        break;

                    case ("BB"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s.BB ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s.BB descending
                                      select s;
                        }
                        break;

                    case ("SO"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s.SO ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s.SO descending
                                      select s;
                        }
                        break;

                    case ("SB"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s.SB ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s.SB descending
                                      select s;
                        }
                        break;

                    case ("AVG"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s.AVG ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s.AVG descending
                                      select s;
                        }
                        break;

                    case ("OBP"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s.OBP ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s.OBP descending
                                      select s;
                        }
                        break;

                    case ("SLG"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s.SLG ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s.SLG descending
                                      select s;
                        }
                        break;

                    case ("OPS"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s.OPS ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s.OPS descending
                                      select s;
                        }
                        break;

                    case ("WAR"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseballs
                                      orderby s.WAR ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseballs
                                      orderby s.WAR descending
                                      select s;
                        }
                        break;

                    default:
                        break;
                } // end switch (column)
                return results;
            } // end if (league == "mlb" || league == "MLB")
            
            else if (league == "nba" || league == "NBA")
            {
                NBADataClassesDataContext sd = new NBADataClassesDataContext();
                var results = from s in sd.NBAs
                              where s.Player_Name == " "
                              select s;
                switch (column)
                {
                    case ("Player Name"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.Player_Name ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.Player_Name descending
                                      select s;
                        }
                        break;

                    case ("Postion"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.Postion ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.Postion descending
                                      select s;
                        }
                        break;

                    case ("Team Name"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.Team_Name ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.Team_Name descending
                                      select s;
                        }
                        break;

                    case ("GP"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.GP ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.GP descending
                                      select s;
                        }
                        break;

                    case ("GS"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.GS ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.GS descending
                                      select s;
                        }
                        break;

                    case ("MIN"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.MIN ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.MIN descending
                                      select s;
                        }
                        break;

                    case ("PTS"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.PTS ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.PTS descending
                                      select s;
                        }
                        break;

                    case ("OR"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.OR ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.OR descending
                                      select s;
                        }
                        break;

                    case ("DR"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.DR ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.DR descending
                                      select s;
                        }
                        break;

                    case ("REB"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.REB ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.REB descending
                                      select s;
                        }
                        break;

                    case ("AST"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.AST ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.AST descending
                                      select s;
                        }
                        break;

                    case ("STL"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.STL ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.STL descending
                                      select s;
                        }
                        break;

                    case ("BLK"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.BLK ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.BLK descending
                                      select s;
                        }
                        break;

                    case ("TO"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.TO ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.TO descending
                                      select s;
                        }
                        break;

                    case ("PF"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.PF ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.PF descending
                                      select s;
                        }
                        break;

                    case ("AST/TO"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.AST_TO ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.AST_TO descending
                                      select s;
                        }
                        break;

                    case ("FGM"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.FGM ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.FGM descending
                                      select s;
                        }
                        break;

                    case ("FGA"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.FGA ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.FGA descending
                                      select s;
                        }
                        break;

                    case ("FG%"): // need to confirm % works in string without the \
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.FG_ ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.FG_ descending
                                      select s;
                        }
                        break;

                    case ("3PM"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s._3PM ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s._3PM descending
                                      select s;
                        }
                        break;

                    case ("3PA"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s._3PA ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s._3PA descending
                                      select s;
                        }
                        break;

                    case ("3P%"): // need to confirm % works in string without the \
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s._3P_ ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s._3P_ descending
                                      select s;
                        }
                        break;

                    case ("FTM"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.FTM ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.FTM descending
                                      select s;
                        }
                        break;

                    case ("FTA"):
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.FTA ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.FTA descending
                                      select s;
                        }
                        break;

                    case ("FT%"): // need to confirm % works in string without the \
                        if (isAsc)
                        {
                            results = from s in sd.NBAs
                                      orderby s.FT_ ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBAs
                                      orderby s.FT_ descending
                                      select s;
                        }
                        break;

                } // end switch (column)
                return results;
            } // end else if (league == "nba" || league == "NBA")

            else if (league == "wnba" || league == "WNBA")
            {
                WNBADataClassesDataContext sd = new WNBADataClassesDataContext();
                var results = from s in sd.WNBAs
                              where s.Player_Name == " "
                              select s;
                switch (column)
                {
                    case ("Player Name"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.Player_Name ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.Player_Name descending
                                      select s;
                        }
                        break;

                    case ("Position"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.Position ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.Position descending
                                      select s;
                        }
                        break;

                    case ("Team Name"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.Team_Name ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.Team_Name descending
                                      select s;
                        }
                        break;

                    case ("GP"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.GP ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.GP descending
                                      select s;
                        }
                        break;

                    case ("GS"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.GS ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.GS descending
                                      select s;
                        }
                        break;

                    case ("MIN"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.MIN ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.MIN descending
                                      select s;
                        }
                        break;

                    case ("PTS"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.PTS ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.PTS descending
                                      select s;
                        }
                        break;

                    case ("OR"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.OR ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.OR descending
                                      select s;
                        }
                        break;

                    case ("DR"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.DR ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.DR descending
                                      select s;
                        }
                        break;

                    case ("REB"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.REB ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.REB descending
                                      select s;
                        }
                        break;

                    case ("AST"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.AST ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.AST descending
                                      select s;
                        }
                        break;

                    case ("STL"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.STL ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.STL descending
                                      select s;
                        }
                        break;

                    case ("BLK"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.BLK ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.BLK descending
                                      select s;
                        }
                        break;

                    case ("TO"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.TO ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.TO descending
                                      select s;
                        }
                        break;

                    case ("PF"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.PF ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.PF descending
                                      select s;
                        }
                        break;

                    case ("AST/TO"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.AST_TO ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.AST_TO descending
                                      select s;
                        }
                        break;

                    case ("FGM"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.FGM ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.FGM descending
                                      select s;
                        }
                        break;

                    case ("FGA"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.FGA ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.FGA descending
                                      select s;
                        }
                        break;

                    case ("FG%"): // need to confirm % works in string without the \
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.FG_ ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.FG_ descending
                                      select s;
                        }
                        break;

                    case ("3PM"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s._3PM ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s._3PM descending
                                      select s;
                        }
                        break;

                    case ("3PA"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s._3PA ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s._3PA descending
                                      select s;
                        }
                        break;

                    case ("3P%"): // need to confirm % works in string without the \
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s._3P_ ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s._3P_ descending
                                      select s;
                        }
                        break;

                    case ("FTM"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.FTM ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.FTM descending
                                      select s;
                        }
                        break;

                    case ("FTA"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.FTA ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.FTA descending
                                      select s;
                        }
                        break;

                    case ("FT%"): // need to confirm % works in string without the \
                        if (isAsc)
                        {
                            results = from s in sd.WNBAs
                                      orderby s.FT_ ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBAs
                                      orderby s.FT_ descending
                                      select s;
                        }
                        break;

                } // end switch (column)
                return results;
            } // end else if (league == "wnba" || league == "WNBA")

            else
            {
                MessageBox.Show("There was an error attempting to search for data using you desired parameters.");
                return null;
            }
        }
    } // end public SortLibrary
}
