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
        public MainForm()
        {
            InitializeComponent();
            Grid.Grid grid = new Grid.Grid();
            for (int i = 0; i < Constants.gridX; i++)
                for (int j = 0; j < Constants.gridY; j++)
                {
                    UI.DotUI dot = new UI.DotUI(grid.GameGrid[i, j], 10 + 10 * i, 10 + 10 * j);
                    this.Controls.Add(dot);
                }
            this.Invalidate();
        }
    }
}
