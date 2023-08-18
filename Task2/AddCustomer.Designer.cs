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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 86);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 0;
            label1.Text = "New Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 150);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 208);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 168);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 226);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(384, 23);
            textBox2.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(18, 266);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Staff Account";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(18, 305);
            button1.Name = "button1";
            button1.Size = new Size(146, 53);
            button1.TabIndex = 6;
            button1.Text = "Add Customer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(172, 46);
            button2.TabIndex = 7;
            button2.Text = "Go Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 491);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddCustomer";
            Text = "Form1";
            Load += AddCustomer_Load;
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
    }
}