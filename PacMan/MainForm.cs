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
            this.Invalidate();
            this.Visible = true;
            //AI.Logic logic = new AI.Logic(_game.Grid);
            //Grid.Dot t = logic.GoStraight(_game.Grid.GameGrid[17, 27], Constants.Direction.Left);
            //MessageBox.Show(t.DotUI.GridX + " " + t.DotUI.GridY);
        }
    }
}
