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
            mainpage1 = new mainpage();
            customercp1 = new customercp();
            SuspendLayout();
            // 
            // mainpage1
            // 
            mainpage1.Location = new Point(12, 12);
            mainpage1.Name = "mainpage1";
            mainpage1.Size = new Size(390, 467);
            mainpage1.TabIndex = 0;
            // 
            // customercp1
            // 
            customercp1.Location = new Point(12, 12);
            customercp1.Name = "customercp1";
            customercp1.Size = new Size(390, 467);
            customercp1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 491);
            Controls.Add(customercp1);
            Controls.Add(mainpage1);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private mainpage mainpage1;
        private customercp customercp1;
    }
}