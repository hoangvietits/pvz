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
        public GameScene()
        {
            InitializeComponent();
        }

        private void GameScene_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.menu;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
