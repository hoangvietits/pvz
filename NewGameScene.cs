using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pvz
{
    public partial class NewGameScene : UserControl
    {
        private float rows, cols;
        private const int cellSize = 128;
        private Random random = new Random();
        private List<Zombie> zombieList;
        private System.Windows.Forms.Timer spawnTimer;
        private System.Windows.Forms.Timer moveTimer;
        private Type selectedPlantType;  // Lưu trữ loại cây được chọn

        public NewGameScene()
        {
            InitializeComponent();

            SetDoubleBuffered(panel1);
            panel1.BackColor = Color.Transparent;
            panel1.Paint += DrawFloor;

            rows = panel1.Height / cellSize;
            cols = panel1.Width / cellSize;
            zombieList = new List<Zombie>();

            // Khởi tạo Timer cho zombie
            spawnTimer = new System.Windows.Forms.Timer();
            spawnTimer.Interval = 5000;
            spawnTimer.Tick += (s, e) => SpawnZombie();
            spawnTimer.Start();

            moveTimer = new System.Windows.Forms.Timer();
            moveTimer.Interval = 100;
            moveTimer.Tick += (s, e) => MoveZombie();
            moveTimer.Start();

            // Gọi hàm khởi tạo nút
            InitializeButtons();

            // Gắn sự kiện nhấp chuột cho panel
            panel1.MouseClick += panel1_MouseClick;
        }

        private void SetDoubleBuffered(Control control)
        {
            System.Reflection.PropertyInfo prop = typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
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

        private void InitializeButtons()
        {
            // Nút cho Peashooter
            Button shootPlantButton = new Button
            {
                BackgroundImage = Properties.Resources.peashooter,
                BackgroundImageLayout = ImageLayout.Stretch,
                Width = 100,
                Height = 100,
                Location = new Point(10, 10)
            };
            shootPlantButton.Click += (s, e) => { selectedPlantType = typeof(ShootingPlant); };

            // Nút cho PotatoPlant
            Button potatoPlantButton = new Button
            {
                BackgroundImage = Properties.Resources.wintermelon,
                BackgroundImageLayout = ImageLayout.Stretch,
                Width = 100,
                Height = 100,
                Location = new Point(120, 10)
            };
            potatoPlantButton.Click += (s, e) => { selectedPlantType = typeof(PotatoPlant); };

            // Nút cho EnergyPlant
            Button energyPlantButton = new Button
            {
                BackgroundImage = Properties.Resources.sunflower,
                BackgroundImageLayout = ImageLayout.Stretch,
                Width = 100,
                Height = 100,
                Location = new Point(230, 10)
            };
            energyPlantButton.Click += (s, e) => { selectedPlantType = typeof(EnergyPlant); };

            // Thêm các nút vào panel
            Controls.Add(shootPlantButton);
            Controls.Add(potatoPlantButton);
            Controls.Add(energyPlantButton);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectedPlantType != null)
            {
                // Tính toán tọa độ ô mà người dùng nhấp vào
                int gridX = (e.X / cellSize) * cellSize;
                int gridY = (e.Y / cellSize) * cellSize;

                // Kiểm tra xem đã có cây trong ô này chưa
                if (IsCellOccupied(gridX, gridY))
                {
                    MessageBox.Show("Ô này đã có cây rồi!");
                    return; // Không đặt thêm cây nếu ô đã có cây
                }

                // Tạo cây mới và đặt vào ô
                Plant newPlant = (Plant)Activator.CreateInstance(selectedPlantType);
                newPlant.Location = new Point(gridX, gridY);
                panel1.Controls.Add(newPlant);

                selectedPlantType = null; // Reset sau khi đặt cây
            }
        }

        // Hàm kiểm tra xem ô vuông đã có cây hay chưa
        private bool IsCellOccupied(int x, int y)
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Plant && control.Location == new Point(x, y))
                {
                    return true; // Có cây trong ô này
                }
            }
            return false; // Không có cây trong ô này
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
