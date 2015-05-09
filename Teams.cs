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
    public partial class Teams : Form
    {
        int max = 500;
        int itr = 0;
        int numOfSalesman;
        Saleman[] salesman;
        string location;
        bool teamleader = false;

        public Teams()
        {
            InitializeComponent();
            numOfSalesman = 0;
            salesman = new Saleman[max];
            teamName.Hide();

        }
        public Teams(Saleman[] sm,int count,int num)
        {
            InitializeComponent();
            location = sm[0].getState();
            itr = count;
            numOfSalesman = count; ;
            salesman = new Saleman[max];
            salesman = sm;
            teamName.Text = "Team " + location;
            tsLabel.Text = "Team Total Sales $"+calTeamSales().ToString();
            button1_Click(new object(), EventArgs.Empty);
        
        }
        public string getTeamArea()
        {
            if (itr == 0)
            {
                return location;
            }
            else {
                return salesman[0].getState();
            }
        }
        public void setTeamArea(string loc)
        {
            location = loc;
            teamName.Show();
            teamName.Text = "Team " + loc;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            for (int i = 0; i < itr; i++)
            {
                if (salesman[i] != null)
                {
                    listBox.Items.Add(salesman[i].getFname() + " " + salesman[i].getLname());
                }
            }
        }
        private void Teams_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (itr == 0)
            {
                DialogResult err = MessageBox.Show(
                   "You must add at least one salesman to the team for the team saved. Do You Want to continue closing? ", "No salesman in the team, Team wont be saved",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning);
                if (err == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }

           this.Hide();
           e.Cancel = true;
        }
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selIterm = (string)listBox.SelectedItem;

            for (int i = 0; i < max;i++ )
            {
                if (salesman[i] != null)
                {
                    if (selIterm == salesman[i].getFname() + " " + salesman[i].getLname())
                    {
                        Saleman edit = null;
                        if (edit == null)
                        {
                            edit = new Saleman(salesman[i].getFname(), salesman[i].getLname(), salesman[i].getStNum(), salesman[i].getStreet(), salesman[i].getSurb(), salesman[i].getCode(), salesman[i].getState(), salesman[i].getPhone(), salesman[i].getMail(), salesman[i].getSales());
                            edit.editSalesman("Edit Salesman");
                            edit.disableStateInput();
                            if (edit.ShowDialog() == DialogResult.OK)
                            {
                                salesman[i].setSalesman(edit.getFname(), edit.getLname(), edit.getStNum(), edit.getStreet(), edit.getSurb(), edit.getCode(), edit.getState(), edit.getPhone(), edit.getMail(), edit.getSales());
                                tsLabel.Text = "Team Total Sales $" + calTeamSales().ToString();
                            }
                        }
                    }
                }
            }
            
        }
        private void addSalesman_Click(object sender, EventArgs e)
        {
            Saleman newSaleman = new Saleman();
            newSaleman.setArea(location);
            newSaleman.disableStateInput();
            newSaleman.editSalesman("Add Salesman");
            if (newSaleman.ShowDialog() == DialogResult.OK)
            {
                if (newSaleman.getFname().Length != 0 && newSaleman.getLname().Length != 0)
                {
                    salesman[itr]=new Saleman(newSaleman.getFname(),newSaleman.getLname(),newSaleman.getStNum(),newSaleman.getStreet(),newSaleman.getSurb(),newSaleman.getCode(),newSaleman.getState(),newSaleman.getPhone(),newSaleman.getMail(),newSaleman.getSales());
                    itr++;
                    tsLabel.Text = "Team Total Sales $" + calTeamSales().ToString();
                    
                }
            }
        }
        public Saleman[] getNewSalesman()
        { 
            Saleman[] newSalesman=new Saleman[50];
            int x = 0;
                if(itr > numOfSalesman)
                {
                    int diffrence = itr-numOfSalesman;

                    for(int i=numOfSalesman;i<itr;i++)
                    {
                            newSalesman[x] = salesman[i];
                            x++;
                    }
                }

                return newSalesman;
        }
        public int getnumOfnewSalesman()
        { 
            return itr-numOfSalesman;
        }
        private double calTeamSales()
        {
            double totalsales=0;

            for (int i = 0; i < itr; i++)
            {
                if(salesman[i]!=null)
                {
                    totalsales = totalsales + salesman[i].getSales();
                }
            }
            return totalsales;
        }

        
    }
}
