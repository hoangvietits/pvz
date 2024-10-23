namespace Pvz
{
    partial class NewGameScene
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
            panel1 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(220, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 554);
            panel1.TabIndex = 0;
            // 
            // NewGameScene
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.PC_Computer___Plants_vs_Zombies___Day;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel1);
            Name = "NewGameScene";
            Size = new Size(1292, 658);
            
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
    }
}
