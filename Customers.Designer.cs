namespace MarriageHallManagement
{
    partial class Customers
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            CustPhoneTb = new TextBox();
            label4 = new Label();
            CustAddTb = new TextBox();
            label2 = new Label();
            CustNameTb = new TextBox();
            label1 = new Label();
            label5 = new Label();
            CustomerDGV = new DataGridView();
            panel1 = new Panel();
            label3 = new Label();
            button5 = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)CustomerDGV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            button4.ForeColor = Color.Brown;
            button4.Location = new Point(680, 142);
            button4.Name = "button4";
            button4.Size = new Size(116, 43);
            button4.TabIndex = 25;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            button3.ForeColor = Color.Brown;
            button3.Location = new Point(478, 142);
            button3.Name = "button3";
            button3.Size = new Size(116, 43);
            button3.TabIndex = 24;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            button2.ForeColor = Color.Brown;
            button2.Location = new Point(266, 146);
            button2.Name = "button2";
            button2.Size = new Size(116, 39);
            button2.TabIndex = 23;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            button1.ForeColor = Color.Brown;
            button1.Location = new Point(100, 144);
            button1.Name = "button1";
            button1.Size = new Size(116, 39);
            button1.TabIndex = 22;
            button1.Text = "Add Customer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CustPhoneTb
            // 
            CustPhoneTb.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            CustPhoneTb.ForeColor = Color.Brown;
            CustPhoneTb.Location = new Point(734, 72);
            CustPhoneTb.Name = "CustPhoneTb";
            CustPhoneTb.Size = new Size(126, 35);
            CustPhoneTb.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(636, 75);
            label4.Name = "label4";
            label4.Size = new Size(92, 27);
            label4.TabIndex = 20;
            label4.Text = "Phone";
            // 
            // CustAddTb
            // 
            CustAddTb.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            CustAddTb.ForeColor = Color.Brown;
            CustAddTb.Location = new Point(447, 72);
            CustAddTb.Name = "CustAddTb";
            CustAddTb.Size = new Size(126, 35);
            CustAddTb.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(342, 75);
            label2.Name = "label2";
            label2.Size = new Size(102, 27);
            label2.TabIndex = 16;
            label2.Text = "Adress";
            // 
            // CustNameTb
            // 
            CustNameTb.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            CustNameTb.ForeColor = Color.Brown;
            CustNameTb.Location = new Point(155, 72);
            CustNameTb.Name = "CustNameTb";
            CustNameTb.Size = new Size(126, 35);
            CustNameTb.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(73, 75);
            label1.Name = "label1";
            label1.Size = new Size(76, 27);
            label1.TabIndex = 14;
            label1.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(383, 208);
            label5.Name = "label5";
            label5.Size = new Size(211, 27);
            label5.TabIndex = 26;
            label5.Text = "Customers List";
            // 
            // CustomerDGV
            // 
            CustomerDGV.AllowUserToOrderColumns = true;
            CustomerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDGV.Location = new Point(219, 239);
            CustomerDGV.MultiSelect = false;
            CustomerDGV.Name = "CustomerDGV";
            CustomerDGV.RowHeadersWidth = 51;
            CustomerDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerDGV.Size = new Size(547, 330);
            CustomerDGV.TabIndex = 27;
            CustomerDGV.CellContentClick += CustomerDGV_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(962, 60);
            panel1.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(337, 40);
            label3.TabIndex = 0;
            label3.Text = "Vigos Restaurant";
            // 
            // button5
            // 
            button5.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Brown;
            button5.Location = new Point(856, 539);
            button5.Name = "button5";
            button5.Size = new Size(104, 40);
            button5.TabIndex = 29;
            button5.Text = "Staff";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Brown;
            label6.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(925, 9);
            label6.Name = "label6";
            label6.Size = new Size(33, 35);
            label6.TabIndex = 30;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(972, 581);
            Controls.Add(button5);
            Controls.Add(panel1);
            Controls.Add(CustomerDGV);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CustPhoneTb);
            Controls.Add(label4);
            Controls.Add(CustAddTb);
            Controls.Add(label2);
            Controls.Add(CustNameTb);
            Controls.Add(label1);
            Name = "Customers";
            Text = "Customers";
            Load += Customers_Load;
            ((System.ComponentModel.ISupportInitialize)CustomerDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox CustPhoneTb;
        private Label label4;
        private TextBox CustAddTb;
        private Label label2;
        private TextBox CustNameTb;
        private Label label1;
        private Label label5;
        private DataGridView CustomerDGV;
        private Panel panel1;
        private Label label3;
        private Button button5;
        private Label label6;
    }
}