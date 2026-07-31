using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE_Rich_Mtk_Asiphe_Louw
{
    public partial class Form1 : Form
    {
        private GameEngine engine;
        private int levelNumbers = 10;
        public Form1()
        {
            InitializeComponent();
            engine = new GameEngine(levelNumbers);
            UpdateDisplay();
        }

        public void UpdateDisplay()
        {
            labelDisplay.Text = engine.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
