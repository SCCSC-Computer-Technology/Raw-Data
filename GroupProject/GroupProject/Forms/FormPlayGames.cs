using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace GroupProject.Forms
{
    public partial class FormPlayGames : Form
    {
        public FormPlayGames()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormCustoms_Load); // Attach the Load event
            
        }
       

        private void FormCustoms_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            // Assuming ThemeColor is defined and accessible
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ColorTheme.PrimaryColor; // Make sure ColorTheme is correctly referenced
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ColorTheme.SecondaryColor;
                }
            }
            //label4.ForeColor = ColorTheme.SecondaryColor;
            //label5.ForeColor = ColorTheme.PrimaryColor;
        }

        private void soccerGame_Click(object sender, EventArgs e)
        {
            string url = "https://www.crazygames.com/game/soccer-legends-2021";

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Necessary for .NET Core, .NET 5, and .NET 6
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open the URL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void baseballGame_Click(object sender, EventArgs e)
        {
            string url = "https://www.crazygames.com/game/baseball";

            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Necessary for .NET Core, .NET 5, and .NET 6
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open the URL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void basketBall_Click(object sender, EventArgs e)
        {
            string url = "https://www.crazygames.com/game/basketbros";
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Necessary for .NET Core, .NET 5, and .NET 6
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open the URL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}

