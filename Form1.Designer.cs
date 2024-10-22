namespace Pvz
{
    partial class Form1
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
            newGameBtn = new Button();
            quitBtn = new Button();
            continueBtn = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // newGameBtn
            // 
            newGameBtn.BackColor = Color.IndianRed;
            newGameBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            newGameBtn.Location = new Point(989, 267);
            newGameBtn.Name = "newGameBtn";
            newGameBtn.Size = new Size(199, 92);
            newGameBtn.TabIndex = 0;
            newGameBtn.Text = "NEW GAME";
            newGameBtn.UseVisualStyleBackColor = false;
            newGameBtn.Click += newGameBtn_Click;
            // 
            // quitBtn
            // 
            quitBtn.BackColor = Color.IndianRed;
            quitBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            quitBtn.Location = new Point(989, 508);
            quitBtn.Name = "quitBtn";
            quitBtn.Size = new Size(199, 92);
            quitBtn.TabIndex = 1;
            quitBtn.Text = "QUIT ";
            quitBtn.UseVisualStyleBackColor = false;
            // 
            // continueBtn
            // 
            continueBtn.BackColor = Color.IndianRed;
            continueBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            continueBtn.Location = new Point(989, 385);
            continueBtn.Name = "continueBtn";
            continueBtn.Size = new Size(199, 92);
            continueBtn.TabIndex = 1;
            continueBtn.Text = "CONTINUE";
            continueBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(continueBtn);
            panel1.Controls.Add(quitBtn);
            panel1.Controls.Add(newGameBtn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1327, 728);
            panel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1320, 717);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Pvz";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button newGameBtn;
        private Button quitBtn;
        private Button continueBtn;
        private Panel panel1;
    }
}
