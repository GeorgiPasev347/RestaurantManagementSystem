namespace MarriageHallManagement
{
    partial class Staff
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
            label5 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            StaffPassTb = new TextBox();
            label4 = new Label();
            StaffPhoneTb = new TextBox();
            label2 = new Label();
            StaffNameTb = new TextBox();
            label1 = new Label();
            StaffDGV = new DataGridView();
            panel1 = new Panel();
            label3 = new Label();
            button5 = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)StaffDGV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 13.8F);
            label5.ForeColor = Color.Brown;
            label5.Location = new Point(410, 211);
            label5.Name = "label5";
            label5.Size = new Size(133, 27);
            label5.TabIndex = 38;
            label5.Text = "Staff List";
            // 
            // button4
            // 
            button4.Font = new Font("Stencil", 13.8F);
            button4.ForeColor = Color.Brown;
            button4.Location = new Point(679, 154);
            button4.Name = "button4";
            button4.Size = new Size(129, 39);
            button4.TabIndex = 37;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Stencil", 13.8F);
            button3.ForeColor = Color.Brown;
            button3.Location = new Point(478, 154);
            button3.Name = "button3";
            button3.Size = new Size(129, 39);
            button3.TabIndex = 36;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Stencil", 13.8F);
            button2.ForeColor = Color.Brown;
            button2.Location = new Point(288, 154);
            button2.Name = "button2";
            button2.Size = new Size(129, 39);
            button2.TabIndex = 35;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 13.8F);
            button1.ForeColor = Color.Brown;
            button1.Location = new Point(101, 154);
            button1.Name = "button1";
            button1.Size = new Size(129, 39);
            button1.TabIndex = 34;
            button1.Text = "Add Staff";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // StaffPassTb
            // 
            StaffPassTb.Font = new Font("Stencil", 13.8F);
            StaffPassTb.ForeColor = Color.Brown;
            StaffPassTb.Location = new Point(735, 89);
            StaffPassTb.Name = "StaffPassTb";
            StaffPassTb.Size = new Size(126, 35);
            StaffPassTb.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 13.8F);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(597, 89);
            label4.Name = "label4";
            label4.Size = new Size(132, 27);
            label4.TabIndex = 32;
            label4.Text = "Password";
            // 
            // StaffPhoneTb
            // 
            StaffPhoneTb.Font = new Font("Stencil", 13.8F);
            StaffPhoneTb.ForeColor = Color.Brown;
            StaffPhoneTb.Location = new Point(404, 89);
            StaffPhoneTb.Name = "StaffPhoneTb";
            StaffPhoneTb.Size = new Size(126, 35);
            StaffPhoneTb.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 13.8F);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(311, 92);
            label2.Name = "label2";
            label2.Size = new Size(87, 27);
            label2.TabIndex = 30;
            label2.Text = "Phone";
            label2.Click += label2_Click;
            // 
            // StaffNameTb
            // 
            StaffNameTb.Font = new Font("Stencil", 13.8F);
            StaffNameTb.ForeColor = Color.Brown;
            StaffNameTb.Location = new Point(153, 92);
            StaffNameTb.Name = "StaffNameTb";
            StaffNameTb.Size = new Size(126, 35);
            StaffNameTb.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 13.8F);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(59, 95);
            label1.Name = "label1";
            label1.Size = new Size(72, 27);
            label1.TabIndex = 28;
            label1.Text = "Name";
            // 
            // StaffDGV
            // 
            StaffDGV.AllowUserToOrderColumns = true;
            StaffDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StaffDGV.Location = new Point(206, 253);
            StaffDGV.MultiSelect = false;
            StaffDGV.Name = "StaffDGV";
            StaffDGV.RowHeadersWidth = 51;
            StaffDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StaffDGV.Size = new Size(549, 260);
            StaffDGV.TabIndex = 39;
            StaffDGV.CellContentClick += StaffDGV_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-5, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(975, 62);
            panel1.TabIndex = 40;
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
            button5.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Brown;
            button5.Location = new Point(812, 525);
            button5.Name = "button5";
            button5.Size = new Size(145, 45);
            button5.TabIndex = 41;
            button5.Text = "Customers";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Brown;
            label6.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(929, 14);
            label6.Name = "label6";
            label6.Size = new Size(33, 35);
            label6.TabIndex = 42;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 582);
            Controls.Add(button5);
            Controls.Add(panel1);
            Controls.Add(StaffDGV);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(StaffPassTb);
            Controls.Add(label4);
            Controls.Add(StaffPhoneTb);
            Controls.Add(label2);
            Controls.Add(StaffNameTb);
            Controls.Add(label1);
            Name = "Staff";
            Text = "Staff";
            Load += Staff_Load;
            ((System.ComponentModel.ISupportInitialize)StaffDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox StaffPassTb;
        private Label label4;
        private TextBox StaffPhoneTb;
        private Label label2;
        private TextBox StaffNameTb;
        private Label label1;
        private DataGridView StaffDGV;
        private Panel panel1;
        private Label label3;
        private Button button5;
        private Label label6;
    }
}