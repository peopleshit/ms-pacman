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
        Dot _runawayDot;
        Dot _currentDot;
        Dot _targetDot;

        internal Monster()
        { }

        internal Monster(Dot runawayDot, Dot currentDot)
        {
            _runawayDot = runawayDot;
            _currentDot = currentDot;
        }

        internal Monster(Dot runawayDot, Dot currentDot, Dot targetDot)
        {
            _runawayDot = runawayDot;
            _currentDot = currentDot;
            _targetDot = targetDot;
        }

        public virtual void Runaway()
        {
            throw new NotImplementedException();
        }

        public virtual void Follow()
        {
            throw new NotImplementedException();
        }

        public void Panic()
        {

        }
    }
}
