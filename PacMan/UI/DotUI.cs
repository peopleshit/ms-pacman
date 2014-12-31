using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacMan.Grid;

namespace PacMan.UI
{
    internal partial class DotUI : UserControl
    {
        internal DotUI(Dot dot, int x, int y)
        {
            InitializeComponent();
            switch (dot.State)
            {
                case Constants.State.Empty:
                    this.BackColor = Color.Gray;
                    break;
                case Constants.State.Energizer:
                    this.BackColor = Color.Orange;
                    break;
                case Constants.State.Food:
                    this.BackColor = Color.Yellow;
                    break;
                case Constants.State.Wall:
                    this.BackColor = Color.Blue;
                    break;
            }
            Location = new Point(y, x);
        }
    }
}
