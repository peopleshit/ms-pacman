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

        internal Constants.Road Road
        {
            get { return _road; }
            set { _road = value; }
        }

        internal Constants.State State
        {
            get { return _state; }
            set { _state = value; }
        }

        internal Dot(Constants.State state)
        {
            _state = state;
        }

        internal Dot(Constants.State state, Constants.Road road)
        {
            _state = state;
            _road = road;
        }
    }
}
