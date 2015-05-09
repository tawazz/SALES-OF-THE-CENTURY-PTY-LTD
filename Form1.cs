using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SALES_OF_THE_CENTURY_PTY_LTD
{
    public partial class Main : Form
    {
        //ATTRIBUTES
        Saleman[] salesman;
        teamlist list ;
        const int max = 5000;
        int count = -1;
        string file;
        bool fileLoc = false;
        SalesManDB db = null;

        //CONSTRUCTOR
        public Main()
        {
            InitializeComponent();
            salesman = new Saleman[max];
        }
        // method reads in a text file
        private void readFile()
        {
            
            if (fileLoc)
            {

                FileStream fs = new FileStream(@file, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    string nam; string lnam; int stNum; string stName; string surb; int Code; string location; int pNum; string mail; double Sales;// temp variables
                    string rec = sr.ReadLine();// read sales man record from file
                    char[] sep = new char[] { ',' };// separator character
                    string[] parts = rec.Split(sep);// remove spaces

                    if (parts.Length == 10)
                    {
                        nam = parts[0].TrimStart();
                        lnam = parts[1].Trim();
                        stNum = Convert.ToInt32(parts[2]);
                        stName = parts[3].Trim();
                        surb = parts[4].Trim();
                        Code = Convert.ToInt32(parts[5]);
                        location = parts[6].Trim();
                        pNum = Convert.ToInt32(parts[7]);
                        mail = parts[8].Trim();
                        Sales = Convert.ToDouble(parts[9]);
                        salesman[count + 1] = new Saleman(nam, lnam, stNum, stName, surb, Code, location, pNum, mail, Sales);// creates new saleman instance
                    }
                    else {
                        //reset the database when incorect file is found
                        MessageBox.Show("Your Selected File is Corrupt, Salesman Database is now reset ");
                        salesman = null;
                        salesman = new Saleman[max];
                        count = -1;
                        break;
                    }
                    count++;
                    
                    
                }
                    sr.Close();//close reading
                    fs.Close();//close the file
                    fs.Dispose();// dispose file
            }
            
        }
        //open a text file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Text File|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                file = ofd.FileName;
                fileLoc = true;//sets file location to true
                readFile();// reads the file
            }
            else
            {
                fileLoc = false;
            }
        }
        //save to a text file
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.Filter = "Text file|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream output = new FileStream(@sfd.FileName, FileMode.Create);
                
                StreamWriter sw = new StreamWriter(output);
                for (int i = 0; i <= count; i++)
                {
                    if(salesman[i]!=null)
                    salesman[i].outputToFile(sw);//output method
                }
                sw.Close();
                output.Close();
                output.Dispose();

            }
        }
        //exits the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //adds a new salesman to the system by filling in a form
        private void button1_Click(object sender, EventArgs e)
        {
            Saleman rec = null;
            if (rec == null)
            {
                rec = new Saleman();
                if (rec.ShowDialog() == DialogResult.OK)
                {
                    if (rec.getFname().Length != 0 && rec.getLname().Length != 0)
                    {
                        salesman[count+1] = new Saleman(rec.getFname(), rec.getLname(), rec.getStNum(), rec.getStreet(), rec.getSurb(), rec.getCode(), rec.getState(), rec.getPhone(), rec.getMail(), rec.getSales());
                        count++;
                    }
                }
            }
        }
        // adds sales man from other classes
        public void addSalesman(Saleman [] sm)
        {
            for (int i = 0; i < sm.Length; i++)
            {
                if (sm[i] != null)
                {
                    salesman[count + 1] = new Saleman();
                    salesman[count + 1] = sm[i];
                    count++;
                }
            }            
        }
        // view and edit salesman database
        private void DB_Click(object sender, EventArgs e)
        {
                if (db == null)
                {
                    db = new SalesManDB(salesman, count+1);
                    db.Show();
                }
                else
                {
                    db.Close();
                    db = null;
                    db = new SalesManDB(salesman, count + 1);
                    db.Show();
                }
            

            
        }
        //saves to current file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream output = new FileStream(@file, FileMode.Create);
           
                StreamWriter sw = new StreamWriter(output);
                if (count >= 0)
                {
                    for (int i = 0; i <= count; i++)
                    {
                        salesman[i].outputToFile(sw);//output method
                    }
                }
                sw.Close();
                output.Close();
                output.Dispose();
            }
            catch (Exception) 
            {
                saveAsToolStripMenuItem_Click(new Object(), EventArgs.Empty);
            }
        

        }
        // deletes selected sales man
        private void delete_Click(object sender, EventArgs e)
        {
            string []selected= new string[1000];
            string [] names =getNames();
            Selection delet = new Selection("Select Salesman to Delete",names);
            if (delet.ShowDialog() == DialogResult.OK)
            {
                selected = delet.getSelected();
                    for (int i = 0; i <= count; i++)
                    {
                        if (salesman[i] != null)
                        {
                            string SName= salesman[i].getFname()+" "+salesman[i].getLname();
                            for (int x = 0; x < selected.Length; x++)
                            {
                                if (selected[x] != null)
                                {
                                    if (SName.Equals(selected[x]))
                                    {
                                        Saleman del = null;
                                        if (del == null)
                                        {
                                            del = new Saleman(salesman[i].getFname(), salesman[i].getLname(), salesman[i].getStNum(), salesman[i].getStreet(), salesman[i].getSurb(), salesman[i].getCode(), salesman[i].getState(), salesman[i].getPhone(), salesman[i].getMail(), salesman[i].getSales());
                                            del.editSalesman(true);
                                            if (del.ShowDialog() == DialogResult.OK)
                                            {
                                                if (del.Deleted())
                                                {
                                                    if (count > -1)
                                                    {
                                                        salesman[i] = null;
                                                        count--;
                                                        break;
                                                    }
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                        }
                               
                    }
                }
            
        }
        //views teams in the system
        private void teams_Click(object sender, EventArgs e)
        {
            list = null;
            Teams[] sel = new Teams[1000];
            string[] locations = getLocation(Locations());

            // make into teams
            if (list == null)
            {
                list = new teamlist(makeTeams(locations), locations);
                //manage team
                if (list.ShowDialog() == DialogResult.OK)
                {
                    sel = list.getSelected();
                    for (int s = 0; s < sel.Length; s++)
                    {
                        if (sel[s] != null)
                        {
                            if (sel[s].ShowDialog() != DialogResult.OK)
                            {
                                //add new sales man
                                addSalesman(sel[s].getNewSalesman());
                            }
                        }
                    }
                }
            }
                
        }
        //gets all the teams in the system
        private Dictionary<string,int> Locations()
        {

            Dictionary<string, int> teams = new Dictionary<string, int>();
            int x = 0;
          
            //get locations
            for (int i = 0; i <= count; i++)
            {
                if(salesman[i]!=null)
                teams[salesman[i].getState().ToLower()] = x++;
            }
            return teams;
        
        }
        // creates a string array of locations
        private string[] getLocation(Dictionary<string ,int> teams)
        {
            string[] locations = new string[1000];

            for (int i = 0; i < teams.Count; i++)
            {
                locations[i] = teams.ElementAt(i).Key;
            }

            return locations;

        }
        //creates team records
        private Teams[] makeTeams(string[] locations)
        {
            
            Teams[] teamDB = new Teams[1000];

            for (int i = 0; i < locations.Length; i++)
            {
                Saleman[] teamsByLoc = new Saleman[max];
                if (locations[i] != null)
                {
                    int nums = 0;
                    for (int x = 0; x <= count; x++)
                    {
                        if (salesman[x] != null)
                        {
                            if (salesman[x].getState().ToLower().Equals(locations[i].ToLower()))
                            {
                                teamsByLoc[nums] = salesman[x];
                                nums++;
                            }
                        }
                    }
                    teamDB[i] = new Teams(teamsByLoc,nums,count);
                }
            }

            return teamDB;
        }
        //adds additional teams
        private void addTeam_Click(object sender, EventArgs e)
        {
            Prompt p = new Prompt("name of team","Enter the name of the team,\nNote this will be region of the team","Enter Team Name");
            if (p.ShowDialog() == DialogResult.OK)
            {
                string loc = p.getInput();
                Teams[] T = new Teams[1];
                T[0] = new Teams();
                T[0].setTeamArea(loc);
                if (T[0].ShowDialog() != DialogResult.OK)
                {
                    addSalesman(T[0].getNewSalesman());
                }
            }
        
        }
        //deletes the selected team
        private void delTeam_Click(object sender, EventArgs e)
        {
            string[] locations = getLocation(Locations());
            string[] sel = new string[1000];
            Selection listItems = null;
            if(listItems == null)
            {
                listItems = new Selection("List of Locations", locations);

                if (listItems.ShowDialog() == DialogResult.OK)
                {
                    sel = listItems.getSelected();

                    for (int i = 0; i <= count; i++)
                    {
                        if (salesman[i] != null)
                        {
                            for (int x = 0; x < sel.Length; x++)
                            {
                                if (sel[x] != null)
                                {
                                    if (salesman[i].getState().ToLower().Equals(sel[x]))
                                    {
                                        salesman[i] = null;
                                        count--;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        //gets all the names of salesman in the system
        private string[] getNames()
        {
            string[] names = new string[1000];

            for (int i = 0; i <= count; i++)
            {
                if (salesman[i] != null)
                {
                    names[i] = salesman[i].getFname() + " "+salesman[i].getLname();
                }
            }
            return names;
        }
        //help menu
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {   //ADD LINK TO HELP FILE
                System.Diagnostics.Process.Start(@"http://db.tt/i51gidf1");
            }
            catch (Exception) { 
                //file not found
            }
        }
        //about 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SALES OF THE CENTURY PTY LTD\nTNyakudjga\nCopyright © Tawanda Nyakudjga  2013\n@tawazz\nversion 0.1");
        }

        private void modTeam_Click(object sender, EventArgs e)
        {
            string[] locations = getLocation(Locations());
            string[] sel = new string[1000];
            Selection listItems = null;
            string newLoc = string.Empty;
            Prompt area = new Prompt("Enter New team Name", "Enter Team name");
            if (area.ShowDialog() == DialogResult.OK)
            {
                newLoc = area.getInput();


                if (listItems == null)
                {
                    listItems = new Selection("Select team to rename of Teams", locations);
                    listItems.Text = "hello";
                    if (listItems.ShowDialog() == DialogResult.OK)
                    {
                        sel = listItems.getSelected();

                        for (int i = 0; i <= count; i++)
                        {
                            if (salesman[i] != null)
                            {
                                for (int x = 0; x < sel.Length; x++)
                                {
                                    if (sel[x] != null)
                                    {
                                        if (salesman[i].getState().ToLower().Equals(sel[x].ToLower()))
                                        {
                                            salesman[i].setArea(newLoc);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}
