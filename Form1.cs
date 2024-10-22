namespace Pvz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            GameScene gameScene = new GameScene();
            panel1.Controls.Add(gameScene);
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
