namespace SALES_OF_THE_CENTURY_PTY_LTD
{
    partial class Selection
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
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.labelT = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(14, 53);
            this.checkedListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(305, 208);
            this.checkedListBox.TabIndex = 0;
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Location = new System.Drawing.Point(15, 16);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(77, 16);
            this.labelT.TabIndex = 1;
            this.labelT.Text = "Select Team";
            // 
            // select
            // 
            this.select.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.select.Location = new System.Drawing.Point(88, 268);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(75, 42);
            this.select.TabIndex = 2;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(181, 268);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 42);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(331, 322);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.select);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.checkedListBox);
            this.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Selection";
            this.Text = "Selection";
            this.Load += new System.EventHandler(this.Selection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button cancel;

    }
}