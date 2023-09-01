namespace Drinks
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
            labelAlcohol = new Label();
            labelLiquor = new Label();
            labelFruitGreen = new Label();
            buttonGetDrinks = new Button();
            labelExtras = new Label();
            labelJuice = new Label();
            labelSoftdrink = new Label();
            labelSyrup = new Label();
            buttonReset = new Button();
            listAlcohol = new CheckedListBox();
            listLiquor = new CheckedListBox();
            listSyrup = new CheckedListBox();
            listSoft_Drink = new CheckedListBox();
            listJuice = new CheckedListBox();
            listFruit_Green = new CheckedListBox();
            listExtras = new CheckedListBox();
            label1 = new Label();
            listIceCubes = new CheckedListBox();
            SuspendLayout();
            // 
            // labelAlcohol
            // 
            labelAlcohol.AutoSize = true;
            labelAlcohol.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelAlcohol.Location = new Point(12, 14);
            labelAlcohol.Name = "labelAlcohol";
            labelAlcohol.Size = new Size(93, 29);
            labelAlcohol.TabIndex = 1;
            labelAlcohol.Text = "Alcohol";
            // 
            // labelLiquor
            // 
            labelLiquor.AutoSize = true;
            labelLiquor.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelLiquor.Location = new Point(178, 14);
            labelLiquor.Name = "labelLiquor";
            labelLiquor.Size = new Size(81, 29);
            labelLiquor.TabIndex = 14;
            labelLiquor.Text = "Liquor";
            // 
            // labelFruitGreen
            // 
            labelFruitGreen.AutoSize = true;
            labelFruitGreen.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelFruitGreen.Location = new Point(908, 14);
            labelFruitGreen.Name = "labelFruitGreen";
            labelFruitGreen.Size = new Size(135, 29);
            labelFruitGreen.TabIndex = 66;
            labelFruitGreen.Text = "Fruit/Green";
            // 
            // buttonGetDrinks
            // 
            buttonGetDrinks.AutoSize = true;
            buttonGetDrinks.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGetDrinks.Location = new Point(568, 466);
            buttonGetDrinks.Name = "buttonGetDrinks";
            buttonGetDrinks.Size = new Size(154, 50);
            buttonGetDrinks.TabIndex = 96;
            buttonGetDrinks.Text = "Get Drinks";
            buttonGetDrinks.UseVisualStyleBackColor = true;
            buttonGetDrinks.Click += buttonGetDrinks_Click_1;
            // 
            // labelExtras
            // 
            labelExtras.AutoSize = true;
            labelExtras.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelExtras.Location = new Point(1108, 14);
            labelExtras.Name = "labelExtras";
            labelExtras.Size = new Size(79, 29);
            labelExtras.TabIndex = 97;
            labelExtras.Text = "Extras";
            // 
            // labelJuice
            // 
            labelJuice.AutoSize = true;
            labelJuice.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelJuice.Location = new Point(730, 14);
            labelJuice.Name = "labelJuice";
            labelJuice.Size = new Size(70, 29);
            labelJuice.TabIndex = 100;
            labelJuice.Text = "Juice";
            // 
            // labelSoftdrink
            // 
            labelSoftdrink.AutoSize = true;
            labelSoftdrink.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSoftdrink.Location = new Point(530, 14);
            labelSoftdrink.Name = "labelSoftdrink";
            labelSoftdrink.Size = new Size(108, 29);
            labelSoftdrink.TabIndex = 101;
            labelSoftdrink.Text = "Softdrink";
            // 
            // labelSyrup
            // 
            labelSyrup.AutoSize = true;
            labelSyrup.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelSyrup.Location = new Point(357, 14);
            labelSyrup.Name = "labelSyrup";
            labelSyrup.Size = new Size(75, 29);
            labelSyrup.TabIndex = 107;
            labelSyrup.Text = "Syrup";
            // 
            // buttonReset
            // 
            buttonReset.AutoSize = true;
            buttonReset.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReset.Location = new Point(12, 466);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(154, 50);
            buttonReset.TabIndex = 113;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // listAlcohol
            // 
            listAlcohol.AccessibleName = "listAlcohol";
            listAlcohol.FormattingEnabled = true;
            listAlcohol.Location = new Point(12, 51);
            listAlcohol.Name = "listAlcohol";
            listAlcohol.Size = new Size(140, 334);
            listAlcohol.TabIndex = 114;
            // 
            // listLiquor
            // 
            listLiquor.FormattingEnabled = true;
            listLiquor.Location = new Point(178, 51);
            listLiquor.Name = "listLiquor";
            listLiquor.Size = new Size(136, 334);
            listLiquor.TabIndex = 115;
            // 
            // listSyrup
            // 
            listSyrup.FormattingEnabled = true;
            listSyrup.Location = new Point(357, 51);
            listSyrup.Name = "listSyrup";
            listSyrup.Size = new Size(125, 334);
            listSyrup.TabIndex = 116;
            // 
            // listSoft_Drink
            // 
            listSoft_Drink.FormattingEnabled = true;
            listSoft_Drink.Location = new Point(530, 51);
            listSoft_Drink.Name = "listSoft_Drink";
            listSoft_Drink.Size = new Size(162, 334);
            listSoft_Drink.TabIndex = 117;
            // 
            // listJuice
            // 
            listJuice.FormattingEnabled = true;
            listJuice.Location = new Point(730, 51);
            listJuice.Name = "listJuice";
            listJuice.Size = new Size(149, 334);
            listJuice.TabIndex = 118;
            // 
            // listFruit_Green
            // 
            listFruit_Green.FormattingEnabled = true;
            listFruit_Green.Location = new Point(908, 51);
            listFruit_Green.Name = "listFruit_Green";
            listFruit_Green.Size = new Size(160, 334);
            listFruit_Green.TabIndex = 119;
            // 
            // listExtras
            // 
            listExtras.FormattingEnabled = true;
            listExtras.Location = new Point(1108, 51);
            listExtras.Name = "listExtras";
            listExtras.Size = new Size(136, 158);
            listExtras.TabIndex = 120;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1108, 244);
            label1.Name = "label1";
            label1.Size = new Size(115, 29);
            label1.TabIndex = 121;
            label1.Text = "IceCubes";
            // 
            // listIceCubes
            // 
            listIceCubes.FormattingEnabled = true;
            listIceCubes.Location = new Point(1108, 293);
            listIceCubes.Name = "listIceCubes";
            listIceCubes.Size = new Size(158, 92);
            listIceCubes.TabIndex = 122;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 528);
            Controls.Add(listIceCubes);
            Controls.Add(label1);
            Controls.Add(listExtras);
            Controls.Add(listFruit_Green);
            Controls.Add(listJuice);
            Controls.Add(listSoft_Drink);
            Controls.Add(listSyrup);
            Controls.Add(listLiquor);
            Controls.Add(listAlcohol);
            Controls.Add(buttonReset);
            Controls.Add(labelSyrup);
            Controls.Add(labelSoftdrink);
            Controls.Add(labelJuice);
            Controls.Add(labelExtras);
            Controls.Add(buttonGetDrinks);
            Controls.Add(labelFruitGreen);
            Controls.Add(labelLiquor);
            Controls.Add(labelAlcohol);
            Name = "Form1";
            Text = "Drinks";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelAlcohol;
        private Label labelLiquor;
        private Label labelFruitGreen;
        private Label labelSyrup;
        private Button buttonGetDrinks;
        private Label labelExtras;
        private Label labelJuice;
        private Label labelSoftdrink;
        private Button buttonReset;
        private CheckedListBox listAlcohol;
        private CheckedListBox listLiquor;
        private CheckedListBox listSyrup;
        private CheckedListBox listSoft_Drink;
        private CheckedListBox listJuice;
        private CheckedListBox listFruit_Green;
        private CheckedListBox listExtras;
        private Label label1;
        private CheckedListBox listIceCubes;
    }
}