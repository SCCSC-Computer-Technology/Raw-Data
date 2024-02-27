using GroupProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libraries;

// I would have liked this to have been a different folder (i.e. solution > Libraries > SearchLibrary. instead of solution > GroupProject > SearchLibrary)
// but then i'd have to connect the data sets again, and i wasn't sure if that would just make a hug mess or not.

/* Codes for ContainsValidData()
 * -2 means started with digit but contains characters that are not digits. 
 * -1 means Started with letter but contains characters that are not a letter or space.
 * 0 means input was null, white space  or started with neither a letter or digit.
 * 1 means input contains only letters or spaces.
 * 2 means input contains only digits.
 * We use code 2 as a positive retun indicator for searching pop/income/jobs later.
*/

namespace GroupProject
{
    internal class SearchLibrary
    {
        // public variables go here

        // create the data context objects.
        public SportsDataDataSet sd = new SportsDataDataSet();

        public EnumerableRowCollection WhatToSearch(string league, string searchWhat, string searchVal) // only test one value present
        {
            // need to test what type of data was entered
            int testInput = StringCheck.ContainsValidData(searchVal);

            if (league == "mlb" || league == "MLB")
            {
                // generating a results variable here for scope, will actually fill in the swtich
                var results = from s in sd.Baseball
                              where s.Player_Name == " "
                              select s;

                switch (searchWhat)
                {
                    case ("Player_Name"):
                        if (testInput == 1) {
                            results = from s in sd.Baseball
                                      where s.Player_Name.Contains(searchVal)
                                      select s;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid name containing only letters and spaces.");
                        }
                        break;

                    case ("Position"):
                        if (testInput == 1)
                        {
                            results = from s in sd.Baseball
                                      where s.Position.Contains(searchVal)
                                      select s;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid position containing only letters and spaces.");
                        }
                        break;

                    case ("Team_Name"):
                        if (testInput == 1)
                        {
                            results = from s in sd.Baseball
                                      where s.Team_Name.Contains(searchVal)
                                      select s;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid team name containing only letters and spaces.");
                        }
                        break;
                } // end switch (searchWhat)
                return results;
            } // end if (league == "mlb" || league == "MLB")

            else if (league == "nba" || league == "NBA")
            {
                var results = from s in sd.NBA
                              where s.Player_Name == " "
                              select s;
                switch (searchWhat)
                {
                    case ("Player_Name"):
                        if (testInput == 1)
                        {
                            results = from s in sd.NBA
                                      where s.Player_Name.Contains(searchVal)
                                      select s;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid name containing only letters and spaces.");
                        }
                        break;

                    case ("Position"):
                        if (testInput == 1)
                        {
                            results = from s in sd.NBA
                                      where s.Postion.Contains(searchVal)
                                      select s;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid position containing only letters and spaces.");
                        }
                        break;

                    case ("Team_Name"):
                        if (testInput == 1)
                        {
                            results = from s in sd.NBA
                                      where s.Team_Name.Contains(searchVal)
                                      select s;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid team name containing only letters and spaces.");
                        }
                        break;

                } // end switch (searchWhat)
                return results;
            } // end else if (league == "nba" || league == "NBA")

            else if (league == "wnba" || league == "WNBA")
            {
                var results = from s in sd.WNBA
                              where s.Player_Name == " "
                              select s;
                switch (searchWhat)
                {
                    case ("Player_Name"):
                        if (testInput == 1)
                        {
                            results = from s in sd.WNBA
                                      where s.Player_Name.Contains(searchVal)
                                      select s;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid name containing only letters and spaces.");
                        }
                        break;

                    case ("Position"):
                        if (testInput == 1)
                        {
                            results = from s in sd.WNBA
                                      where s.Position.Contains(searchVal)
                                      select s;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid position containing only letters and spaces.");
                        }
                        break;

                    case ("Team_Name"):
                        if (testInput == 1)
                        {
                            results = from s in sd.WNBA
                                      where s.Team_Name.Contains(searchVal)
                                      select s;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid team name containing only letters and spaces.");
                        }
                        break;

                } // end switch (searchWhat)
                return results;
            } // end else if (league == "wnba" || league == "WNBA")
            
            else
            {
                MessageBox.Show("There was an error attempting to search for data using you desired parameters.");
                return null;
            }
            
        } // end WhatToSearch(String league, String searchWhat)

