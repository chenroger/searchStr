namespace searchStr
{
    partial class searchStr_result
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchStr_result));
            this.spltResult = new System.Windows.Forms.SplitContainer();
            this.trvResult = new System.Windows.Forms.TreeView();
            this.spltFile = new System.Windows.Forms.SplitContainer();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.imgIcons = new System.Windows.Forms.ImageList(this.components);
            this.txtFilename = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.spltResult)).BeginInit();
            this.spltResult.Panel1.SuspendLayout();
            this.spltResult.Panel2.SuspendLayout();
            this.spltResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltFile)).BeginInit();
            this.spltFile.Panel1.SuspendLayout();
            this.spltFile.Panel2.SuspendLayout();
            this.spltFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // spltResult
            // 
            this.spltResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spltResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltResult.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spltResult.Location = new System.Drawing.Point(0, 0);
            this.spltResult.Name = "spltResult";
            // 
            // spltResult.Panel1
            // 
            this.spltResult.Panel1.Controls.Add(this.trvResult);
            // 
            // spltResult.Panel2
            // 
            this.spltResult.Panel2.Controls.Add(this.spltFile);
            this.spltResult.Size = new System.Drawing.Size(784, 561);
            this.spltResult.SplitterDistance = 261;
            this.spltResult.TabIndex = 1;
            // 
            // trvResult
            // 
            this.trvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvResult.Location = new System.Drawing.Point(0, 0);
            this.trvResult.Name = "trvResult";
            this.trvResult.Size = new System.Drawing.Size(257, 557);
            this.trvResult.TabIndex = 0;
            this.trvResult.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.trvResult_AfterExpand);
            this.trvResult.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvResult_NodeMouseClick);
            // 
            // spltFile
            // 
            this.spltFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltFile.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spltFile.Location = new System.Drawing.Point(0, 0);
            this.spltFile.Name = "spltFile";
            this.spltFile.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltFile.Panel1
            // 
            this.spltFile.Panel1.Controls.Add(this.txtFilename);
            // 
            // spltFile.Panel2
            // 
            this.spltFile.Panel2.Controls.Add(this.txtFile);
            this.spltFile.Size = new System.Drawing.Size(515, 557);
            this.spltFile.SplitterDistance = 25;
            this.spltFile.TabIndex = 0;
            // 
            // txtFile
            // 
            this.txtFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFile.Location = new System.Drawing.Point(0, 0);
            this.txtFile.Multiline = true;
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFile.Size = new System.Drawing.Size(515, 528);
            this.txtFile.TabIndex = 1;
            // 
            // imgIcons
            // 
            this.imgIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcons.ImageStream")));
            this.imgIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcons.Images.SetKeyName(0, "FolderClosed_16x.png");
            this.imgIcons.Images.SetKeyName(1, "TextFile_16x.png");
            // 
            // txtFilename
            // 
            this.txtFilename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilename.Location = new System.Drawing.Point(0, 0);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(515, 20);
            this.txtFilename.TabIndex = 2;
            // 
            // searchStr_result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.spltResult);
            this.Name = "searchStr_result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchStr";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.searchStr_result_FormClosed);
            this.spltResult.Panel1.ResumeLayout(false);
            this.spltResult.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltResult)).EndInit();
            this.spltResult.ResumeLayout(false);
            this.spltFile.Panel1.ResumeLayout(false);
            this.spltFile.Panel1.PerformLayout();
            this.spltFile.Panel2.ResumeLayout(false);
            this.spltFile.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltFile)).EndInit();
            this.spltFile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer spltResult;
        private System.Windows.Forms.TreeView trvResult;
        private System.Windows.Forms.SplitContainer spltFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.ImageList imgIcons;
        private System.Windows.Forms.TextBox txtFilename;
    }
}