namespace Task2
{
    partial class ManageCustomer
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
            listBox1 = new ListBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 133);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(213, 274);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(231, 12);
            button1.Name = "button1";
            button1.Size = new Size(171, 37);
            button1.TabIndex = 1;
            button1.Text = "Go Back (Main Menu)";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(231, 205);
            button3.Name = "button3";
            button3.Size = new Size(171, 42);
            button3.TabIndex = 3;
            button3.Text = "Edit Selected Customer";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkRed;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Window;
            button4.Location = new Point(231, 278);
            button4.Name = "button4";
            button4.Size = new Size(171, 42);
            button4.TabIndex = 4;
            button4.Text = "Delete Selected Customer";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Location = new Point(231, 133);
            button5.Name = "button5";
            button5.Size = new Size(171, 41);
            button5.TabIndex = 5;
            button5.Text = "Select Customer";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(204, 40);
            label4.TabIndex = 9;
            label4.Text = "Campos Bank";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(12, 64);
            label1.Name = "label1";
            label1.Size = new Size(184, 30);
            label1.TabIndex = 10;
            label1.Text = "Manage Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 97);
            label2.Name = "label2";
            label2.Size = new Size(226, 15);
            label2.TabIndex = 11;
            label2.Text = "Select the customer you want to manage.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(236, 250);
            label5.Name = "label5";
            label5.Size = new Size(148, 15);
            label5.TabIndex = 13;
            label5.Text = "Edit Customer Information";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(236, 177);
            label6.Name = "label6";
            label6.Size = new Size(158, 15);
            label6.TabIndex = 14;
            label6.Text = "Manage Customer Accounts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 456);
            label3.Name = "label3";
            label3.Size = new Size(165, 15);
            label3.TabIndex = 12;
            label3.Text = "Create new customer account";
            // 
            // button2
            // 
            button2.BackColor = Color.OliveDrab;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(12, 413);
            button2.Name = "button2";
            button2.Size = new Size(213, 40);
            button2.TabIndex = 2;
            button2.Text = "Add Customer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ManageCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 491);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "ManageCustomer";
            Text = "Manage Customers";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label3;
        private Button button2;
    }
}