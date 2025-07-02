namespace MarriageHallManagement
{
    partial class Booking
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            PplTb = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            BevCost = new Button();
            BevCostLbl = new Label();
            WaterQty = new TextBox();
            WaterPrice = new TextBox();
            WineQty = new TextBox();
            WinePrice = new TextBox();
            SodaQty = new TextBox();
            SodaPrice = new TextBox();
            BeerQty = new TextBox();
            BeerPrice = new TextBox();
            label5 = new Label();
            label4 = new Label();
            WaterCheck = new CheckBox();
            WineCheck = new CheckBox();
            SodaCheck = new CheckBox();
            checkBox1 = new CheckBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            FoodCostLbl = new Label();
            LambQty = new TextBox();
            LambPrice = new TextBox();
            MuttonQty = new TextBox();
            MuttonPrice = new TextBox();
            PastaQty = new TextBox();
            PastaPrice = new TextBox();
            FriesQty = new TextBox();
            FriesPrice = new TextBox();
            label8 = new Label();
            label9 = new Label();
            LambCheck = new CheckBox();
            MuttonCheck = new CheckBox();
            PastaCheck = new CheckBox();
            FriesCheck = new CheckBox();
            groupBox3 = new GroupBox();
            button4 = new Button();
            textBox18 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Stencil", 13.8F);
            dateTimePicker1.Location = new Point(135, 63);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 35);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 13.8F);
            label1.Location = new Point(51, 65);
            label1.Name = "label1";
            label1.Size = new Size(68, 27);
            label1.TabIndex = 1;
            label1.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 13.8F);
            label2.Location = new Point(398, 67);
            label2.Name = "label2";
            label2.Size = new Size(66, 27);
            label2.TabIndex = 3;
            label2.Text = "Time";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Stencil", 13.8F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Day", "Night" });
            comboBox1.Location = new Point(486, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 35);
            comboBox1.TabIndex = 4;
            // 
            // PplTb
            // 
            PplTb.Font = new Font("Stencil", 13.8F);
            PplTb.Location = new Point(764, 64);
            PplTb.Name = "PplTb";
            PplTb.Size = new Size(83, 35);
            PplTb.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 13.8F);
            label3.Location = new Point(663, 69);
            label3.Name = "label3";
            label3.Size = new Size(95, 27);
            label3.TabIndex = 6;
            label3.Text = "People";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BevCost);
            groupBox1.Controls.Add(BevCostLbl);
            groupBox1.Controls.Add(WaterQty);
            groupBox1.Controls.Add(WaterPrice);
            groupBox1.Controls.Add(WineQty);
            groupBox1.Controls.Add(WinePrice);
            groupBox1.Controls.Add(SodaQty);
            groupBox1.Controls.Add(SodaPrice);
            groupBox1.Controls.Add(BeerQty);
            groupBox1.Controls.Add(BeerPrice);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(WaterCheck);
            groupBox1.Controls.Add(WineCheck);
            groupBox1.Controls.Add(SodaCheck);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Font = new Font("Stencil", 13.8F);
            groupBox1.Location = new Point(47, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(341, 338);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Beverages";
            // 
            // BevCost
            // 
            BevCost.Location = new Point(23, 283);
            BevCost.Name = "BevCost";
            BevCost.Size = new Size(117, 35);
            BevCost.TabIndex = 18;
            BevCost.Text = "BevCost";
            BevCost.UseVisualStyleBackColor = true;
            BevCost.Click += BevCost_Click;
            // 
            // BevCostLbl
            // 
            BevCostLbl.AutoSize = true;
            BevCostLbl.Location = new Point(156, 287);
            BevCostLbl.Name = "BevCostLbl";
            BevCostLbl.Size = new Size(158, 27);
            BevCostLbl.TabIndex = 8;
            BevCostLbl.Text = "Drinks cost";
            // 
            // WaterQty
            // 
            WaterQty.Enabled = false;
            WaterQty.Location = new Point(261, 195);
            WaterQty.Name = "WaterQty";
            WaterQty.Size = new Size(53, 35);
            WaterQty.TabIndex = 17;
            WaterQty.Text = "0";
            // 
            // WaterPrice
            // 
            WaterPrice.Enabled = false;
            WaterPrice.Location = new Point(151, 195);
            WaterPrice.Name = "WaterPrice";
            WaterPrice.Size = new Size(53, 35);
            WaterPrice.TabIndex = 16;
            WaterPrice.Text = "0";
            // 
            // WineQty
            // 
            WineQty.Enabled = false;
            WineQty.Location = new Point(261, 139);
            WineQty.Name = "WineQty";
            WineQty.Size = new Size(53, 35);
            WineQty.TabIndex = 15;
            WineQty.Text = "0";
            // 
            // WinePrice
            // 
            WinePrice.Enabled = false;
            WinePrice.Location = new Point(149, 139);
            WinePrice.Name = "WinePrice";
            WinePrice.Size = new Size(53, 35);
            WinePrice.TabIndex = 14;
            WinePrice.Text = "0";
            // 
            // SodaQty
            // 
            SodaQty.Enabled = false;
            SodaQty.Location = new Point(261, 91);
            SodaQty.Name = "SodaQty";
            SodaQty.Size = new Size(53, 35);
            SodaQty.TabIndex = 13;
            SodaQty.Text = "0";
            // 
            // SodaPrice
            // 
            SodaPrice.Enabled = false;
            SodaPrice.Location = new Point(151, 91);
            SodaPrice.Name = "SodaPrice";
            SodaPrice.Size = new Size(53, 35);
            SodaPrice.TabIndex = 12;
            SodaPrice.Text = "0";
            // 
            // BeerQty
            // 
            BeerQty.Enabled = false;
            BeerQty.Location = new Point(261, 41);
            BeerQty.Name = "BeerQty";
            BeerQty.Size = new Size(53, 35);
            BeerQty.TabIndex = 11;
            BeerQty.Text = "0";
            // 
            // BeerPrice
            // 
            BeerPrice.Enabled = false;
            BeerPrice.Location = new Point(151, 41);
            BeerPrice.Name = "BeerPrice";
            BeerPrice.Size = new Size(53, 35);
            BeerPrice.TabIndex = 10;
            BeerPrice.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(238, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 27);
            label5.TabIndex = 9;
            label5.Text = "Quality";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 27);
            label4.TabIndex = 8;
            label4.Text = "Price";
            // 
            // WaterCheck
            // 
            WaterCheck.AutoSize = true;
            WaterCheck.Location = new Point(29, 195);
            WaterCheck.Name = "WaterCheck";
            WaterCheck.Size = new Size(110, 31);
            WaterCheck.TabIndex = 3;
            WaterCheck.Text = "Water";
            WaterCheck.UseVisualStyleBackColor = true;
            WaterCheck.CheckStateChanged += WaterCheck_CheckStateChanged;
            // 
            // WineCheck
            // 
            WineCheck.AutoSize = true;
            WineCheck.Location = new Point(29, 142);
            WineCheck.Name = "WineCheck";
            WineCheck.Size = new Size(90, 31);
            WineCheck.TabIndex = 2;
            WineCheck.Text = "Wine";
            WineCheck.UseVisualStyleBackColor = true;
            WineCheck.CheckStateChanged += WineCheck_CheckStateChanged;
            // 
            // SodaCheck
            // 
            SodaCheck.AutoSize = true;
            SodaCheck.Location = new Point(29, 94);
            SodaCheck.Name = "SodaCheck";
            SodaCheck.Size = new Size(91, 31);
            SodaCheck.TabIndex = 1;
            SodaCheck.Text = "Soda";
            SodaCheck.UseVisualStyleBackColor = true;
            SodaCheck.CheckStateChanged += SodaCheck_CheckStateChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(29, 41);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(91, 31);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Beer";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            checkBox1.CheckStateChanged += checkBox1_CheckStateChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(FoodCostLbl);
            groupBox2.Controls.Add(LambQty);
            groupBox2.Controls.Add(LambPrice);
            groupBox2.Controls.Add(MuttonQty);
            groupBox2.Controls.Add(MuttonPrice);
            groupBox2.Controls.Add(PastaQty);
            groupBox2.Controls.Add(PastaPrice);
            groupBox2.Controls.Add(FriesQty);
            groupBox2.Controls.Add(FriesPrice);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(LambCheck);
            groupBox2.Controls.Add(MuttonCheck);
            groupBox2.Controls.Add(PastaCheck);
            groupBox2.Controls.Add(FriesCheck);
            groupBox2.Font = new Font("Stencil", 13.8F);
            groupBox2.Location = new Point(486, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(341, 338);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dishes";
            // 
            // button3
            // 
            button3.Location = new Point(34, 289);
            button3.Name = "button3";
            button3.Size = new Size(99, 35);
            button3.TabIndex = 19;
            button3.Text = "Food";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FoodCostLbl
            // 
            FoodCostLbl.AutoSize = true;
            FoodCostLbl.Location = new Point(151, 293);
            FoodCostLbl.Name = "FoodCostLbl";
            FoodCostLbl.Size = new Size(125, 27);
            FoodCostLbl.TabIndex = 8;
            FoodCostLbl.Text = "FoodCost";
            // 
            // LambQty
            // 
            LambQty.Enabled = false;
            LambQty.Location = new Point(280, 193);
            LambQty.Name = "LambQty";
            LambQty.Size = new Size(53, 35);
            LambQty.TabIndex = 17;
            LambQty.Text = "0";
            // 
            // LambPrice
            // 
            LambPrice.Enabled = false;
            LambPrice.Location = new Point(170, 195);
            LambPrice.Name = "LambPrice";
            LambPrice.Size = new Size(53, 35);
            LambPrice.TabIndex = 16;
            LambPrice.Text = "0";
            // 
            // MuttonQty
            // 
            MuttonQty.Enabled = false;
            MuttonQty.Location = new Point(280, 142);
            MuttonQty.Name = "MuttonQty";
            MuttonQty.Size = new Size(53, 35);
            MuttonQty.TabIndex = 15;
            MuttonQty.Text = "0";
            // 
            // MuttonPrice
            // 
            MuttonPrice.Enabled = false;
            MuttonPrice.Location = new Point(170, 144);
            MuttonPrice.Name = "MuttonPrice";
            MuttonPrice.Size = new Size(50, 35);
            MuttonPrice.TabIndex = 14;
            MuttonPrice.Text = "0";
            // 
            // PastaQty
            // 
            PastaQty.Enabled = false;
            PastaQty.Location = new Point(280, 91);
            PastaQty.Name = "PastaQty";
            PastaQty.Size = new Size(53, 35);
            PastaQty.TabIndex = 13;
            PastaQty.Text = "0";
            // 
            // PastaPrice
            // 
            PastaPrice.Enabled = false;
            PastaPrice.Location = new Point(167, 94);
            PastaPrice.Name = "PastaPrice";
            PastaPrice.Size = new Size(53, 35);
            PastaPrice.TabIndex = 12;
            PastaPrice.Text = "0";
            // 
            // FriesQty
            // 
            FriesQty.Enabled = false;
            FriesQty.Location = new Point(280, 41);
            FriesQty.Name = "FriesQty";
            FriesQty.Size = new Size(53, 35);
            FriesQty.TabIndex = 11;
            FriesQty.Text = "0";
            // 
            // FriesPrice
            // 
            FriesPrice.Enabled = false;
            FriesPrice.Location = new Point(170, 41);
            FriesPrice.Name = "FriesPrice";
            FriesPrice.Size = new Size(53, 35);
            FriesPrice.TabIndex = 10;
            FriesPrice.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(244, 0);
            label8.Name = "label8";
            label8.Size = new Size(106, 27);
            label8.TabIndex = 9;
            label8.Text = "Quality";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(148, 0);
            label9.Name = "label9";
            label9.Size = new Size(78, 27);
            label9.TabIndex = 8;
            label9.Text = "Price";
            // 
            // LambCheck
            // 
            LambCheck.AutoSize = true;
            LambCheck.Location = new Point(32, 195);
            LambCheck.Name = "LambCheck";
            LambCheck.Size = new Size(93, 31);
            LambCheck.TabIndex = 3;
            LambCheck.Text = "Lamb";
            LambCheck.UseVisualStyleBackColor = true;
            LambCheck.CheckedChanged += LambCheck_CheckedChanged;
            LambCheck.CheckStateChanged += LambCheck_CheckStateChanged;
            // 
            // MuttonCheck
            // 
            MuttonCheck.AutoSize = true;
            MuttonCheck.Location = new Point(29, 144);
            MuttonCheck.Name = "MuttonCheck";
            MuttonCheck.Size = new Size(126, 31);
            MuttonCheck.TabIndex = 2;
            MuttonCheck.Text = "Mutton";
            MuttonCheck.UseVisualStyleBackColor = true;
            MuttonCheck.CheckStateChanged += MuttonCheck_CheckStateChanged;
            // 
            // PastaCheck
            // 
            PastaCheck.AutoSize = true;
            PastaCheck.Location = new Point(29, 94);
            PastaCheck.Name = "PastaCheck";
            PastaCheck.Size = new Size(104, 31);
            PastaCheck.TabIndex = 1;
            PastaCheck.Text = "Pasta";
            PastaCheck.UseVisualStyleBackColor = true;
            PastaCheck.CheckStateChanged += PastaCheck_CheckStateChanged;
            // 
            // FriesCheck
            // 
            FriesCheck.AutoSize = true;
            FriesCheck.Location = new Point(29, 41);
            FriesCheck.Name = "FriesCheck";
            FriesCheck.Size = new Size(98, 31);
            FriesCheck.TabIndex = 0;
            FriesCheck.Text = "Fries";
            FriesCheck.UseVisualStyleBackColor = true;
            FriesCheck.CheckStateChanged += FriesCheck_CheckStateChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(textBox18);
            groupBox3.Font = new Font("Stencil", 13.8F);
            groupBox3.Location = new Point(97, 488);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(419, 74);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Payments";
            // 
            // button4
            // 
            button4.Location = new Point(90, 36);
            button4.Name = "button4";
            button4.Size = new Size(113, 38);
            button4.TabIndex = 19;
            button4.Text = "Total";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox18
            // 
            textBox18.Location = new Point(212, 39);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(91, 35);
            textBox18.TabIndex = 18;
            textBox18.TextChanged += textBox18_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 13.8F);
            button1.Location = new Point(739, 488);
            button1.Name = "button1";
            button1.Size = new Size(108, 32);
            button1.TabIndex = 20;
            button1.Text = "Add Booking";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Stencil", 13.8F);
            button2.Location = new Point(739, 540);
            button2.Name = "button2";
            button2.Size = new Size(108, 32);
            button2.TabIndex = 21;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(4, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 60);
            panel1.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(15, 7);
            label6.Name = "label6";
            label6.Size = new Size(337, 40);
            label6.TabIndex = 0;
            label6.Text = "Vigos Restaurant";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Brown;
            label7.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(901, 7);
            label7.Name = "label7";
            label7.Size = new Size(33, 35);
            label7.TabIndex = 43;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(959, 579);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(PplTb);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "Booking";
            Text = "Booking";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox PplTb;
        private Label label3;
        private GroupBox groupBox1;
        private CheckBox WaterCheck;
        private CheckBox WineCheck;
        private CheckBox SodaCheck;
        private CheckBox checkBox1;
        private Label BevCostLbl;
        private TextBox WaterQty;
        private TextBox WaterPrice;
        private TextBox WineQty;
        private TextBox WinePrice;
        private TextBox SodaQty;
        private TextBox SodaPrice;
        private TextBox BeerQty;
        private TextBox BeerPrice;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private Label FoodCostLbl;
        private TextBox LambQty;
        private TextBox LambPrice;
        private TextBox MuttonQty;
        private TextBox MuttonPrice;
        private TextBox PastaQty;
        private TextBox PastaPrice;
        private TextBox FriesQty;
        private TextBox FriesPrice;
        private Label label8;
        private Label label9;
        private CheckBox LambCheck;
        private CheckBox MuttonCheck;
        private CheckBox PastaCheck;
        private CheckBox FriesCheck;
        private GroupBox groupBox3;
        private TextBox textBox18;
        private Button button1;
        private Button button2;
        private Button BevCost;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Label label6;
        private Label label7;
    }
}