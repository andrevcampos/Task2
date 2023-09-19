namespace Task2
{
    partial class SelectCustomer
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
            button1 = new Button();
            listBox1 = new ListBox();
            label3 = new Label();
            label18 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            button3 = new Button();
            button2 = new Button();
            label15 = new Label();
            label14 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label12 = new Label();
            label13 = new Label();
            label20 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(230, 12);
            button1.Name = "button1";
            button1.Size = new Size(172, 34);
            button1.TabIndex = 0;
            button1.Text = "Go Back (Customer Menu)";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(16, 182);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(236, 94);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 129);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(258, 180);
            label18.Name = "label18";
            label18.Size = new Size(107, 15);
            label18.TabIndex = 47;
            label18.Text = "Employee Account";
            label18.Visible = false;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown2.Location = new Point(16, 435);
            numericUpDown2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(142, 29);
            numericUpDown2.TabIndex = 46;
            numericUpDown2.Visible = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(16, 375);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(142, 29);
            numericUpDown1.TabIndex = 45;
            numericUpDown1.Visible = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(164, 433);
            button3.Name = "button3";
            button3.Size = new Size(91, 33);
            button3.TabIndex = 44;
            button3.Text = "Withdrawal";
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(164, 373);
            button2.Name = "button2";
            button2.Size = new Size(88, 33);
            button2.TabIndex = 43;
            button2.Text = "Deposit";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(15, 416);
            label15.Name = "label15";
            label15.Size = new Size(70, 15);
            label15.TabIndex = 39;
            label15.Text = "Withdrawal ";
            label15.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(14, 356);
            label14.Name = "label14";
            label14.Size = new Size(47, 15);
            label14.TabIndex = 38;
            label14.Text = "Deposit";
            label14.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(316, 261);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 35;
            label11.Text = "label11";
            label11.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(258, 261);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 34;
            label10.Text = "Overdraft:";
            label10.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(306, 241);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 33;
            label9.Text = "label9";
            label9.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(258, 241);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 32;
            label8.Text = "Interest:";
            label8.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(289, 219);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 31;
            label7.Text = "label7";
            label7.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(258, 220);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 30;
            label6.Text = "Fees:";
            label6.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 199);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 29;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 199);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 28;
            label4.Text = "Balance:";
            label4.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(16, 160);
            label12.Name = "label12";
            label12.Size = new Size(214, 15);
            label12.TabIndex = 51;
            label12.Text = "Select the account from the box below.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(12, 9);
            label13.Name = "label13";
            label13.Size = new Size(204, 40);
            label13.TabIndex = 50;
            label13.Text = "Campos Bank";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 15.75F, FontStyle.Underline, GraphicsUnit.Point);
            label20.Location = new Point(10, 77);
            label20.Name = "label20";
            label20.Size = new Size(245, 30);
            label20.TabIndex = 49;
            label20.Text = "Customer Bank Accounts";
            // 
            // button4
            // 
            button4.BackColor = Color.OliveDrab;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Window;
            button4.Location = new Point(16, 282);
            button4.Name = "button4";
            button4.Size = new Size(110, 38);
            button4.TabIndex = 52;
            button4.Text = "New Account";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkGoldenrod;
            button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.Window;
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(132, 282);
            button5.Name = "button5";
            button5.Size = new Size(120, 38);
            button5.TabIndex = 53;
            button5.Text = "Transfer Money";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkRed;
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.Window;
            button6.Location = new Point(279, 435);
            button6.Name = "button6";
            button6.Size = new Size(120, 31);
            button6.TabIndex = 54;
            button6.Text = "Delete Account";
            button6.UseVisualStyleBackColor = false;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSalmon;
            button7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(258, 284);
            button7.Name = "button7";
            button7.Size = new Size(141, 35);
            button7.TabIndex = 55;
            button7.Text = "Interest";
            button7.UseVisualStyleBackColor = false;
            // 
            // SelectCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 491);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label20);
            Controls.Add(label18);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "SelectCustomer";
            Text = "Customer Bank Account";
            Load += SelectCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Label label3;
        private Label label18;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Button button3;
        private Button button2;
        private Label label15;
        private Label label14;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label12;
        private Label label13;
        private Label label20;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}