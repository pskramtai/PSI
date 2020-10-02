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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonBottom = new System.Windows.Forms.Button();
            this.panelList = new System.Windows.Forms.Panel();
            this.buttonTop = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(121)))));
            this.panelSideMenu.Controls.Add(this.buttonSearch);
            this.panelSideMenu.Controls.Add(this.textBoxSearch);
            this.panelSideMenu.Controls.Add(this.buttonBottom);
            this.panelSideMenu.Controls.Add(this.panelList);
            this.panelSideMenu.Controls.Add(this.buttonTop);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 521);
            this.panelSideMenu.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(189)))), ((int)(((byte)(107)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(196, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(54, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(0, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(198, 23);
            this.textBoxSearch.TabIndex = 2;
            // 
            // buttonBottom
            // 
            this.buttonBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(252)))), ((int)(((byte)(155)))));
            this.buttonBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonBottom.FlatAppearance.BorderSize = 0;
            this.buttonBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBottom.Location = new System.Drawing.Point(0, 483);
            this.buttonBottom.Name = "buttonBottom";
            this.buttonBottom.Size = new System.Drawing.Size(250, 38);
            this.buttonBottom.TabIndex = 0;
            this.buttonBottom.Text = "Drinks";
            this.buttonBottom.UseVisualStyleBackColor = false;
            this.buttonBottom.Click += new System.EventHandler(this.buttonBottom_Click);
            // 
            // panelList
            // 
            this.panelList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelList.AutoScroll = true;
            this.panelList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(250)))), ((int)(((byte)(182)))));
            this.panelList.Location = new System.Drawing.Point(0, 75);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(250, 408);
            this.panelList.TabIndex = 1;
            // 
            // buttonTop
            // 
            this.buttonTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(189)))), ((int)(((byte)(107)))));
            this.buttonTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTop.FlatAppearance.BorderSize = 0;
            this.buttonTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTop.Location = new System.Drawing.Point(0, 41);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(250, 38);
            this.buttonTop.TabIndex = 0;
            this.buttonTop.Text = "Bars";
            this.buttonTop.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(121)))));
            this.panelMain.Location = new System.Drawing.Point(250, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(594, 521);
            this.panelMain.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 521);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(860, 560);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Button buttonTop;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonBottom;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
    }
}

