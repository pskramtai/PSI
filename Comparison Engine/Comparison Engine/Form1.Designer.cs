namespace Comparison_Engine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSearch = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelList = new System.Windows.Forms.Panel();
            this.buttonBottom = new System.Windows.Forms.Button();
            this.panelSubList = new System.Windows.Forms.Panel();
            this.buttonTest3 = new System.Windows.Forms.Button();
            this.buttonTest2 = new System.Windows.Forms.Button();
            this.buttonTest1 = new System.Windows.Forms.Button();
            this.buttonTop = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.labelProfileName = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.panelSearch.SuspendLayout();
            this.panelList.SuspendLayout();
            this.panelSubList.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 57);
            this.panelSearch.MinimumSize = new System.Drawing.Size(250, 34);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(250, 34);
            this.panelSearch.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(12, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(171, 23);
            this.textBoxSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(189, 6);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(55, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(250, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(594, 521);
            this.panelMain.TabIndex = 1;
            // 
            // panelList
            // 
            this.panelList.AutoSize = true;
            this.panelList.BackColor = System.Drawing.Color.Lime;
            this.panelList.Controls.Add(this.buttonBottom);
            this.panelList.Controls.Add(this.panelSubList);
            this.panelList.Controls.Add(this.buttonTop);
            this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelList.Location = new System.Drawing.Point(0, 91);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(250, 430);
            this.panelList.TabIndex = 2;
            // 
            // buttonBottom
            // 
            this.buttonBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonBottom.Location = new System.Drawing.Point(0, 393);
            this.buttonBottom.Name = "buttonBottom";
            this.buttonBottom.Size = new System.Drawing.Size(250, 37);
            this.buttonBottom.TabIndex = 1;
            this.buttonBottom.Text = "buttonBottom";
            this.buttonBottom.UseVisualStyleBackColor = true;
            this.buttonBottom.Click += new System.EventHandler(this.buttonBottom_Click);
            // 
            // panelSubList
            // 
            this.panelSubList.AutoScroll = true;
            this.panelSubList.BackColor = System.Drawing.Color.Yellow;
            this.panelSubList.Controls.Add(this.buttonTest3);
            this.panelSubList.Controls.Add(this.buttonTest2);
            this.panelSubList.Controls.Add(this.buttonTest1);
            this.panelSubList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubList.Location = new System.Drawing.Point(0, 37);
            this.panelSubList.Name = "panelSubList";
            this.panelSubList.Size = new System.Drawing.Size(250, 393);
            this.panelSubList.TabIndex = 0;
            // 
            // buttonTest3
            // 
            this.buttonTest3.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTest3.Location = new System.Drawing.Point(0, 60);
            this.buttonTest3.Name = "buttonTest3";
            this.buttonTest3.Size = new System.Drawing.Size(250, 30);
            this.buttonTest3.TabIndex = 0;
            this.buttonTest3.Text = "buttonTest3";
            this.buttonTest3.UseVisualStyleBackColor = true;
            this.buttonTest3.Click += new System.EventHandler(this.buttonTest3_Click);
            // 
            // buttonTest2
            // 
            this.buttonTest2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTest2.Location = new System.Drawing.Point(0, 30);
            this.buttonTest2.Name = "buttonTest2";
            this.buttonTest2.Size = new System.Drawing.Size(250, 30);
            this.buttonTest2.TabIndex = 0;
            this.buttonTest2.Text = "buttonTest2";
            this.buttonTest2.UseVisualStyleBackColor = true;
            this.buttonTest2.Click += new System.EventHandler(this.buttonTest2_Click);
            // 
            // buttonTest1
            // 
            this.buttonTest1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTest1.Location = new System.Drawing.Point(0, 0);
            this.buttonTest1.Name = "buttonTest1";
            this.buttonTest1.Size = new System.Drawing.Size(250, 30);
            this.buttonTest1.TabIndex = 0;
            this.buttonTest1.Text = "buttonTest1";
            this.buttonTest1.UseVisualStyleBackColor = true;
            this.buttonTest1.Click += new System.EventHandler(this.buttonTest1_Click);
            // 
            // buttonTop
            // 
            this.buttonTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTop.Location = new System.Drawing.Point(0, 0);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(250, 37);
            this.buttonTop.TabIndex = 1;
            this.buttonTop.Text = "buttonTop";
            this.buttonTop.UseVisualStyleBackColor = true;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoSize = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.Fuchsia;
            this.panelSideMenu.Controls.Add(this.panelList);
            this.panelSideMenu.Controls.Add(this.panelSearch);
            this.panelSideMenu.Controls.Add(this.panelProfile);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.MinimumSize = new System.Drawing.Size(250, 521);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 521);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelProfile.Controls.Add(this.labelProfileName);
            this.panelProfile.Controls.Add(this.pictureBoxProfile);
            this.panelProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfile.Location = new System.Drawing.Point(0, 0);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(250, 57);
            this.panelProfile.TabIndex = 0;
            this.panelProfile.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProfile_Paint);
            // 
            // labelProfileName
            // 
            this.labelProfileName.AutoSize = true;
            this.labelProfileName.Location = new System.Drawing.Point(56, 26);
            this.labelProfileName.Name = "labelProfileName";
            this.labelProfileName.Size = new System.Drawing.Size(37, 15);
            this.labelProfileName.TabIndex = 1;
            this.labelProfileName.Text = "Guest";
            this.labelProfileName.UseMnemonic = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfile.Image")));
            this.pictureBoxProfile.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(38, 38);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            //
            // buttonEdit
            //
            this.buttonEdit.Location = new System.Drawing.Point(180, 22);
            this.buttonEdit.Name = "Edit";
            this.buttonEdit.Size = new System.Drawing.Size(66, 25);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 521);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(860, 560);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelList.ResumeLayout(false);
            this.panelSubList.ResumeLayout(false);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Label labelProfileName;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonBottom;
        private System.Windows.Forms.Button buttonTop;
        private System.Windows.Forms.Panel panelSubList;
        private System.Windows.Forms.Button buttonTest3;
        private System.Windows.Forms.Button buttonTest2;
        private System.Windows.Forms.Button buttonTest1;
        private System.Windows.Forms.Button buttonEdit;
    }
}

