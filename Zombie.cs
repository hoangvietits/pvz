using System;
using System.Windows.Forms;

namespace Pvz
{
    public class Zombie : PictureBox
    {
        public int health;
        public int dmg;
        public int speed;
        public int score;

        public Zombie(int level)
        {
            this.Width = 120;  // Đặt kích thước zombie
            this.Height = 120;
            this.SizeMode = PictureBoxSizeMode.StretchImage; // Co giãn hình ảnh

            this.health = 100 + 50 * level;
            this.dmg = 25 * level;
            this.speed = 1 + 2 * level;
            this.score = 5 * level;

            // Đặt hình ảnh tương ứng với cấp độ zombie
            switch (level)
            {
                case 1:
                    this.Image = Properties.Resources.regularZombie;
                    break;
                case 2:
                    this.Image = Properties.Resources.paperzombie;
                    break;
                case 3:
                    this.Image = Properties.Resources.brainzombie;
                    break;
                default:
                    break;
            }
        }
    }
}
