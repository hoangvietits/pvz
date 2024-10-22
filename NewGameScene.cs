using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace Pvz
{
    public partial class NewGameScene : UserControl
    {
        private float rows, cols;
        private const int cellSize = 128;
        private bool placeable;
        private string gameState;
        private int zombieCount;
        public int round;
        private List<Zombie> zombieList;



        public NewGameScene()
        {
            InitializeComponent();
            panel1.BackColor = Color.Transparent;
            panel1.Paint += DrawFloor;

            rows = panel1.Height / cellSize;
            cols = panel1.Width / cellSize;
            zombieList = new List<Zombie>();
            


        }
        private void DrawFloor(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 1);

            // Vẽ các đường ngang và dọc tạo thành lưới
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

        private void NewGameScene_Load(object sender, EventArgs e)
        {
            SpawnZombie();
        }
        private void GameStart()
        {
           

        }
        private void MoveZombie()
        {
            foreach (var zombie in zombieList.ToList()) // Duyệt qua danh sách zombie
            {
                // Di chuyển zombie sang trái
                zombie.Left -= zombie.speed;

                // Kiểm tra nếu zombie đã ra khỏi màn hình
                if (zombie.Left + zombie.Width < 0)
                {
                    // Xóa zombie nếu nó đã ra khỏi màn hình
                    panel1.Controls.Remove(zombie);
                    zombieList.Remove(zombie);
                }
            }

            panel1.Invalidate(); // Vẽ lại panel1 để cập nhật giao diện
        }
        private void MoveBullet()
        {

        }
        private void PlacePlant()
        {

        }
        private void SpawnZombie()
        {
            while(zombieList.Count <= 25)
            {
                Random random = new Random();

                // Chọn hàng ngẫu nhiên
                int row = random.Next(0, (int)rows);

                // Tạo zombie mới
                Zombie zombie = new Zombie(1);

                // Đặt zombie tại vị trí ngoài cùng bên phải
                int zombieX = panel1.Width - zombie.Width;
                int zombieY = row * cellSize; // Vị trí theo hàng

                zombie.Location = new Point(zombieX, zombieY);

                // Thêm zombie vào danh sách và hiển thị lên panel
                zombieList.Add(zombie);
                panel1.Controls.Add(zombie);
            }
        }    
     
    }
}
