using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan
{
    public partial class MainForm : Form
    {
        Game _game;

        Timer timer = new Timer();

        public MainForm()
        {
            this.Visible = false;
            InitializeComponent();
            this.Height = 500;
            this.Width = 500;
            _game = new Game();
            List<UI.DotUI> grid = _game.GenerateInitialGrid();
            foreach (UI.DotUI dot in grid)
                this.Controls.Add(dot);
            this.Visible = true;
            //_game.MakeMove();
            //AI.Logic logic = new AI.Logic(_game.Grid);
            //Grid.Dot t = logic.GoStraight(_game.Grid.GameGrid[4, 1], Constants.Direction.Left);
            //MessageBox.Show(t.DotUI.GridX + " " + t.DotUI.GridY);
            timer.Interval = 5000;
            timer.Tick += timer_Tick;
            timer.Start();
            
        }

        void timer_Tick(object sender, EventArgs e)
        {
            _game.Grid.OpenGate();
            timer.Stop();
            MessageBox.Show("");
        }
    }
}
