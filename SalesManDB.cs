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
    public partial class SalesManDB : Form
    {
        private Saleman[] salesmen;
        int total = 0;
        int max = 5000;
        public bool dbChanged=false;
        public SalesManDB()
        {
            InitializeComponent();
        }
        public SalesManDB(Saleman[] sales, int tot)// recieves the saleman array + count figuer
        {
            InitializeComponent();
            if (total > -1)
            {
                total = tot;
                salesmen = new Saleman[total];
                for (int i = 0; i < total; i++)
                {
                    salesmen[i] = new Saleman();
                    salesmen[i] = sales[i];

                }
            }
        }
        private void ListSalesman_Click(object sender, EventArgs e)
        {
            checkedListBox.Items.Clear();
            for (int i = 0; i < total; i++)
            {
                if (salesmen[i] != null)
                {
                    checkedListBox.Items.Add(salesmen[i].getFname() + " " + salesmen[i].getLname());
                }

            }
        
        }
        private void listByDollars_Click(object sender, EventArgs e)
        {
             Prompt prompt = new Prompt("List Salesman By Amount","Enter Amount","1000000");

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                string amount = prompt.getInput();
                if (amount != null)
                {
                    double amnt = Convert.ToDouble(amount);
                    checkedListBox.Items.Clear();
                    for (int i = 0; i < total; i++)
                    {
                        if (salesmen[i] != null)
                        {
                            if (salesmen[i].getSales() > amnt)
                            {
                                checkedListBox.Items.Add(salesmen[i].getFname() + " " + salesmen[i].getLname());
                            }
                        }
                    }
                }
            }
        }
        private void search_Click(object sender, EventArgs e)
        {
          
                if (searchInput.Text.Length != 0 )
                {
                    string person=searchInput.Text;
                    person.ToLower();
                    checkedListBox.Items.Clear();
                    for (int i = 0; i < total; i++)
                    {
                        if(salesmen[i]!= null)
                        {
                            if (salesmen[i].getFname().ToLower().Contains(person) || salesmen[i].getLname().ToLower().Contains(person))
                            {
                                checkedListBox.Items.Add(salesmen[i].getFname() + " " + salesmen[i].getLname());
                            }
                        }
                       
                    }

                }
                else if (searchInput.Text.Length == 0)
                {
                    ListSalesman_Click(new Object(), EventArgs.Empty);
                }
            
        }
        private void searchInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                listBox.Items.Clear();
            }
        }
        private void listByState_Click(object sender, EventArgs e)
        {
            Prompt prompt = new Prompt("Enter Region");

            if (prompt.ShowDialog() == DialogResult.OK)
            {
                if (prompt.getInput() != null)
                {
                    string loc = prompt.getInput().ToLower();
                    checkedListBox.Items.Clear();
                    for (int i = 0; i < total; i++)
                    {
                        if (salesmen[i] != null)
                        {
                            if (salesmen[i].getState().ToLower().Contains(loc))
                            {
                                checkedListBox.Items.Add(salesmen[i].getFname() + " " + salesmen[i].getLname());
                            }
                        }
                    }
                }
            }
        }
        private void disp_Click(object sender, EventArgs e)
        {
            if (!checkBox.Checked)
            {
                Object name;
                listBox.Items.Clear();
                listBox.Items.Add("Name  Address  Phone  email  Sales");
                while (checkedListBox.CheckedItems.Count > 0)
                {
                    name = checkedListBox.CheckedItems[0];
                    char[] sep = new char[] { ' ' };// separator character
                    string[] parts = name.ToString().Split(sep);// remove spaces

                    for (int i = 0; i < total; i++)
                    {
                        if(salesmen[i]!=null)
                        {
                        if (salesmen[i].getFname().ToLower().Equals(parts[0].ToLower()) && salesmen[i].getLname().ToLower().Equals(parts[1].ToLower()) && salesmen[i] != null)
                        {
                            listBox.Items.Add(salesmen[i].getFname() + " " + salesmen[i].getLname() + " " + salesmen[i].getStNum() + " " + salesmen[i].getStreet() + " " + salesmen[i].getSurb() + " " + salesmen[i].getCode() + " " + salesmen[i].getState() + " " + salesmen[i].getPhone() + " " + salesmen[i].getMail() + " " + salesmen[i].getSales());
                        }
                            }
                    }
                    checkedListBox.Items.Remove(name);
                }
                ListSalesman_Click(new Object(), EventArgs.Empty);
            }
            else
            {
                listBox.Items.Clear();
                for (int x = 0; x < checkedListBox.Items.Count; x++)
                {
                    if (checkedListBox.GetItemChecked(x))
                    {
                        Object name;
                        Record salesman;
                        name = checkedListBox.Items[x];
                        char[] sep = new char[] { ' ' };// separator character
                        string[] parts = name.ToString().Split(sep);// remove spaces

                        for (int i = 0; i < total; i++)
                        {
                            if (salesmen[i] != null)
                            {
                                if (salesmen[i].getFname().ToLower().Equals(parts[0].ToLower()) && salesmen[i].getLname().ToLower().Equals(parts[1].ToLower()))
                                {
                                    salesman = new Record(salesmen[i]);
                                    salesman.Show();

                                }
                            }
                        }
                    }
                }
                ListSalesman_Click(new Object(), EventArgs.Empty);
            }
        }
        private void edit_Click(object sender, EventArgs e)
        {
            Object name;
            while (checkedListBox.CheckedItems.Count > 0)
            {
                name = checkedListBox.CheckedItems[0];
                char[] sep = new char[] { ' ' };// separator character
                string[] parts = name.ToString().Split(sep);// remove spaces

                for (int i = 0; i < total; i++)
                {
                    if (salesmen[i] != null)
                    {
                        if (salesmen[i].getFname().Equals(parts[0]) && salesmen[i].getLname().Equals(parts[1]))
                        {
                           Saleman edit = null;
                            if (edit == null)
                            {
                                edit = new Saleman(salesmen[i].getFname(), salesmen[i].getLname(), salesmen[i].getStNum(), salesmen[i].getStreet(), salesmen[i].getSurb(), salesmen[i].getCode(), salesmen[i].getState(), salesmen[i].getPhone(), salesmen[i].getMail(), salesmen[i].getSales());
                                edit.editSalesman("Edit Salesman");
                                if (edit.ShowDialog() == DialogResult.OK)
                                {
                                    salesmen[i].setSalesman(edit.getFname(), edit.getLname(), edit.getStNum(), edit.getStreet(), edit.getSurb(), edit.getCode(), edit.getState(), edit.getPhone(), edit.getMail(), edit.getSales());
                                }                           
                            }
                        }
                    }
                }
                checkedListBox.Items.Remove(name);
            }
            ListSalesman_Click(new Object(),EventArgs.Empty);
        
        }

        private void ListDB_Load(object sender, EventArgs e)
        {
            if (total > 0)
            {
                double percent = (double) total / max * 100;
                progressBar.Value = (int) percent;
                
            }
            else
            {
                progressBar.Value = 0;
            }
        }

    }
}
