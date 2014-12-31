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
        int _x;
        int _y;

        internal int Y
        {
            get { return _y; }
        }

        internal int X
        {
            get { return _x; }
        }

        internal DotUI(Dot dot, int x, int y)
        {
            _x = 10 * x + Constants.borderX;
            _y = 10 * y + Constants.borderY;

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

            Location = new Point(_y, _x);
        }

        public void UpdateDot(Constants.State state)
        {
            switch (state)
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
            this.Invalidate();
        }
    }
}
