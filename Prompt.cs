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
    public partial class Prompt : Form
    {
        private string input;

        public Prompt()
        {
            InitializeComponent();
        }
        public Prompt(string tit)
        {
            InitializeComponent();
            title.Text = tit;
        }
        public Prompt(string formTitle,string prompt,string defaultText)
        {
            InitializeComponent();
            this.Text = formTitle;
            title.Text = prompt;
            textBox.Text = defaultText;
        }
        public Prompt( string prompt, string defaultText)
        {
            InitializeComponent();
            title.Text = prompt;
            textBox.Text = defaultText;
        }
        public string getInput()
        {
            return input;
        }
        private void OK_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length != 0)
            {
                input = textBox.Text;
            }
        }
    }
}
