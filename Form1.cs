namespace Pvz
{
    public partial class Form1 : Form
    {
        public GameScene Scene;
        public NewGameScene NewGameScene;
        public Form1()
        {
            InitializeComponent();
            Scene = new GameScene();

            Scene._newgameBtn += NewGame;
            NewGameScene = new NewGameScene();

            NewGameScene.Dock = DockStyle.Fill;
            Scene.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(Scene); 
            
        }
        private void NewGame(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(NewGameScene);
        }


    }
}
