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
            //*
            switch (dot.Road)
            {
                case Constants.Road.Straight:
                    this.BackColor = Color.Gray;
                    break;
                case Constants.Road.Turn:
                    this.BackColor = Color.Green;
                    break;
                case Constants.Road.SpecialTurn:
                    this.BackColor = Color.Yellow;
                    break;
                case Constants.Road.ExitTurn:
                    this.BackColor = Color.Orange;
                    break;
                case Constants.Road.None:
                    break;
            }

            //*/

            /*
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
            */
            Location = new Point(_y, _x);
        }

        internal void UpdateDot(Constants.State state)
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
