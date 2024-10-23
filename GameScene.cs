using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pvz
{
    public partial class GameScene : UserControl
    {
        public event EventHandler _newgameBtn;
        public event EventHandler _continueBtn;
        public event EventHandler _quitBtn;

        public GameScene()
        {

            InitializeComponent();
            newGameBtn.Click += (s, e) => _newgameBtn?.Invoke(this, EventArgs.Empty);
        }

        private void GameScene_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.menu;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {

        }

        private void continueBtn_Click(object sender, EventArgs e)
        {

        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
