using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.Grid
{
    class Dot
    {
        Constants.State _state;
        Constants.Road _road;
        UI.DotUI _dotUI;

        internal UI.DotUI DotUI
        {
            get { return _dotUI; }
            set { _dotUI = value; }
        }

        internal Constants.Road Road
        {
            get { return _road; }
        }

        internal Constants.State State
        {
            get { return _state; }
            set { _state = value; }
        }

        internal Dot(Constants.State state, int x, int y)
        {
            _state = state;
            _dotUI = new UI.DotUI(this, x, y);
        }

        internal Dot(Constants.State state, Constants.Road road, int x, int y)
        {
            _state = state;
            _road = road;
            _dotUI = new UI.DotUI(this, x, y);
        }
    }
}
