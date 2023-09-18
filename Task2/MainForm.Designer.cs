namespace Task2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(78, 252);
            button1.Name = "button1";
            button1.Size = new Size(249, 54);
            button1.TabIndex = 0;
            button1.Text = "Manage Customers";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(100, 35);
            label1.Name = "label1";
            label1.Size = new Size(204, 40);
            label1.TabIndex = 1;
            label1.Text = "Campos Bank";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(78, 158);
            button2.Name = "button2";
            button2.Size = new Size(249, 52);
            button2.TabIndex = 2;
            button2.Text = "New Account";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(124, 86);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 3;
            label2.Text = "Customer Panel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 214);
            label3.Name = "label3";
            label3.Size = new Size(161, 15);
            label3.TabIndex = 4;
            label3.Text = "Create new custome account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 312);
            label4.Name = "label4";
            label4.Size = new Size(143, 15);
            label4.TabIndex = 5;
            label4.Text = "Manage existing account.";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 491);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Campos Bank";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}