        public EnumerableRowCollection WhatToSearch(string league, string searchWhat, string minVal, string maxVal)
        {
            // need to test what type of data was entered
            int minTest = StringCheck.ContainsValidData(minVal);
            int maxTest = StringCheck.ContainsValidData(maxVal);
            string searchFor;

            if (league == "mlb" || league == "MLB")
            {
                // generating a results variable here for scope, will actually fill in the swtich
                var results = from s in sd.Baseball
                              where s.Player_Name == " "
                              select s;

                switch (searchWhat)
                {
                    case ("GP"):
                        searchFor = " games played";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.Baseball
                                      where s.GP >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("AB"):
                        searchFor = " at bats";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.Baseball
                                      where s.AB >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("R"):
                        searchFor = " runs or runs scored";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.Baseball
                                      where s.R >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("H"):
                        searchFor = " hits";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.Baseball
                                      where s.H >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("2B"):
                        searchFor = " doubles hit";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.Baseball
                                      where s._2B >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("3B"):
                        searchFor = " triples hit";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.Baseball
                                      where s._3B >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("HR"):
                        searchFor = " home runs hit";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.Baseball
                                      where s.HR >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("RBI"):
                        searchFor = " runs batted in";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.Baseball
                                      where s.RBI >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("TB"):
                        searchFor = " total bases gained";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.Baseball
                                      where s.TB >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("BB"):
                        searchFor = " the number of times a player has been walked while at bat";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.Baseball
                                      where s.BB >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("SO"):
                        searchFor = " stike outs while at bat";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.Baseball
                                      where s.SO >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("SB"):
                        searchFor = " bases stolen";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.Baseball
                                      where s.SB >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("AVG"):
                        searchFor = " batting average";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.Baseball
                                      where s.AVG >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("OBP"):
                        searchFor = " on-base percentage";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.Baseball
                                      where s.OBP >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("SLG"):
                        searchFor = " slugging percentage";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.Baseball
                                      where s.SLG >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("OPS"):
                        searchFor = " OPS (on-base and slugging percentage)";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.Baseball
                                      where s.OPS >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("WAR"):
                        searchFor = " wins above replacement";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.Baseball
                                      where s.WAR >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;
                } // end switch (searchWhat)
                return results;
            } // end if (league == "mlb" || league == "MLB")

            else if (league == "nba" || league == "NBA")
            {
                var results = from s in sd.NBA
                              where s.Player_Name == " "
                              select s;
                switch (searchWhat)
                {
                    case ("GP"):
                        searchFor = " games played";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s.GP >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("GS"):
                        searchFor = " games started";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s.GS >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("MIN"):
                        searchFor = " minutes played";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s.MIN >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("PTS"):
                        searchFor = " points scored";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s.PTS >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("OR"):
                        searchFor = " offensive rebounds";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s.OR >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("DR"):
                        searchFor = " defensive rebounds";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s.DR >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("REB"):
                        searchFor = " total rebounds";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s.REB >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("AST"):
                        searchFor = " assists";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s.AST >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("STL"):
                        searchFor = " steals";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s.STL >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("BLK"):
                        searchFor = " blocked shots";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s.BLK >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("TO"):
                        searchFor = " turnovers";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s.TO >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("PF"):
                        searchFor = " personal fouls";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s.PF >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("AST/TO"):
                        searchFor = " assist/turnover ratio";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s._AST_TO >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("FGM"):
                        searchFor = " field goals made";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s.FGM >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("FGA"):
                        searchFor = " field goals attempted";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s.FGA >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("FG%"): // need to confirm % works in string without the \
                        searchFor = " field goal percentage";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s._FG_ >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("3PM"):
                        searchFor = " 3-point field goals made";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s._3PM >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("3PA"):
                        searchFor = " 3-point field goals attempted";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s._3PA >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("3P%"): // need to confirm % works in string without the \
                        searchFor = " 3-point field goal percentage";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s._3P_ >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("FTM"):
                        searchFor = " free throws made";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s.FTM >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("FTA"):
                        searchFor = " free throws attempted";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s.FTA >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("FT%"): // need to confirm % works in string without the \
                        searchFor = " free throw percentage";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.NBA
                                      where s._FT_ >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                } // end switch (searchWhat)
                return results;
            } // end else if (league == "nba" || league == "NBA")

            else if (league == "wnba" || league == "WNBA")
            {
                var results = from s in sd.WNBA
                              where s.Player_Name == " "
                              select s;
                switch (searchWhat)
                {
                    case ("GP"):
                        searchFor = " games played";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s.GP >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("GS"):
                        searchFor = " games started";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s.GS >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("MIN"):
                        searchFor = " minutes played";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s.MIN >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("PTS"):
                        searchFor = " points scored";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s.PTS >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("OR"):
                        searchFor = " offensive rebounds";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s.OR >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("DR"):
                        searchFor = " defensive rebounds";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s.DR >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("REB"):
                        searchFor = " total rebounds";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s.REB >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("AST"):
                        searchFor = " assists";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s.AST >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("STL"):
                        searchFor = " steals";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s.STL >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("BLK"):
                        searchFor = " blocked shots";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s.BLK >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("TO"):
                        searchFor = " turnovers";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s.TO >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("PF"):
                        searchFor = " personal fouls";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s.PF >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("AST/TO"):
                        searchFor = " assist/turnover ratio";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s._AST_TO >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("FGM"):
                        searchFor = " field goals made";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s.FGM >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("FGA"):
                        searchFor = " field goals attempted";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s.FGA >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("FG%"): // need to confirm % works in string without the \
                        searchFor = " field goal percentage";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s._FG_ >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("3PM"):
                        searchFor = " 3-point field goals made";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s._3PM >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("3PA"):
                        searchFor = " 3-point field goals attempted";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s._3PA >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("3P%"): // need to confirm % works in string without the \
                        searchFor = " 3-point field goal percentage";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s._3P_ >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("FTM"):
                        searchFor = " free throws made";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s.FTM >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("FTA"):
                        searchFor = " free throws attempted";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s.FTA >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                    case ("FT%"): // need to confirm % works in string without the \
                        searchFor = " free throw percentage";
                        if (minTest == 2 && maxTest == 2)
                        {
                            double.TryParse(minVal, out double doubleMinVal);
                            double.TryParse(maxVal, out double doubleMaxVal);
                            results = from s in sd.WNBA
                                      where s._FT_ >= doubleMinVal && s.GP <= doubleMaxVal
                                      select s;
                        }
                        else if (minTest != 2 && maxTest == 2)
                        {
                            MessageBox.Show("Please enter valid min number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else if (minTest == 2 && maxTest != 2)
                        {
                            MessageBox.Show("Please enter valid max number (only use integers and up to one decimal place) to search by" + searchFor + ".");
                        }
                        else
                        {
                            MessageBox.Show("Please enter valid numbers (only use integers and up to one decimal place) for both the min and max to search by" + searchFor + ".");
                        }
                        break;

                } // end switch (searchWhat)
                return results;
            } // end else if (league == "wnba" || league == "WNBA")
            
            else
            {
                MessageBox.Show("There was an error attempting to search for data using you desired parameters.");
                return null;
            }
        } // end WhatToSearch(String league, String searchWhat)

    } // end class SearchLibrary
}
