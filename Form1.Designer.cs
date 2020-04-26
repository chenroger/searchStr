namespace searchStr
{
    partial class searchStr_home
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
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblQuery = new System.Windows.Forms.Label();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkRegex = new System.Windows.Forms.CheckBox();
            this.lblExtensions = new System.Windows.Forms.Label();
            this.txtExtensions = new System.Windows.Forms.TextBox();
            this.chkCase = new System.Windows.Forms.CheckBox();
            this.chkExact = new System.Windows.Forms.CheckBox();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(79, 6);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(293, 20);
            this.txtQuery.TabIndex = 0;
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(79, 58);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(293, 20);
            this.txtDirectory.TabIndex = 2;
            this.txtDirectory.Text = "C:\\";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(297, 137);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblQuery
            // 
            this.lblQuery.AutoSize = true;
            this.lblQuery.Location = new System.Drawing.Point(12, 9);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(49, 13);
            this.lblQuery.TabIndex = 3;
            this.lblQuery.Text = "Find this:";
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(12, 61);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(52, 13);
            this.lblDirectory.TabIndex = 4;
            this.lblDirectory.Text = "Directory:";
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.chkExact);
            this.grpOptions.Controls.Add(this.chkCase);
            this.grpOptions.Controls.Add(this.chkRegex);
            this.grpOptions.Location = new System.Drawing.Point(12, 84);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(360, 47);
            this.grpOptions.TabIndex = 6;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options:";
            // 
            // chkRegex
            // 
            this.chkRegex.AutoSize = true;
            this.chkRegex.Location = new System.Drawing.Point(6, 19);
            this.chkRegex.Name = "chkRegex";
            this.chkRegex.Size = new System.Drawing.Size(57, 17);
            this.chkRegex.TabIndex = 3;
            this.chkRegex.Text = "Regex";
            this.chkRegex.UseVisualStyleBackColor = true;
            // 
            // lblExtensions
            // 
            this.lblExtensions.AutoSize = true;
            this.lblExtensions.Location = new System.Drawing.Point(12, 35);
            this.lblExtensions.Name = "lblExtensions";
            this.lblExtensions.Size = new System.Drawing.Size(61, 13);
            this.lblExtensions.TabIndex = 7;
            this.lblExtensions.Text = "Extensions:";
            // 
            // txtExtensions
            // 
            this.txtExtensions.Location = new System.Drawing.Point(79, 32);
            this.txtExtensions.Name = "txtExtensions";
            this.txtExtensions.Size = new System.Drawing.Size(293, 20);
            this.txtExtensions.TabIndex = 1;
            this.txtExtensions.Text = "txt,bat,ps1";
            // 
            // chkCase
            // 
            this.chkCase.AutoSize = true;
            this.chkCase.Location = new System.Drawing.Point(127, 19);
            this.chkCase.Name = "chkCase";
            this.chkCase.Size = new System.Drawing.Size(96, 17);
            this.chkCase.TabIndex = 4;
            this.chkCase.Text = "Case Sensitive";
            this.chkCase.UseVisualStyleBackColor = true;
            // 
            // chkExact
            // 
            this.chkExact.AutoSize = true;
            this.chkExact.Location = new System.Drawing.Point(270, 19);
            this.chkExact.Name = "chkExact";
            this.chkExact.Size = new System.Drawing.Size(89, 17);
            this.chkExact.TabIndex = 5;
            this.chkExact.Text = "Exact Phrase";
            this.chkExact.UseVisualStyleBackColor = true;
            // 
            // searchStr_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 172);
            this.Controls.Add(this.txtExtensions);
            this.Controls.Add(this.lblExtensions);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.lblDirectory);
            this.Controls.Add(this.lblQuery);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.txtQuery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "searchStr_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchStr";
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblQuery;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chkExact;
        private System.Windows.Forms.CheckBox chkCase;
        private System.Windows.Forms.CheckBox chkRegex;
        private System.Windows.Forms.Label lblExtensions;
        private System.Windows.Forms.TextBox txtExtensions;
    }
}

