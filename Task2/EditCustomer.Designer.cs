namespace Task2
{
    partial class EditCustomer
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
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGoldenrod;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(164, 262);
            button2.Name = "button2";
            button2.Size = new Size(145, 46);
            button2.TabIndex = 15;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(12, 262);
            button1.Name = "button1";
            button1.Size = new Size(146, 46);
            button1.TabIndex = 14;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 220);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(384, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 23);
            textBox1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 202);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 10;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 144);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 9;
            label2.Text = "First Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 111);
            label6.Name = "label6";
            label6.Size = new Size(184, 15);
            label6.TabIndex = 30;
            label6.Text = "Update the customer information";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(204, 40);
            label7.TabIndex = 29;
            label7.Text = "Campos Bank";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(10, 77);
            label8.Name = "label8";
            label8.Size = new Size(258, 30);
            label8.TabIndex = 28;
            label8.Text = "Edit Customer Information";
            // 
            // EditCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 491);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "EditCustomer";
            Text = "Edit Custoner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}