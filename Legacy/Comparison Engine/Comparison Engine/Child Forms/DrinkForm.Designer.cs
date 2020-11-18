namespace Comparison_Engine.Forms
{
    partial class DrinkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinkForm));
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBoxDrinkIcon = new System.Windows.Forms.PictureBox();
            this.labelDrinkName = new System.Windows.Forms.Label();
            this.listViewBars = new System.Windows.Forms.ListView();
            this.columnHeaderBarName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDrinkPrice = new System.Windows.Forms.ColumnHeader();
            this.buttonShowOnMap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrinkIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(540, 15);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(36, 36);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // pictureBoxDrinkIcon
            // 
            this.pictureBoxDrinkIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDrinkIcon.Image")));
            this.pictureBoxDrinkIcon.Location = new System.Drawing.Point(39, 39);
            this.pictureBoxDrinkIcon.Name = "pictureBoxDrinkIcon";
            this.pictureBoxDrinkIcon.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxDrinkIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDrinkIcon.TabIndex = 1;
            this.pictureBoxDrinkIcon.TabStop = false;
            // 
            // labelDrinkName
            // 
            this.labelDrinkName.AutoSize = true;
            this.labelDrinkName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDrinkName.Location = new System.Drawing.Point(180, 39);
            this.labelDrinkName.Name = "labelDrinkName";
            this.labelDrinkName.Size = new System.Drawing.Size(248, 45);
            this.labelDrinkName.TabIndex = 2;
            this.labelDrinkName.Text = "labelDrinkName";
            // 
            // listViewBars
            // 
            this.listViewBars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderBarName,
            this.columnHeaderDrinkPrice});
            this.listViewBars.GridLines = true;
            this.listViewBars.HideSelection = false;
            this.listViewBars.Location = new System.Drawing.Point(39, 165);
            this.listViewBars.MultiSelect = false;
            this.listViewBars.Name = "listViewBars";
            this.listViewBars.Size = new System.Drawing.Size(400, 344);
            this.listViewBars.TabIndex = 3;
            this.listViewBars.UseCompatibleStateImageBehavior = false;
            this.listViewBars.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderBarName
            // 
            this.columnHeaderBarName.Text = "Bar Name";
            this.columnHeaderBarName.Width = 300;
            // 
            // columnHeaderDrinkPrice
            // 
            this.columnHeaderDrinkPrice.Text = "Price";
            this.columnHeaderDrinkPrice.Width = 100;
            // 
            // buttonShowOnMap
            // 
            this.buttonShowOnMap.Location = new System.Drawing.Point(180, 136);
            this.buttonShowOnMap.Name = "buttonShowOnMap";
            this.buttonShowOnMap.Size = new System.Drawing.Size(98, 23);
            this.buttonShowOnMap.TabIndex = 4;
            this.buttonShowOnMap.Text = "Show On Map";
            this.buttonShowOnMap.UseVisualStyleBackColor = true;
            this.buttonShowOnMap.Click += new System.EventHandler(this.ButtonShowOnMap_Click);
            // 
            // DrinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(594, 521);
            this.Controls.Add(this.buttonShowOnMap);
            this.Controls.Add(this.listViewBars);
            this.Controls.Add(this.labelDrinkName);
            this.Controls.Add(this.pictureBoxDrinkIcon);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DrinkForm";
            this.Text = "DrinkForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrinkIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBoxDrinkIcon;
        private System.Windows.Forms.Label labelDrinkName;
        private System.Windows.Forms.ListView listViewBars;
        private System.Windows.Forms.ColumnHeader columnHeaderBarName;
        private System.Windows.Forms.ColumnHeader columnHeaderDrinkPrice;
        private System.Windows.Forms.Button buttonShowOnMap;
    }
}