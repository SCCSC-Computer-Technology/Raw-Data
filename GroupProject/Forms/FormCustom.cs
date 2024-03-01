﻿using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace GroupProject.Forms
{
    public partial class FormCustom : Form
    {
        public FormCustom()
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
    }
}

