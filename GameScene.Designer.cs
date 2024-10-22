namespace Pvz
{
    partial class GameScene
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            newGameBtn = new Button();
            continueBtn = new Button();
            quitBtn = new Button();
            SuspendLayout();
            // 
            // newGameBtn
            // 
            newGameBtn.BackColor = Color.IndianRed;
            newGameBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            newGameBtn.Location = new Point(946, 383);
            newGameBtn.Name = "newGameBtn";
            newGameBtn.Size = new Size(199, 92);
            newGameBtn.TabIndex = 1;
            newGameBtn.Text = "NEW GAME";
            newGameBtn.UseVisualStyleBackColor = false;
            newGameBtn.Click += newGameBtn_Click;
            // 
            // continueBtn
            // 
            continueBtn.BackColor = Color.IndianRed;
            continueBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            continueBtn.Location = new Point(946, 507);
            continueBtn.Name = "continueBtn";
            continueBtn.Size = new Size(199, 92);
            continueBtn.TabIndex = 2;
            continueBtn.Text = "CONTINUE";
            continueBtn.UseVisualStyleBackColor = false;
            continueBtn.Click += continueBtn_Click;
            // 
            // quitBtn
            // 
            quitBtn.BackColor = Color.IndianRed;
            quitBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            quitBtn.Location = new Point(946, 624);
            quitBtn.Name = "quitBtn";
            quitBtn.Size = new Size(199, 92);
            quitBtn.TabIndex = 3;
            quitBtn.Text = "QUIT";
            quitBtn.UseVisualStyleBackColor = false;
            quitBtn.Click += quitBtn_Click;
            // 
            // GameScene
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(quitBtn);
            Controls.Add(continueBtn);
            Controls.Add(newGameBtn);
            Name = "GameScene";
            Size = new Size(1318, 776);
            Load += GameScene_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button newGameBtn;
        private Button continueBtn;
        private Button quitBtn;
    }
}
