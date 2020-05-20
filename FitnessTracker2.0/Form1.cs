﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessTracker2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void customDesign()
        {
            actpanel1.Visible = false;
            dietpanel1.Visible = false;

        }
        private void hidesub()
        {
            if (actpanel1.Visible == true)
                actpanel1.Visible = false;
            if (dietpanel1.Visible == true)
                dietpanel1.Visible = false;

        }
        private void showsub(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesub();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void dietmain_Click(object sender, EventArgs e)
        {
            showsub(dietpanel1);
        }

        private void actMain_Click(object sender, EventArgs e)
        {
            showsub(actpanel1);
        }
        private Form activenow = null;
        public void openChildForm(Form child)
        {
            if (activenow != null)
                activenow.Close();
            activenow = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            childpanel1.Controls.Add(child);
            childpanel1.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void dietlog_Click(object sender, EventArgs e)
        {
            openChildForm(new DietLog());
            hidesub();
        }

        private void newdiet_Click(object sender, EventArgs e)
        {
            openChildForm(new DietMaster());
            hidesub();
        }

        private void actlog_Click(object sender, EventArgs e)
        {
            openChildForm(new ActLog());
            hidesub();
        }

        private void actmaster_Click(object sender, EventArgs e)
        {
            openChildForm(new ActivityMaster() );
            hidesub();
        }

        private void acttoday_Click(object sender, EventArgs e)
        {
            openChildForm(new ActDReport());
            hidesub();
        }

        private void diettoday_Click(object sender, EventArgs e)
        {
            openChildForm(new DDietToday());
            hidesub();

        }

        private void numbersdiet_Click(object sender, EventArgs e)
        {
            openChildForm(new dietCum());
            hidesub();
        }

        private void actnumbers_Click(object sender, EventArgs e)
        {
            openChildForm(new ActCum());
            hidesub();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            openChildForm(new UserPage());
            hidesub();
        }

        private void goal_Click(object sender, EventArgs e)
        {
            openChildForm(new Goals());
            hidesub();
        }
    }
}
