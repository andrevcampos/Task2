namespace Task2
{
    partial class NewBankAccount
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
            label13 = new Label();
            label20 = new Label();
            button1 = new Button();
            customername = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label10 = new Label();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            numericUpDownBalance = new NumericUpDown();
            numericUpDownFees = new NumericUpDown();
            numericUpDownInterest1 = new NumericUpDown();
            numericUpDownInterest2 = new NumericUpDown();
            numericUpDownOverdraft = new NumericUpDown();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBalance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInterest1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInterest2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOverdraft).BeginInit();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(12, 9);
            label13.Name = "label13";
            label13.Size = new Size(204, 40);
            label13.TabIndex = 53;
            label13.Text = "Campos Bank";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 15.75F, FontStyle.Underline, GraphicsUnit.Point);
            label20.Location = new Point(10, 77);
            label20.Name = "label20";
            label20.Size = new Size(198, 30);
            label20.TabIndex = 52;
            label20.Text = "New Bank Accounts";
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(230, 12);
            button1.Name = "button1";
            button1.Size = new Size(172, 34);
            button1.TabIndex = 51;
            button1.Text = "Go Back (Customer Account)";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // customername
            // 
            customername.AutoSize = true;
            customername.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            customername.Location = new Point(13, 129);
            customername.Name = "customername";
            customername.Size = new Size(155, 25);
            customername.TabIndex = 54;
            customername.Text = "Customer Name";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 185);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 23);
            comboBox1.TabIndex = 55;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 165);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 56;
            label1.Text = "Select new account type";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(183, 287);
            label10.Name = "label10";
            label10.Size = new Size(90, 15);
            label10.TabIndex = 61;
            label10.Text = "Overdraft Limit:";
            label10.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 286);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 60;
            label8.Text = "Interest:";
            label8.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(183, 229);
            label6.Name = "label6";
            label6.Size = new Size(120, 15);
            label6.TabIndex = 59;
            label6.Text = "Bank Transaction Fee:";
            label6.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 229);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 58;
            label4.Text = "Initial Balance:";
            label4.Visible = false;
            // 
            // numericUpDownBalance
            // 
            numericUpDownBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownBalance.Location = new Point(16, 247);
            numericUpDownBalance.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownBalance.Name = "numericUpDownBalance";
            numericUpDownBalance.Size = new Size(142, 29);
            numericUpDownBalance.TabIndex = 62;
            numericUpDownBalance.Visible = false;
            // 
            // numericUpDownFees
            // 
            numericUpDownFees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownFees.Location = new Point(183, 247);
            numericUpDownFees.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownFees.Name = "numericUpDownFees";
            numericUpDownFees.Size = new Size(142, 29);
            numericUpDownFees.TabIndex = 63;
            numericUpDownFees.Visible = false;
            // 
            // numericUpDownInterest1
            // 
            numericUpDownInterest1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownInterest1.Location = new Point(16, 305);
            numericUpDownInterest1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownInterest1.Name = "numericUpDownInterest1";
            numericUpDownInterest1.Size = new Size(142, 29);
            numericUpDownInterest1.TabIndex = 64;
            numericUpDownInterest1.Visible = false;
            // 
            // numericUpDownInterest2
            // 
            numericUpDownInterest2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownInterest2.Location = new Point(16, 343);
            numericUpDownInterest2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownInterest2.Name = "numericUpDownInterest2";
            numericUpDownInterest2.Size = new Size(142, 29);
            numericUpDownInterest2.TabIndex = 65;
            numericUpDownInterest2.Visible = false;
            // 
            // numericUpDownOverdraft
            // 
            numericUpDownOverdraft.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownOverdraft.Location = new Point(183, 305);
            numericUpDownOverdraft.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownOverdraft.Name = "numericUpDownOverdraft";
            numericUpDownOverdraft.Size = new Size(142, 29);
            numericUpDownOverdraft.TabIndex = 66;
            numericUpDownOverdraft.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.OliveDrab;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(13, 409);
            button2.Name = "button2";
            button2.Size = new Size(142, 39);
            button2.TabIndex = 67;
            button2.Text = "Create Account";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // NewBankAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 491);
            Controls.Add(button2);
            Controls.Add(numericUpDownOverdraft);
            Controls.Add(numericUpDownInterest2);
            Controls.Add(numericUpDownInterest1);
            Controls.Add(numericUpDownFees);
            Controls.Add(numericUpDownBalance);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(customername);
            Controls.Add(label13);
            Controls.Add(label20);
            Controls.Add(button1);
            Name = "NewBankAccount";
            Text = "New Bank Account";
            ((System.ComponentModel.ISupportInitialize)numericUpDownBalance).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFees).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInterest1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownInterest2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOverdraft).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        private Label label20;
        private Button button1;
        private Label customername;
        private ComboBox comboBox1;
        private Label label1;
        private Label label10;
        private Label label8;
        private Label label6;
        private Label label4;
        private NumericUpDown numericUpDownBalance;
        private NumericUpDown numericUpDownFees;
        private NumericUpDown numericUpDownInterest1;
        private NumericUpDown numericUpDownInterest2;
        private NumericUpDown numericUpDownOverdraft;
        private Button button2;
    }
}