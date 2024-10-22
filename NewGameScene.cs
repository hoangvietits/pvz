using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pvz
{
    public partial class NewGameScene : UserControl
    {
        private float rows, cols;
        private const int cellsize = 128;
        public NewGameScene()
        {
            InitializeComponent();
            panel1.BackColor = Color.Transparent;
            panel1.Paint += DrawFloor;

            rows = panel1.Height / cellsize;
            cols = panel1.Width / cellsize;

        }
        private void DrawFloor(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Transparent, 1);

            // Vẽ các đường ngang và dọc tạo thành lưới
            for (int i = 0; i <= rows; i++)
            {
                g.DrawLine(pen, 0, i * cellsize, panel1.Width, i * cellsize);
            }
            for (int j = 0; j <= cols; j++)
            {
                g.DrawLine(pen, j * cellsize, 0, j * cellsize, panel1.Height);
            }

            pen.Dispose();

        }
       

    }
}
