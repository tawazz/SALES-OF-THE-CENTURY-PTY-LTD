namespace SALES_OF_THE_CENTURY_PTY_LTD
{
    partial class Teams
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.listSalesman = new System.Windows.Forms.Button();
            this.teamName = new System.Windows.Forms.Label();
            this.addSalesman = new System.Windows.Forms.Button();
            this.tsLabel = new System.Windows.Forms.Label();
            this.tlLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(9, 121);
            this.listBox.Margin = new System.Windows.Forms.Padding(4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(242, 244);
            this.listBox.TabIndex = 0;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // listSalesman
            // 
            this.listSalesman.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSalesman.Location = new System.Drawing.Point(9, 373);
            this.listSalesman.Margin = new System.Windows.Forms.Padding(4);
            this.listSalesman.Name = "listSalesman";
            this.listSalesman.Size = new System.Drawing.Size(100, 40);
            this.listSalesman.TabIndex = 1;
            this.listSalesman.Text = "List SalesMan";
            this.listSalesman.UseVisualStyleBackColor = true;
            this.listSalesman.Click += new System.EventHandler(this.button1_Click);
            // 
            // teamName
            // 
            this.teamName.AutoSize = true;
            this.teamName.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamName.Location = new System.Drawing.Point(8, 20);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(91, 20);
            this.teamName.TabIndex = 2;
            this.teamName.Text = "team name";
            // 
            // addSalesman
            // 
            this.addSalesman.Location = new System.Drawing.Point(146, 373);
            this.addSalesman.Name = "addSalesman";
            this.addSalesman.Size = new System.Drawing.Size(105, 40);
            this.addSalesman.TabIndex = 3;
            this.addSalesman.Text = "Add Salesman";
            this.addSalesman.UseVisualStyleBackColor = true;
            this.addSalesman.Click += new System.EventHandler(this.addSalesman_Click);
            // 
            // tsLabel
            // 
            this.tsLabel.AutoSize = true;
            this.tsLabel.Location = new System.Drawing.Point(12, 51);
            this.tsLabel.Name = "tsLabel";
            this.tsLabel.Size = new System.Drawing.Size(142, 16);
            this.tsLabel.TabIndex = 4;
            this.tsLabel.Text = "Total Sales $ 1000 000";
            // 
            // tlLabel
            // 
            this.tlLabel.AutoSize = true;
            this.tlLabel.Location = new System.Drawing.Point(12, 76);
            this.tlLabel.Name = "tlLabel";
            this.tlLabel.Size = new System.Drawing.Size(87, 16);
            this.tlLabel.TabIndex = 5;
            this.tlLabel.Text = "Team Leader";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Click Salesman to edit their details";
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 426);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tlLabel);
            this.Controls.Add(this.tsLabel);
            this.Controls.Add(this.addSalesman);
            this.Controls.Add(this.teamName);
            this.Controls.Add(this.listSalesman);
            this.Controls.Add(this.listBox);
            this.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Teams";
            this.Text = "Teams";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Teams_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button listSalesman;
        private System.Windows.Forms.Label teamName;
        private System.Windows.Forms.Button addSalesman;
        private System.Windows.Forms.Label tsLabel;
        private System.Windows.Forms.Label tlLabel;
        private System.Windows.Forms.Label label1;
    }
}