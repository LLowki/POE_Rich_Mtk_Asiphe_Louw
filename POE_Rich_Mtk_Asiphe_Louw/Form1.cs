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
    }
}
