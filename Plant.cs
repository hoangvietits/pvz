using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pvz
{
    public abstract class Plant : PictureBox
    {
        public int Health { get; protected set; }
        public int Cost { get; protected set; }

        public Plant(int health, int cost)
        {
            this.Health = health;
            this.Cost = cost;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Height = 120;
            this.Width = 120;
        }
    }

    public class ShootingPlant : Plant
    {
        public ShootingPlant() : base(100, 30)
        {
            this.Image = Properties.Resources.peashooter; // Thay đổi hình ảnh cho cây bắn
        }
    }

    public class PotatoPlant : Plant
    {
        public PotatoPlant() : base(1000, 10)
        {
            this.Image = Properties.Resources.wintermelon; // Thay đổi hình ảnh cho cây khoai tây
        }
    }

    public class EnergyPlant : Plant
    {
        public EnergyPlant() : base(500, 5)
        {
            this.Image = Properties.Resources.sunflower; // Thay đổi hình ảnh cho cây năng lượng
        }
    }
}
