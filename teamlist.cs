using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SALES_OF_THE_CENTURY_PTY_LTD
{
    public partial class teamlist : Form
    {
        Teams[] salesmanTeam;
        private Teams[] selected = new Teams[500];
        Saleman[] sm = new Saleman[500];
        string[] area;
        private int s = 0;

        public teamlist()
        {
            InitializeComponent();
        }
        public teamlist(Teams[] team, string[] locations)
        {
            InitializeComponent();
            salesmanTeam = team;
            area = locations;
            teamslist_Click(new object(), EventArgs.Empty);
            
        }
        private void teamslist_Click(object sender, EventArgs e)
        {
            checkedListBox.Items.Clear();
            for (int i = 0; i < area.Length; i++)
            {
                if (area[i] != null)
                {
                    checkedListBox.Items.Add(area[i]);
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Object team;
            while (checkedListBox.CheckedItems.Count > 0)
            {
                team = checkedListBox.CheckedItems[0];
                if (team != null)
                {
                    for (int i = 0; i < salesmanTeam.Length; i++)
                    {
                        if (salesmanTeam[i] != null)
                        {
                            try
                            {
                                if (salesmanTeam[i].getTeamArea().ToLower().Equals(team.ToString()))
                                {
                                    selected[s] = salesmanTeam[i];
                                    s++;
                                }
                            }
                            catch (Exception o) { MessageBox.Show(o+""); }
                        }
                    }
                    checkedListBox.Items.Remove(team);
                }
            }
            teamslist_Click(new object(),EventArgs.Empty);
        }
        public Teams[] getSelected()
        {
            return selected;
        }
    }
}
