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
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label19 = new Label();
            label18 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            button3 = new Button();
            button2 = new Button();
            label17 = new Label();
            label16 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(172, 42);
            button1.TabIndex = 0;
            button1.Text = "Go Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 113);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 1;
            label1.Text = "Select Account";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 133);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(390, 94);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 3;
            label2.Text = "Customer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 86);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(282, 260);
            label19.Name = "label19";
            label19.Size = new Size(120, 15);
            label19.TabIndex = 48;
            label19.Text = "50% Discount on fees";
            label19.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(264, 237);
            label18.Name = "label18";
            label18.Size = new Size(138, 21);
            label18.TabIndex = 47;
            label18.Text = "Employee Account";
            label18.Visible = false;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(12, 383);
            numericUpDown2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 46;
            numericUpDown2.Visible = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 337);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 45;
            numericUpDown1.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(138, 383);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 44;
            button3.Text = "Withdrawal";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(138, 337);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 43;
            button2.Text = "Deposit";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(13, 436);
            label17.Name = "label17";
            label17.Size = new Size(44, 15);
            label17.TabIndex = 42;
            label17.Text = "label17";
            label17.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(12, 417);
            label16.Name = "label16";
            label16.Size = new Size(56, 15);
            label16.TabIndex = 41;
            label16.Text = "Message:";
            label16.Visible = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(11, 367);
            label15.Name = "label15";
            label15.Size = new Size(70, 15);
            label15.TabIndex = 39;
            label15.Text = "Withdrawal ";
            label15.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(10, 322);
            label14.Name = "label14";
            label14.Size = new Size(47, 15);
            label14.TabIndex = 38;
            label14.Text = "Deposit";
            label14.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(70, 298);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 35;
            label11.Text = "label11";
            label11.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 298);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 34;
            label10.Text = "Overdraft:";
            label10.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(60, 280);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 33;
            label9.Text = "label9";
            label9.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 280);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 32;
            label8.Text = "Interest:";
            label8.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 262);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 31;
            label7.Text = "label7";
            label7.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 262);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 30;
            label6.Text = "Fees:";
            label6.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 242);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 29;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 242);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 28;
            label4.Text = "Balance:";
            label4.Visible = false;
            // 
            // SelectCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 491);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label17);
            Controls.Add(label16);
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
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "SelectCustomer";
            Text = "Form1";
            Load += SelectCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private Label label3;
        private Label label19;
        private Label label18;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Button button3;
        private Button button2;
        private Label label17;
        private Label label16;
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
    }
}