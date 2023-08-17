namespace Task2
{
    partial class DeleteAccount
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(172, 46);
            button2.TabIndex = 22;
            button2.Text = "Go Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(18, 305);
            button1.Name = "button1";
            button1.Size = new Size(146, 53);
            button1.TabIndex = 21;
            button1.Text = "Delete Customer";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 208);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 18;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 150);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 17;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 86);
            label1.Name = "label1";
            label1.Size = new Size(194, 32);
            label1.TabIndex = 16;
            label1.Text = "Delete Customer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 179);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 23;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 232);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 24;
            label5.Text = "label5";
            // 
            // DeleteAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 491);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeleteAccount";
            Text = "DeleteAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
    }
}