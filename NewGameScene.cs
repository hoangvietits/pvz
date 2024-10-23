using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Pvz
{
    public partial class NewGameScene : UserControl
    {
        private float rows, cols;
        private const int cellSize = 128;
        private Random random = new Random();
        private List<Zombie> zombieList;
        private System.Windows.Forms.Timer spawnTimer; // Chỉ định rõ namespace
        private System.Windows.Forms.Timer moveTimer;  // Chỉ định rõ namespace

        public NewGameScene()
        {
            InitializeComponent();

            // Kích hoạt Double Buffering cho Panel
            SetDoubleBuffered(panel1);

            panel1.BackColor = Color.Transparent;
            panel1.Paint += DrawFloor;

            rows = panel1.Height / cellSize;
            cols = panel1.Width / cellSize;
            zombieList = new List<Zombie>();

            spawnTimer = new System.Windows.Forms.Timer();
            spawnTimer.Interval = 5000; // 5 giây
            spawnTimer.Tick += (s, e) => SpawnZombie();
            spawnTimer.Start();

            moveTimer = new System.Windows.Forms.Timer();
            moveTimer.Interval = 100; // 100ms
            moveTimer.Tick += (s, e) => MoveZombie();
            moveTimer.Start();
        }
        // Hàm bật Double Buffering
        private void SetDoubleBuffered(Control control)
        {
            // Sử dụng Reflection để bật Double Buffering cho Control
            System.Reflection.PropertyInfo prop = typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);
            prop.SetValue(control, true, null);
        }
        private void DrawFloor(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 1);

            for (int i = 0; i <= rows; i++)
            {
                g.DrawLine(pen, 0, i * cellSize, panel1.Width, i * cellSize);
            }
            for (int j = 0; j <= cols; j++)
            {
                g.DrawLine(pen, j * cellSize, 0, j * cellSize, panel1.Height);
            }

            pen.Dispose();
        }

        private void SpawnZombie()
        {
            if (zombieList.Count >= 25) return;

            int row = random.Next(0, (int)rows);
            Zombie zombie = new Zombie(1);

            int zombieX = panel1.Width;
            int zombieY = row * cellSize;

            zombie.Location = new Point(zombieX, zombieY);

            zombieList.Add(zombie);
            panel1.Controls.Add(zombie);
        }

        private void MoveZombie()
        {
            foreach (var zombie in zombieList.ToList())
            {
                zombie.Left -= zombie.speed;

                if (zombie.Right < 0)
                {
                    panel1.Controls.Remove(zombie);
                    zombieList.Remove(zombie);
                }
            }

            panel1.Invalidate();
        }
    }
}
