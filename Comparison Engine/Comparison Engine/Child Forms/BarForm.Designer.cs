namespace Comparison_Engine.Forms
{
    partial class BarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarForm));
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxBarIcon = new System.Windows.Forms.PictureBox();
            this.labelBarName = new System.Windows.Forms.Label();
            this.listViewDrinks = new System.Windows.Forms.ListView();
            this.columnHeaderDrinkName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDrinkPrice = new System.Windows.Forms.ColumnHeader();
            this.labelBarLocation = new System.Windows.Forms.Label();
            this.buttonShowOnMap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(540, 15);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(36, 36);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // pictureBoxBarIcon
            // 
            this.pictureBoxBarIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBarIcon.Image")));
            this.pictureBoxBarIcon.Location = new System.Drawing.Point(39, 39);
            this.pictureBoxBarIcon.Name = "pictureBoxBarIcon";
            this.pictureBoxBarIcon.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxBarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBarIcon.TabIndex = 1;
            this.pictureBoxBarIcon.TabStop = false;
            // 
            // labelBarName
            // 
            this.labelBarName.AutoSize = true;
            this.labelBarName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBarName.Location = new System.Drawing.Point(180, 39);
            this.labelBarName.Name = "labelBarName";
            this.labelBarName.Size = new System.Drawing.Size(218, 45);
            this.labelBarName.TabIndex = 2;
            this.labelBarName.Text = "labelBarName";
            // 
            // listViewDrinks
            // 
            this.listViewDrinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDrinkName,
            this.columnHeaderDrinkPrice});
            this.listViewDrinks.GridLines = true;
            this.listViewDrinks.HideSelection = false;
            this.listViewDrinks.Location = new System.Drawing.Point(39, 165);
            this.listViewDrinks.MultiSelect = false;
            this.listViewDrinks.Name = "listViewDrinks";
            this.listViewDrinks.Size = new System.Drawing.Size(400, 344);
            this.listViewDrinks.TabIndex = 3;
            this.listViewDrinks.UseCompatibleStateImageBehavior = false;
            this.listViewDrinks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderDrinkName
            // 
            this.columnHeaderDrinkName.Text = "Drink";
            this.columnHeaderDrinkName.Width = 300;
            // 
            // columnHeaderDrinkPrice
            // 
            this.columnHeaderDrinkPrice.Text = "Price";
            this.columnHeaderDrinkPrice.Width = 100;
            // 
            // labelBarLocation
            // 
            this.labelBarLocation.AutoSize = true;
            this.labelBarLocation.Location = new System.Drawing.Point(180, 100);
            this.labelBarLocation.Name = "labelBarLocation";
            this.labelBarLocation.Size = new System.Drawing.Size(95, 15);
            this.labelBarLocation.TabIndex = 4;
            this.labelBarLocation.Text = "labelBarLocation";
            this.labelBarLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBarLocation.UseMnemonic = false;
            // 
            // buttonShowOnMap
            // 
            this.buttonShowOnMap.Location = new System.Drawing.Point(180, 118);
            this.buttonShowOnMap.Name = "buttonShowOnMap";
            this.buttonShowOnMap.Size = new System.Drawing.Size(134, 23);
            this.buttonShowOnMap.TabIndex = 5;
            this.buttonShowOnMap.Text = "Show Route On Map";
            this.buttonShowOnMap.UseVisualStyleBackColor = true;
            this.buttonShowOnMap.Click += new System.EventHandler(this.ButtonShowOnMap_Click);
            // 
            // BarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(594, 521);
            this.Controls.Add(this.buttonShowOnMap);
            this.Controls.Add(this.labelBarLocation);
            this.Controls.Add(this.listViewDrinks);
            this.Controls.Add(this.labelBarName);
            this.Controls.Add(this.pictureBoxBarIcon);
            this.Controls.Add(this.buttonExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BarForm";
            this.Text = "BarForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBoxBarIcon;
        private System.Windows.Forms.Label labelBarName;
        private System.Windows.Forms.ListView listViewDrinks;
        private System.Windows.Forms.Label labelBarLocation;
        private System.Windows.Forms.ColumnHeader columnHeaderDrinkName;
        private System.Windows.Forms.ColumnHeader columnHeaderDrinkPrice;
        private System.Windows.Forms.Button buttonShowOnMap;
    }
}