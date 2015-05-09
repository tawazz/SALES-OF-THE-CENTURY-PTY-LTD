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
    public partial class Selection : Form
    {
        string[] input = new string[100];
        string[] selected = new string[100];//selected from list box
        public int size = 0;
        public Selection()
        {
            InitializeComponent();
            
        }
        public Selection(string tit,string[] listOutput )
        {
            InitializeComponent();
            labelT.Text = tit;
            input = listOutput;
        }

        private void Selection_Load(object sender, EventArgs e)
        {
            listItems();
        }
        private void listItems()
        {
              checkedListBox.Items.Clear();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != null)
                {
                    checkedListBox.Items.Add(input[i]);
                }
            }
        }
        private void select_Click(object sender, EventArgs e)
        {
            Object items;
            while (checkedListBox.CheckedItems.Count > 0)
            {
                items = checkedListBox.CheckedItems[0];
                if (items != null)
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] != null)
                        {
                            try
                            {
                                if (input[i].ToLower().Equals(items.ToString()))
                                {
                                    selected[size] = input[i];
                                    size++;
                                }
                            }
                            catch (Exception o) { MessageBox.Show(o + ""); }
                        }
                    }
                    checkedListBox.Items.Remove(items);
                }
            }
            listItems();
        }

        public string[] getSelected()
        {
            return selected;
        }
        public int getSize()
        {
            return size;
        }
    }
}
