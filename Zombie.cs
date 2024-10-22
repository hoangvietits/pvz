using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pvz
{
    public class Zombie : PictureBox   
    {
        public int health;
        public int dmg;
        public int speed;
        public int score;
        public Zombie(int level )
        {
            this.health = 100 + 50 * level;
            this.dmg = 25*level;
            this.speed = 5 + 2 * level;
            this.score = 5 * level;
            switch (level ) {
                case 1:
                    this.BackgroundImage = Properties.Resources.regularZombie;
                    break;
                case 2:
                    this.BackgroundImage= Properties.Resources.paperzombie;
                    break;
                case 3:
                    this.BackgroundImage = Properties.Resources.brainzombie;
                    break;
                default:
                    break;
            }
        }
    }
}
