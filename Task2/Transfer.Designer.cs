namespace Task2
{
    partial class Transfer
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            listBox2 = new ListBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            label20.Size = new Size(156, 30);
            label20.TabIndex = 52;
            label20.Text = "Transfer Money";
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
            button1.Text = "Go Back (Customer Menu)";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 151);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(184, 94);
            listBox1.TabIndex = 54;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 127);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 55;
            label1.Text = "From this Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 127);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 56;
            label2.Text = "To this Account";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(216, 151);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(186, 94);
            listBox2.TabIndex = 57;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 305);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 58;
            label3.Text = "Amount to Transfer";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(12, 323);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(142, 29);
            numericUpDown1.TabIndex = 59;
            // 
            // button2
            // 
            button2.BackColor = Color.OliveDrab;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(12, 372);
            button2.Name = "button2";
            button2.Size = new Size(146, 32);
            button2.TabIndex = 60;
            button2.Text = "Transfer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 252);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 61;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(216, 252);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 62;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 279);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 63;
            label6.Text = "label6";
            // 
            // Transfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 491);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(listBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(label13);
            Controls.Add(label20);
            Controls.Add(button1);
            Name = "Transfer";
            Text = "Transfer";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        private Label label20;
        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private ListBox listBox2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button button2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}