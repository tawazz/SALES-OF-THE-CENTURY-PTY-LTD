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
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }
        public Record(Saleman SM)
        {
            InitializeComponent();
            LabelName.Text = SM.getFname().ToUpper();
            labelLastName.Text = SM.getLname().ToUpper();
            num.Text = SM.getStNum().ToString();
            street.Text = SM.getStreet();
            area.Text = SM.getSurb();
            code.Text = SM.getCode().ToString();
            State.Text = SM.getState();
            phone.Text = "0"+SM.getPhone().ToString();
            mail.Text = SM.getMail();
            sales.Text = SM.getSales().ToString();

            this.Text = "SalesMan " + SM.getFname().ToUpper() + " " + SM.getLname().ToUpper() +" Details";
        }
        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
