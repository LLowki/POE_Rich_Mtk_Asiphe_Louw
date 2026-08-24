using System.Windows.Forms;

namespace POE_Rich_Mtk_Asiphe_Louw
{
    public partial class Form1 : Form
    {
        private GameEngine gameEngine;

        public Form1()
        {
            InitializeComponent();
            gameEngine = new GameEngine(10);
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            lblDisplay.Text = gameEngine.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Direction direction = Direction.None;

            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.W:
                    direction = Direction.Up;
                    break;
                case Keys.Right:
                case Keys.D:
                    direction = Direction.Right;
                    break;
                case Keys.Down:
                case Keys.S:
                    direction = Direction.Down;
                    break;
                case Keys.Left:
                case Keys.A:
                    direction = Direction.Left;
                    break;
            }

            if (direction != Direction.None)
            {
                gameEngine.TriggerMovement(direction);
                UpdateDisplay();
                e.Handled = true;
            }
        }
    }
}
