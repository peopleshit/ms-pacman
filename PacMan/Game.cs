using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.AI;
using PacMan.Monsters;

namespace PacMan
{
    internal class Game
    {
        Grid.Grid _grid;
        List<Move[]> moves = new List<Move[]>();
        Logic _logic;
        Monster[] _monsters;
        Random _rand;
        PacMan _pacman;

        internal Grid.Grid Grid
        {
            get { return _grid; }
            set { _grid = value; }
        }

        internal Game()
        {
            _grid = new Grid.Grid();
            _logic = new Logic(_grid);
            _rand = new Random();
            _monsters = new Monster[] 
            {
                new Blinky(_grid.GameGrid[0, 25], _grid.GameGrid[14, _rand.Next(13, 15)]),
                new Pinky(_grid.GameGrid[0, 2], _grid.GameGrid[17, _rand.Next(13, 15)]),
                new Inky(_grid.GameGrid[35, 0], _grid.GameGrid[17, 12]),
                new Clyde(_grid.GameGrid[35, 27], _grid.GameGrid[17, 15])
            };
            _pacman = new PacMan(_grid);
        }

        internal List<UI.DotUI> GenerateInitialGrid()
        {
            List<UI.DotUI> UI = new List<UI.DotUI>();
            for (int i = 0; i < Constants.gridX; i++)
                for (int j = 0; j < Constants.gridY; j++)
                {
                    UI.Add(_grid.GameGrid[i, j].DotUI);
                }
            return UI;
        }

        internal void MakeMove()
        {
            Move[] currentMove = new Move[5];
            currentMove[0] = new Move(_pacman.CurrentDot, _pacman.SetTarget(), _pacman);
            currentMove[1] = new Move(_monsters[0].CurrentDot, 
                _monsters[0].CurrentDot.Road == Constants.Road.Straight ? 
                _logic.GoStraight(_monsters[0].CurrentDot, _monsters[0].Direction) : _monsters[0].Behaviour == Constants.Behavior.Frightened ?
                _logic.GetRandomWay(_monsters[0].CurrentDot, _monsters[0].Direction) : _logic.GetWay(_monsters[0].CurrentDot, _monsters[0].TargetDot, _monsters[0].Direction),
                _monsters[0]);
            currentMove[2] = new Move(_monsters[1].CurrentDot,
                _monsters[1].CurrentDot.Road == Constants.Road.Straight ?
                _logic.GoStraight(_monsters[1].CurrentDot, _monsters[1].Direction) : _monsters[1].Behaviour == Constants.Behavior.Frightened ?
                _logic.GetRandomWay(_monsters[1].CurrentDot, _monsters[1].Direction) : _logic.GetWay(_monsters[1].CurrentDot, _monsters[1].TargetDot, _monsters[1].Direction),
                _monsters[1]);
            currentMove[3] = new Move(_monsters[1].CurrentDot,
                _monsters[2].CurrentDot.Road == Constants.Road.Straight ?
                _logic.GoStraight(_monsters[2].CurrentDot, _monsters[2].Direction) : _monsters[2].Behaviour == Constants.Behavior.Frightened ?
                _logic.GetRandomWay(_monsters[2].CurrentDot, _monsters[2].Direction) : _logic.GetWay(_monsters[2].CurrentDot, _monsters[2].TargetDot, _monsters[2].Direction),
                _monsters[2]);
            currentMove[4] = new Move(_monsters[1].CurrentDot,
                _monsters[3].CurrentDot.Road == Constants.Road.Straight ?
                _logic.GoStraight(_monsters[3].CurrentDot, _monsters[3].Direction) : _monsters[3].Behaviour == Constants.Behavior.Frightened ?
                _logic.GetRandomWay(_monsters[3].CurrentDot, _monsters[3].Direction) : _logic.GetWay(_monsters[3].CurrentDot, _monsters[3].TargetDot, _monsters[3].Direction),
                _monsters[3]);
            _grid.Move(currentMove);
        }
    }
}
