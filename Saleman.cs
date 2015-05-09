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
    public partial class Saleman : Form 
    {
        private string fName;
        private string lName;
        private int stNum;
        private string stName;
        private string surb;
        private string state;
        private int pCode;
        private string email;
        private int phone;
        private double sales;
        private bool deleted = false;

        public Saleman()
        {
            InitializeComponent();
            fName = string.Empty;
            lName = string.Empty;
            deleteButton.Visible = false;
        }
        public Saleman(string fnam, string lnam, int streetNum, string streetname, string surbub , int Code, string location, int pNum, string mail, double Sales)
        {
            InitializeComponent();
            fName = fnam;
            lName = lnam;
            stNum= streetNum;
            stName = streetname;
            surb = surbub;
            // post code has to be a 4 digit code
            if (Code < 1000 && Code > 9999)
            {
                pCode = 9999;
            }
            else
            {
                pCode = Code;
            }
            phone = pNum;
            email = mail;
            state = location;
            sales = Sales;
            deleteButton.Visible = false;
        }
        public void setSalesman(string fnam, string lnam, int streetNum, string streetname, string surbub, int Code, string location, int pNum, string mail, double Sales)
        {
            fName = fnam;
            lName = lnam;
            stNum = streetNum;
            stName = streetname;
            surb = surbub;
            // post code has to be a 4 digit code
            if (Code < 1000 && Code > 9999)
            {
                pCode = 9999;
            }
            else
            {
                pCode = Code;
            }
            phone = pNum;
            email = mail;
            state = location;
            sales = Sales;
            deleteButton.Visible = false;
            stateInput.Text = state;
        }
        public void editSalesman(string tit)
        {
            fnameInput.Text = fName;
            lnameInput.Text = lName;
            stNumInput.Text = stNum.ToString();
            streetInput.Text = stName;
            surbInput.Text = surb;
            codeInput.Text = pCode.ToString();
            phoneInput.Text= phone.ToString();
            mailInput.Text= email;
            stateInput.Text= state;
            salesInput.Text= sales.ToString();
            tittle.Text = tit;
            deleteButton.Visible = false;
        }
        public void editSalesman(bool del)
        {
            fnameInput.Text = fName;
            lnameInput.Text = lName;
            stNumInput.Text = stNum.ToString();
            streetInput.Text = stName;
            surbInput.Text = surb;
            codeInput.Text = pCode.ToString();
            phoneInput.Text = phone.ToString();
            mailInput.Text = email;
            stateInput.Text = state;
            salesInput.Text = sales.ToString();
            tittle.Text = "Del SalesMan";
            if (del)
            {
                Save.Visible = false;
                deleteButton.Visible = true;
            }    
            
        }
        public void disableStateInput()
        {
            stateInput.Enabled = false;
        }
        public void setName(string nam)
        {
            fName = nam;

        }
        public void setStNum(int num)
        {
            stNum = num;
        }
        public void setStName(string street)
        {
            stName = street;
        }
        public void setSurbub(string surburb)
        {
            surb = surburb;
        }
        public void setPostCode(int Code)
        {
            if (Code < 1000 && Code > 9999)
            {
                pCode = 9999;
            }
            else
            {
                pCode = Code;
            }
        }
        public void setPhoneNum(int pnum)
        {
            phone = pnum;
        }
        public void setEmail(string mail)
        {
            email = mail;
        }
        public void setArea(string location)
        {
            state = location;
        }
        public void setSales(double Sales)
        {
            sales = Sales;
        }
        public string getFname()
        {
            return fName;
        }
        public string getLname()
        {
            return lName;
        }
        public int getStNum()
        {
            return stNum;
        }
        public string getStreet()
        {
            return stName;
        }
        public string getSurb()
        {
            return surb;
        }
        public string getState()
        {
            return state;
        }
        public string getMail()
        {
            return email;
        }
        public int getCode()
        {
            return pCode;
        }
        public int getPhone()
        {
            return phone;
        }
        public double getSales()
        {
            return sales;
        }
        public bool Deleted()
        { 
            return deleted; 
        }
        public void outputToFile(System.IO.StreamWriter sr)
        {
            sr.WriteLine(fName +"," +lName+"," + stNum + "," + stName + "," + surb + "," + pCode+"," + state + "," + phone + "," + email + "," + sales);
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (fnameInput.Text.Length != 0 || lnameInput.Text.Length != 0)
            {
                fName = fnameInput.Text;
                lName = lnameInput.Text;
            }     
            stName = streetInput.Text;
            surb = surbInput.Text;
            state = stateInput.Text;
            email = mailInput.Text;
        }
        private void SalemanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fnameInput.Text.Length == 0 || lnameInput.Text.Length == 0)
            {
                DialogResult err = MessageBox.Show(
                   "This is not a valid saleman entry therfore it wont be saved. Do You Want to continue? ", "You must enter first name or last name to save a Salesman",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning);
                if (err == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            if (mailInput.Text.Length != 0)
            {
                if (mailInput.Text.Contains(".") && mailInput.Text.Contains("@") && mailInput.Text.Contains("com"))
                {
                    email = mailInput.Text;
                }
                else
                {
                    email = "";
                    MessageBox.Show("not a valid email address");
                    e.Cancel = true;
                }
            }
            if (stNumInput.Text.Length != 0)
            {
                
                try
                {
                   int Num = Convert.ToInt32(stNumInput.Text);
                   if (Num < 1000 && Num > 9999)
                   {
                       e.Cancel = true;
                       MessageBox.Show("Post Code is a 4 digit number");
                   }
                   else {
                       stNum = Num;
                   }
                }
                catch (Exception)
                {
                    stNum = 0;
                    e.Cancel = true;
                    MessageBox.Show("Enter numbers only");

                }
            }
            else
            {
                stNum = 0;
            }
            if (codeInput.Text.Length != 0)
            {
                try
                {
                    pCode = Convert.ToInt32(codeInput.Text);
                }
                catch (Exception)
                {
                  
                    pCode = 9999;
                    e.Cancel = true;
                    MessageBox.Show("Enter numbers only");
                }
            }
            else
            {
                pCode = 9999;
            }

            if (phoneInput.Text.Length != 0)
            {
                try
                {
                    phone = Convert.ToInt32(phoneInput.Text);
                }
                catch (Exception)
                {
                    
                    phone = 0;
                    e.Cancel = true;
                    MessageBox.Show("Enter numbers only");
                }
            }
            else
            {
                phone = 0;
            }
            if (salesInput.Text.Length != 0)
            {
                try
                {
                    sales = Convert.ToDouble(salesInput.Text);
                }
                catch (Exception)
                {
                    
                    sales = 0;
                    e.Cancel = true;
                    MessageBox.Show("Enter numbers only");
                }
            }
            else
            {
                sales = 0;
            }
        }
        private void SalemanForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            { 
                 Save_Click(new Object(), EventArgs.Empty);
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            deleted = true;
            this.Close();
        }
    }
}
