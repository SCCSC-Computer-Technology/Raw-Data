using System;
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
       



        public EnumerableRowCollection HowToSort(string league, string column, bool isAsc )
        {
            if (league == "baseball" || league == "Baseball" || league == "BASEBALL")
            {
                // generating a results variable here for scope, will actually fill in the swtich
                var results = from s in sd.Baseball
                              where s.Player_Name == " "
                              select s;

                switch (column)
                {
                    case ("Player_Name"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s.Player_Name ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
                                      orderby s.Player_Name descending
                                      select s;
                        }
                        break;

                    case ("Position"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s.Position ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
                                      orderby s.Position descending
                                      select s;
                        }
                        break;

                    case ("Team_Name"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s.Team_Name ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
                                      orderby s.Team_Name descending
                                      select s;
                        }
                        break;

                    case ("GP"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s.GP ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
                                      orderby s.GP descending
                                      select s;
                        }
                        break;

                    case ("AB"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s.AB ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
                                      orderby s.AB descending
                                      select s;
                        }
                        break;

                    case ("R"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s.R ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
                                      orderby s.R descending
                                      select s;
                        }
                        break;

                    case ("H"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s.H ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
                                      orderby s.H descending
                                      select s;
                        }
                        break;

                    case ("2B"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s._2B ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
                                      orderby s._2B descending
                                      select s;
                        }
                        break;

                    case ("3B"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s._3B ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
                                      orderby s._3B descending
                                      select s;
                        }
                        break;

                    case ("HR"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s.HR ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
                                      orderby s.HR descending
                                      select s;
                        }
                        break;

                    case ("RBI"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s.RBI ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
                                      orderby s.RBI descending
                                      select s;
                        }
                        break;

                    case ("TB"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s.TB ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
                                      orderby s.TB descending
                                      select s;
                        }
                        break;

                    case ("BB"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s.BB ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
                                      orderby s.BB descending
                                      select s;
                        }
                        break;

                    case ("SO"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s.SO ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
                                      orderby s.SO descending
                                      select s;
                        }
                        break;

                    case ("SB"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s.SB ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
                                      orderby s.SB descending
                                      select s;
                        }
                        break;

                    case ("AVG"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s.AVG ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
                                      orderby s.AVG descending
                                      select s;
                        }
                        break;

                    case ("OBP"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s.OBP ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
                                      orderby s.OBP descending
                                      select s;
                        }
                        break;

                    case ("SLG"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s.SLG ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
                                      orderby s.SLG descending
                                      select s;
                        }
                        break;

                    case ("OPS"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s.OPS ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
                                      orderby s.OPS descending
                                      select s;
                        }
                        break;

                    case ("WAR"):
                        if (isAsc)
                        {
                            results = from s in sd.Baseball
                                      orderby s.WAR ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.Baseball
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
                var results = from s in sd.NBA
                              where s.Player_Name == " "
                              select s;
                switch (column)
                {
                    case ("Player_Name"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s.Player_Name ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s.Player_Name descending
                                      select s;
                        }
                        break;

                    case ("Position"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s.Postion ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s.Postion descending
                                      select s;
                        }
                        break;

                    case ("Team_Name"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s.Team_Name ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s.Team_Name descending
                                      select s;
                        }
                        break;

                    case ("GP"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s.GP ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s.GP descending
                                      select s;
                        }
                        break;

                    case ("GS"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s.GS ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s.GS descending
                                      select s;
                        }
                        break;

                    case ("MIN"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s.MIN ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s.MIN descending
                                      select s;
                        }
                        break;

                    case ("PTS"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s.PTS ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s.PTS descending
                                      select s;
                        }
                        break;

                    case ("OR"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s.OR ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s.OR descending
                                      select s;
                        }
                        break;

                    case ("DR"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s.DR ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s.DR descending
                                      select s;
                        }
                        break;

                    case ("REB"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s.REB ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s.REB descending
                                      select s;
                        }
                        break;

                    case ("AST"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s.AST ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s.AST descending
                                      select s;
                        }
                        break;

                    case ("STL"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s.STL ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s.STL descending
                                      select s;
                        }
                        break;

                    case ("BLK"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s.BLK ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s.BLK descending
                                      select s;
                        }
                        break;

                    case ("TO"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s.TO ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s.TO descending
                                      select s;
                        }
                        break;

                    case ("PF"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s.PF ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s.PF descending
                                      select s;
                        }
                        break;

                    case ("AST/TO"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s._AST_TO ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s._AST_TO descending
                                      select s;
                        }
                        break;

                    case ("FGM"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s.FGM ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s.FGM descending
                                      select s;
                        }
                        break;

                    case ("FGA"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s.FGA ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s.FGA descending
                                      select s;
                        }
                        break;

                    case ("FG%"): // need to confirm % works in string without the \
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s._FG_ ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s._FG_ descending
                                      select s;
                        }
                        break;

                    case ("3PM"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s._3PM ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s._3PM descending
                                      select s;
                        }
                        break;

                    case ("3PA"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s._3PA ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s._3PA descending
                                      select s;
                        }
                        break;

                    case ("3P%"): // need to confirm % works in string without the \
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s._3P_ ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s._3P_ descending
                                      select s;
                        }
                        break;

                    case ("FTM"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s.FTM ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s.FTM descending
                                      select s;
                        }
                        break;

                    case ("FTA"):
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s.FTA ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s.FTA descending
                                      select s;
                        }
                        break;

                    case ("FT%"): // need to confirm % works in string without the \
                        if (isAsc)
                        {
                            results = from s in sd.NBA
                                      orderby s._FT_ ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.NBA
                                      orderby s._FT_ descending
                                      select s;
                        }
                        break;

                } // end switch (column)
                return results;
            } // end else if (league == "nba" || league == "NBA")

            else if (league == "wnba" || league == "WNBA")
            {
                var results = from s in sd.WNBA
                              where s.Player_Name == " "
                              select s;
                switch (column)
                {
                    case ("Player_Name"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s.Player_Name ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s.Player_Name descending
                                      select s;
                        }
                        break;

                    case ("Position"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s.Position ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s.Position descending
                                      select s;
                        }
                        break;

                    case ("Team_Name"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s.Team_Name ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s.Team_Name descending
                                      select s;
                        }
                        break;

                    case ("GP"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s.GP ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s.GP descending
                                      select s;
                        }
                        break;

                    case ("GS"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s.GS ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s.GS descending
                                      select s;
                        }
                        break;

                    case ("MIN"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s.MIN ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s.MIN descending
                                      select s;
                        }
                        break;

                    case ("PTS"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s.PTS ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s.PTS descending
                                      select s;
                        }
                        break;

                    case ("OR"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s.OR ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s.OR descending
                                      select s;
                        }
                        break;

                    case ("DR"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s.DR ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s.DR descending
                                      select s;
                        }
                        break;

                    case ("REB"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s.REB ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s.REB descending
                                      select s;
                        }
                        break;

                    case ("AST"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s.AST ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s.AST descending
                                      select s;
                        }
                        break;

                    case ("STL"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s.STL ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s.STL descending
                                      select s;
                        }
                        break;

                    case ("BLK"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s.BLK ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s.BLK descending
                                      select s;
                        }
                        break;

                    case ("TO"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s.TO ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s.TO descending
                                      select s;
                        }
                        break;

                    case ("PF"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s.PF ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s.PF descending
                                      select s;
                        }
                        break;

                    case ("AST/TO"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s._AST_TO ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s._AST_TO descending
                                      select s;
                        }
                        break;

                    case ("FGM"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s.FGM ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s.FGM descending
                                      select s;
                        }
                        break;

                    case ("FGA"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s.FGA ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s.FGA descending
                                      select s;
                        }
                        break;

                    case ("FG%"): // need to confirm % works in string without the \
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s._FG_ ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s._FG_ descending
                                      select s;
                        }
                        break;

                    case ("3PM"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s._3PM ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s._3PM descending
                                      select s;
                        }
                        break;

                    case ("3PA"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s._3PA ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s._3PA descending
                                      select s;
                        }
                        break;

                    case ("3P%"): // need to confirm % works in string without the \
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s._3P_ ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s._3P_ descending
                                      select s;
                        }
                        break;

                    case ("FTM"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s.FTM ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s.FTM descending
                                      select s;
                        }
                        break;

                    case ("FTA"):
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s.FTA ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s.FTA descending
                                      select s;
                        }
                        break;

                    case ("FT%"): // need to confirm % works in string without the \
                        if (isAsc)
                        {
                            results = from s in sd.WNBA
                                      orderby s._FT_ ascending
                                      select s;

                        }
                        else
                        {
                            results = from s in sd.WNBA
                                      orderby s._FT_ descending
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
    }
}
