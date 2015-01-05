using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.Grid;
using PacMan.Monsters;

namespace PacMan.AI
{
    internal class Move
    {
        Dot _origin;
        Dot _destination;
        Monsters.Monster _monster;
        PacMan _pacman;
        
        internal Grid.Dot Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        internal Grid.Dot Origin
        {
            get { return _origin; }
            set { _origin = value; }
        }

        internal Move(Grid.Dot origin, Grid.Dot destination, Monsters.Monster monster)
        {
            _origin = origin;
            _destination = destination;
            _monster = monster;
        }

        internal Move(Grid.Dot origin, Grid.Dot destination, PacMan pacman)
        {
            _origin = origin;
            _destination = destination;
            _pacman = pacman;
        }
    }
}
