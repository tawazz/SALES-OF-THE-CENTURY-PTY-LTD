namespace SALES_OF_THE_CENTURY_PTY_LTD
{
    partial class SalesManDB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesManDB));
            this.listBox = new System.Windows.Forms.ListBox();
            this.ListSalesman = new System.Windows.Forms.Button();
            this.listByDollars = new System.Windows.Forms.Button();
            this.listByState = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.disp = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(341, 251);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(260, 229);
            this.listBox.TabIndex = 6;
            // 
            // ListSalesman
            // 
            this.ListSalesman.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ListSalesman.Location = new System.Drawing.Point(37, 78);
            this.ListSalesman.Name = "ListSalesman";
            this.ListSalesman.Size = new System.Drawing.Size(132, 60);
            this.ListSalesman.TabIndex = 2;
            this.ListSalesman.Text = "ListSalesman";
            this.ListSalesman.UseVisualStyleBackColor = true;
            this.ListSalesman.Click += new System.EventHandler(this.ListSalesman_Click);
            // 
            // listByDollars
            // 
            this.listByDollars.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listByDollars.Location = new System.Drawing.Point(223, 78);
            this.listByDollars.Name = "listByDollars";
            this.listByDollars.Size = new System.Drawing.Size(132, 60);
            this.listByDollars.TabIndex = 3;
            this.listByDollars.Text = "List Salesman by dollars";
            this.listByDollars.UseVisualStyleBackColor = true;
            this.listByDollars.Click += new System.EventHandler(this.listByDollars_Click);
            // 
            // listByState
            // 
            this.listByState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listByState.Location = new System.Drawing.Point(433, 78);
            this.listByState.Name = "listByState";
            this.listByState.Size = new System.Drawing.Size(132, 60);
            this.listByState.TabIndex = 4;
            this.listByState.Text = "List Salesman by Region";
            this.listByState.UseVisualStyleBackColor = true;
            this.listByState.Click += new System.EventHandler(this.listByState_Click);
            // 
            // search
            // 
            this.search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.search.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(433, 26);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(132, 30);
            this.search.TabIndex = 1;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // searchInput
            // 
            this.searchInput.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchInput.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInput.Location = new System.Drawing.Point(37, 28);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(378, 27);
            this.searchInput.TabIndex = 0;
            this.searchInput.TextChanged += new System.EventHandler(this.search_Click);
            this.searchInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchInput_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 44);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sales Man Database";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkedListBox
            // 
            this.checkedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(25, 251);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(257, 212);
            this.checkedListBox.TabIndex = 5;
            // 
            // disp
            // 
            this.disp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.disp.Location = new System.Drawing.Point(310, 40);
            this.disp.Name = "disp";
            this.disp.Size = new System.Drawing.Size(260, 54);
            this.disp.TabIndex = 8;
            this.disp.Text = "Display Salesman Details";
            this.disp.UseVisualStyleBackColor = true;
            this.disp.Click += new System.EventHandler(this.disp_Click);
            // 
            // edit
            // 
            this.edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.edit.Location = new System.Drawing.Point(0, 40);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(257, 54);
            this.edit.TabIndex = 7;
            this.edit.Text = "Edit Salesman Details";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Saleman List";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Salesman Details";
            // 
            // checkBox
            // 
            this.checkBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(310, 15);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(106, 19);
            this.checkBox.TabIndex = 12;
            this.checkBox.Text = "personal record";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.searchInput);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.listByState);
            this.groupBox1.Controls.Add(this.listByDollars);
            this.groupBox1.Controls.Add(this.ListSalesman);
            this.groupBox1.Location = new System.Drawing.Point(25, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 144);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBar.Location = new System.Drawing.Point(207, 579);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(394, 23);
            this.progressBar.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 587);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "DataBase Memory Used";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.disp);
            this.groupBox2.Controls.Add(this.edit);
            this.groupBox2.Controls.Add(this.checkBox);
            this.groupBox2.Location = new System.Drawing.Point(25, 462);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 100);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Salesman in Checklist First";
            // 
            // SalesManDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesManDB";
            this.Text = "SalesMan DataBase";
            this.Load += new System.EventHandler(this.ListDB_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button ListSalesman;
        private System.Windows.Forms.Button listByDollars;
        private System.Windows.Forms.Button listByState;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button disp;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}