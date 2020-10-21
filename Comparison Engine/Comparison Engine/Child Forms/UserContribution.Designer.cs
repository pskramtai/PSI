namespace Comparison_Engine.Child_Forms
{
    partial class UserContribution
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxBarAdress = new System.Windows.Forms.TextBox();
            this.textBoxBarName = new System.Windows.Forms.TextBox();
            this.textBoxPrice2 = new System.Windows.Forms.TextBox();
            this.textBoxDrink = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.comboBoxBar2 = new System.Windows.Forms.ComboBox();
            this.comboBoxDrink = new System.Windows.Forms.ComboBox();
            this.comboBoxBar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonEditPrice = new System.Windows.Forms.Button();
            this.buttonAddDrink = new System.Windows.Forms.Button();
            this.buttonAddBar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxBarAdress);
            this.panel1.Controls.Add(this.textBoxBarName);
            this.panel1.Controls.Add(this.textBoxPrice2);
            this.panel1.Controls.Add(this.textBoxDrink);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.comboBoxBar2);
            this.panel1.Controls.Add(this.comboBoxDrink);
            this.panel1.Controls.Add(this.comboBoxBar);
            this.panel1.Location = new System.Drawing.Point(22, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 350);
            this.panel1.TabIndex = 0;
            // 
            // textBoxBarAdress for entering new bar adress
            // 
            this.textBoxBarAdress.Location = new System.Drawing.Point(550, 132);
            this.textBoxBarAdress.Name = "textBox5";
            this.textBoxBarAdress.Size = new System.Drawing.Size(150, 31);
            this.textBoxBarAdress.TabIndex = 7;
            // 
            // textBoxBarName for entering new bar
            // 
            this.textBoxBarName.Location = new System.Drawing.Point(550, 32);
            this.textBoxBarName.Name = "textBox4";
            this.textBoxBarName.Size = new System.Drawing.Size(150, 31);
            this.textBoxBarName.TabIndex = 6;
            // 
            // textBoxPrice2 for entering price of new drink to add
            // 
            this.textBoxPrice2.Location = new System.Drawing.Point(300, 232);
            this.textBoxPrice2.Name = "textBox3";
            this.textBoxPrice2.Size = new System.Drawing.Size(150, 31);
            this.textBoxPrice2.TabIndex = 5;
            // 
            // textBoxDrink for entering the name of the dirnk to add drink
            // 
            this.textBoxDrink.Location = new System.Drawing.Point(300, 132);
            this.textBoxDrink.Name = "textBox2";
            this.textBoxDrink.Size = new System.Drawing.Size(150, 31);
            this.textBoxDrink.TabIndex = 4;
            // 
            // textBoxPrice for entering new price to edit
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(32, 232);
            this.textBoxPrice.Name = "textBox1";
            this.textBoxPrice.Size = new System.Drawing.Size(150, 31);
            this.textBoxPrice.TabIndex = 3;
            // 
            // comboBoxBar2 for adding drinks to chosen bar
            // 
            this.comboBoxBar2.FormattingEnabled = true;
            this.comboBoxBar2.Location = new System.Drawing.Point(300, 32);
            this.comboBoxBar2.Name = "comboBox3";
            this.comboBoxBar2.Size = new System.Drawing.Size(182, 33);
            this.comboBoxBar2.TabIndex = 2;
            // 
            // comboBoxDrink for choosing drink to edit price
            // 
            this.comboBoxDrink.FormattingEnabled = true;
            this.comboBoxDrink.Location = new System.Drawing.Point(32, 131);
            this.comboBoxDrink.Name = "comboBox2";
            this.comboBoxDrink.Size = new System.Drawing.Size(182, 33);
            this.comboBoxDrink.TabIndex = 1;
            // 
            // comboBoxBar for choosing bar to edit price
            // 
            this.comboBoxBar.FormattingEnabled = true;
            this.comboBoxBar.Location = new System.Drawing.Point(32, 31);
            this.comboBoxBar.Name = "comboBox1";
            this.comboBoxBar.Size = new System.Drawing.Size(182, 33);
            this.comboBoxBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Bar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose Drink";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Drink:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Choose Bar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(567, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Bar name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(570, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Bar Adress:";
            // 
            // buttonEditPrice
            // 
            this.buttonEditPrice.Location = new System.Drawing.Point(53, 330);
            this.buttonEditPrice.Name = "button1";
            this.buttonEditPrice.Size = new System.Drawing.Size(112, 34);
            this.buttonEditPrice.TabIndex = 9;
            this.buttonEditPrice.Text = "Edit price";
            this.buttonEditPrice.UseVisualStyleBackColor = true;
            this.buttonEditPrice.Click += new System.EventHandler(this.buttonEditPrice_Click);
            // 
            // buttonAddDrink
            // 
            this.buttonAddDrink.Location = new System.Drawing.Point(320, 330);
            this.buttonAddDrink.Name = "button2";
            this.buttonAddDrink.Size = new System.Drawing.Size(112, 34);
            this.buttonAddDrink.TabIndex = 10;
            this.buttonAddDrink.Text = "Add Drink";
            this.buttonAddDrink.UseVisualStyleBackColor = true;
            this.buttonAddDrink.Click += new System.EventHandler(this.buttonAddDrink_Click);
            // 
            // buttonAddBar
            // 
            this.buttonAddBar.Location = new System.Drawing.Point(570, 330);
            this.buttonAddBar.Name = "button3";
            this.buttonAddBar.Size = new System.Drawing.Size(112, 34);
            this.buttonAddBar.TabIndex = 11;
            this.buttonAddBar.Text = "Add Bar";
            this.buttonAddBar.UseVisualStyleBackColor = true;
            this.buttonAddBar.Click += new System.EventHandler(this.buttonAddBar_Click);
            // 
            // UserContribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddBar);
            this.Controls.Add(this.buttonAddDrink);
            this.Controls.Add(this.buttonEditPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UserContribution";
            this.Text = "UserContribution";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxBar2;
        private System.Windows.Forms.ComboBox comboBoxDrink;
        private System.Windows.Forms.ComboBox comboBoxBar;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDrink;
        private System.Windows.Forms.TextBox textBoxPrice2;
        private System.Windows.Forms.TextBox textBoxBarAdress;
        private System.Windows.Forms.TextBox textBoxBarName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonEditPrice;
        private System.Windows.Forms.Button buttonAddDrink;
        private System.Windows.Forms.Button buttonAddBar;
    }
}