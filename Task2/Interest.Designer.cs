namespace Task2
{
    partial class Interest
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
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
            label20.Size = new Size(192, 30);
            label20.TabIndex = 52;
            label20.Text = "Interest Calculation";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 124);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 54;
            label1.Text = "Account:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 152);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 55;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 184);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 56;
            label3.Text = "Curent Balance:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 207);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 57;
            label4.Text = "Curent Interest:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(115, 184);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 58;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(115, 207);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 59;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 231);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 60;
            label7.Text = "Amount:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(76, 231);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 61;
            label8.Text = "label8";
            // 
            // button2
            // 
            button2.BackColor = Color.OliveDrab;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(19, 267);
            button2.Name = "button2";
            button2.Size = new Size(128, 40);
            button2.TabIndex = 62;
            button2.Text = "Add Interest";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Interest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 491);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label13);
            Controls.Add(label20);
            Controls.Add(button1);
            Name = "Interest";
            Text = "Interest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        private Label label20;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button2;
    }
}