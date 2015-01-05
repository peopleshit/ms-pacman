using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.UI;

namespace PacMan.Grid
{
    class Dot
    {
        Constants.State _state;
        Constants.Road _road;
        DotUI _dotUI;
        Constants.State _permanentState;

        internal Constants.State PermanentState
        {
            get { return _permanentState; }
        }

        internal DotUI DotUI
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
            set
            {
                _state = value;
                _dotUI.UpdateDot(value);
            }
        }

        internal Dot(Constants.State state, int x, int y)
        {
            _state = state;
            _permanentState = state;
            _dotUI = new UI.DotUI(this, x, y);
        }

        internal Dot(Constants.State state, Constants.Road road, int x, int y)
        {
            _state = state;
            _permanentState = state;
            _road = road;
            _dotUI = new UI.DotUI(this, x, y);
        }

        internal void SetDefaultState()
        {
            _state = _permanentState;
            _dotUI.UpdateDot(_permanentState);
        }

        internal void EatFood()
        {
            if (_state == Constants.State.Food)
            {
                _permanentState = Constants.State.Empty;
                _state = Constants.State.Empty;
            }
            else
                throw new InvalidOperationException("Where is my food?!");
        }
    }
}
