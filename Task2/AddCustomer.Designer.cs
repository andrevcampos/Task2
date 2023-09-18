namespace Task2
{
    partial class AddCustomer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(10, 77);
            label1.Name = "label1";
            label1.Size = new Size(150, 30);
            label1.TabIndex = 0;
            label1.Text = "New Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 151);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 206);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 224);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(384, 23);
            textBox2.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(13, 263);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Staff Account";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(10, 295);
            button1.Name = "button1";
            button1.Size = new Size(146, 53);
            button1.TabIndex = 6;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(230, 13);
            button2.Name = "button2";
            button2.Size = new Size(172, 36);
            button2.TabIndex = 7;
            button2.Text = "Go Back (Main Menu)";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(204, 40);
            label4.TabIndex = 8;
            label4.Text = "Campos Bank";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 111);
            label5.Name = "label5";
            label5.Size = new Size(310, 15);
            label5.TabIndex = 9;
            label5.Text = "Create a new customer account by filling the form below.";
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 491);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddCustomer";
            Text = "New Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label5;
    }
}