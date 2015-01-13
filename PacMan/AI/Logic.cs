using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.Grid;
using PacMan.Monsters;

namespace PacMan.AI
{
    internal class Logic
    {
        Grid.Grid _grid;
        Constants.Direction changedDirection;

        public Constants.Direction ChangedDirection
        {
            get { return changedDirection; }
        }

        internal Logic(Grid.Grid grid)
        {
            _grid = grid;
        }

        private Dot[] GetDotsAround(Dot dot)
        {
            int x = dot.DotUI.GridX;
            int y = dot.DotUI.GridY;
            return new Dot[] { _grid.GameGrid[x - 1, y], _grid.GameGrid[x, y - 1], _grid.GameGrid[x, y + 1], _grid.GameGrid[x + 1, y] };

        }

        internal Dot GetWay(Dot origin, Dot target, Constants.Direction direction)
        {
            Dot[] directions = GetDotsAround(origin);
            double min = 1000;
            int x = -1, y = -1;
            Dot toReturn = new Dot();
            if (origin.Road == Constants.Road.SpecialTurn)
                directions = ExcludeOppositeDirection(directions, direction, true);
            else
                directions = ExcludeOppositeDirection(directions, direction, false);
            directions = ExcludeWalls(directions);
            if (directions.Length == 1)
                return directions[0];
            else if (directions.Length > 1)
            {
                foreach (Dot dot in directions)
                {
                    Point dotPoint = new Point(dot.DotUI.Y, dot.DotUI.X);
                    Point targetPoint = target.DotUI.Location;
                    double current = Math.Sqrt(Math.Pow(dotPoint.X - targetPoint.X, 2) + Math.Pow(dotPoint.Y - targetPoint.Y, 2));
                    if (current < min)
                    {
                        x = dot.DotUI.GridX;
                        y = dot.DotUI.GridY;
                        toReturn = dot;
                        min = current;
                    }
                    else if (current == min)
                    {
                        if (x == dot.DotUI.GridX)
                        {
                            if (y > dot.DotUI.GridY)
                            {
                                x = dot.DotUI.GridX;
                                y = dot.DotUI.GridY;
                                toReturn = dot;
                                min = current;
                            }
                        }
                        else if (y == dot.DotUI.GridY)
                        {
                            if (x > dot.DotUI.GridX)
                            {
                                x = dot.DotUI.GridX;
                                y = dot.DotUI.GridY;
                                toReturn = dot;
                                min = current;
                            }
                        }
                    }
                }
                return toReturn;
            }
            else
                throw new ArgumentOutOfRangeException("Fuck! Where are my yellow bricks?");
        }

        private Dot[] ExcludeOppositeDirection(Dot[] directions, Constants.Direction direction, bool isSpecialTurn)
        {
            Dot[] possible = new Dot[0];
            if (!isSpecialTurn)
            {
                switch (direction)
                {
                    case Constants.Direction.Down:
                        possible = new Dot[] { directions[1], directions[3], directions[2] };
                        break;
                    case Constants.Direction.Left:
                        possible = new Dot[] { directions[0], directions[1], directions[3] };
                        break;
                    case Constants.Direction.Right:
                        possible = new Dot[] { directions[0], directions[3], directions[2] };
                        break;
                    case Constants.Direction.Up:
                        possible = new Dot[] { directions[0], directions[1], directions[2] };
                        break;
                }
            }
            else
            {
                switch (direction)
                {
                    case Constants.Direction.Down:
                        possible = new Dot[] { directions[1], directions[3], directions[2] };
                        break;
                    case Constants.Direction.Left:
                        possible = new Dot[] { directions[1], directions[3] };
                        break;
                    case Constants.Direction.Right:
                        possible = new Dot[] { directions[3], directions[2] };
                        break;
                    case Constants.Direction.Up:
                        possible = new Dot[] { directions[0], directions[1], directions[2]};
                        break;
                }
            }
            return possible;
        }


        private Dot[] ExcludeWalls(Dot[] directions)
        {
            List<Dot> possible = new List<Dot>();
            foreach (Dot dot in directions)
            {
                if (dot.State != Constants.State.Wall)
                    possible.Add(dot);
            }
            Dot[] toReturn = new Dot[possible.Count];
            for (int i = 0; i < possible.Count; i++)
                toReturn[i] = possible[i];
            return toReturn;
        }

        internal Dot GoStraight(Dot origin, Constants.Direction direction)
        {
            changedDirection = Constants.Direction.None;
            Constants.Direction newDirection = Constants.Direction.None;
            if (origin.DotUI.GridX == 17 && (origin.DotUI.GridY < 1 || origin.DotUI.GridY > 26))
            {
                if (direction == Constants.Direction.Right && origin.DotUI.GridY == 27)
                    return _grid.GameGrid[17, 0];
                else if (direction == Constants.Direction.Left && origin.DotUI.GridY == 0)
                    return _grid.GameGrid[17, 27];
                else if (direction == Constants.Direction.Left && origin.DotUI.GridY == 27)
                    return _grid.GameGrid[17, 26];
                else if (direction == Constants.Direction.Right && origin.DotUI.GridY == 0)
                    return _grid.GameGrid[17, 1];
                else
                    throw new ArgumentOutOfRangeException("Holy crap! I'm trapped under ice!");
            }
            else
            {
                Dot[] temp = ExcludeWalls(ExcludeOppositeDirection(GetDotsAround(origin), direction, false));
                switch (direction)
                {
                    case Constants.Direction.Up:
                        if (_grid.GameGrid[origin.DotUI.GridX - 1, origin.DotUI.GridY] != temp[0])
                            newDirection = ChangeStraightDirection(origin, temp[0]);
                        break;
                    case Constants.Direction.Down:
                        if (_grid.GameGrid[origin.DotUI.GridX + 1, origin.DotUI.GridY] != temp[0])
                            newDirection = ChangeStraightDirection(origin, temp[0]);
                        break;
                    case Constants.Direction.Left:
                        if (_grid.GameGrid[origin.DotUI.GridX, origin.DotUI.GridY - 1] != temp[0])
                            newDirection = ChangeStraightDirection(origin, temp[0]);
                        break;
                    case Constants.Direction.Right:
                        if (_grid.GameGrid[origin.DotUI.GridX, origin.DotUI.GridY + 1] != temp[0])
                            newDirection = ChangeStraightDirection(origin, temp[0]);
                        break;
                }
                changedDirection = newDirection;
                return temp[0];
            }
        }

        private Constants.Direction ChangeStraightDirection(Dot origin, Dot destination)
        {
            if (_grid.GameGrid[origin.DotUI.GridX + 1, origin.DotUI.GridY] == destination)
                return Constants.Direction.Up;
            else if (_grid.GameGrid[origin.DotUI.GridX - 1, origin.DotUI.GridY] == destination)
                return Constants.Direction.Down;
            else if (_grid.GameGrid[origin.DotUI.GridX, origin.DotUI.GridY - 1] == destination)
                return Constants.Direction.Left;
            else if (_grid.GameGrid[origin.DotUI.GridX, origin.DotUI.GridY + 1] == destination)
                return Constants.Direction.Right;
            else
                throw new ArgumentOutOfRangeException("There are walls everywhere!");
        }

        internal Dot GetRandomWay(Dot origin, Constants.Direction direction)
        {
            Dot[] directions = ExcludeWalls(ExcludeOppositeDirection(GetDotsAround(origin), direction, false));
            Random rand = new Random();
            return directions[rand.Next(0, directions.Length)];
        }
    }
}
