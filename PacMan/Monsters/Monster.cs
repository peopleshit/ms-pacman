using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.Grid;

namespace PacMan.Monsters
{
    internal class Monster : IMonster
    {
        protected PacMan _pacman;
        protected Dot _runawayDot;
        protected Dot _currentDot;
        protected Dot _targetDot;
        protected Constants.Direction _direction;
        protected Constants.Behavior _behaviour;

        internal Constants.Behavior Behaviour
        {
            get { return _behaviour; }
            set { _behaviour = value; }
        }

        internal Constants.Direction Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }

        internal Dot RunawayDot
        {
            get { return _runawayDot; }
        }

        internal Dot TargetDot
        {
            get { return _targetDot; }
            set { _targetDot = value; }
        }

        internal Dot CurrentDot
        {
            get { return _currentDot; }
            set { _currentDot = value; }
        }

        internal Monster()
        { }

        internal Monster(Dot runawayDot, Dot currentDot, PacMan pacman)
        {
            _runawayDot = runawayDot;
            _currentDot = currentDot;
            _pacman = pacman;
        }

        internal Monster(Dot runawayDot, Dot currentDot, Dot targetDot, PacMan pacman)
        {
            _runawayDot = runawayDot;
            _currentDot = currentDot;
            _targetDot = targetDot;
            _pacman = pacman;
        }

        public virtual void Runaway()
        {
            throw new NotImplementedException();
        }

        public virtual void Follow()
        {

        }

        public void Panic()
        {

        }
    }
}
