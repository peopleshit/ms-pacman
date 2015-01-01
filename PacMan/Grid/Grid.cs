using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan.Grid
{
    internal class Grid
    {
        Dot[,] _gameGrid = new Dot[Constants.gridX, Constants.gridY];

        internal Dot[,] GameGrid
        {
            get { return _gameGrid; }
        }

        internal Grid()
        {
            for (int i = 0; i < Constants.gridX; i++)
                for (int j = 0; j < Constants.gridY; j++)
                {
                    if (i < 3)
                        _gameGrid[i, j] = new Dot(Constants.State.Empty, i, j);

                    else if (i == 3)
                        _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);

                    else if (i == 4)
                    {
                        if (j == 0)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j > 12 && j < 15)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j == 27)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else
                        {
                            if (j == 6)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else if (j == 21)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        }
                    }

                    else if (i == 5)
                    {
                        if (j == 1)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 6)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 12)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 15)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 26)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                    }

                    else if (i == 6)
                    {
                        if (j == 1)
                            _gameGrid[i, j] = new Dot(Constants.State.Energizer, Constants.Road.Straight, i, j);
                        else if (j == 6)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 12)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 15)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 26)
                            _gameGrid[i, j] = new Dot(Constants.State.Energizer, Constants.Road.Straight, i, j);
                        else
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                    }

                    else if (i == 7)
                    {
                        if (j == 1)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 6)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 12)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 15)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 26)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                    }

                    else if (i == 8)
                    {
                        if (j == 0)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j == 27)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else
                            if (j == 1)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else if (j == 6)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else if (j == 9)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else if (j == 12)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else if (j == 15)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else if (j == 18)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else if (j == 21)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else if (j == 26)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                    }

                    else if (i == 9)
                    {
                        if (j == 1)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 6)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 9)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 18)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 26)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                    }

                    else if (i == 10)
                    {
                        if (j == 1)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 6)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 9)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 18)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 26)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                    }

                    else if (i == 11)
                    {
                        if (j == 0)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j > 6 && j < 9)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j > 12 && j < 15)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j > 18 && j < 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j == 27)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else
                        {
                            if (j == 6)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else if (j == 21)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        }
                    }

                    else if (i == 12)
                    {
                        if (j == 6)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 12)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                        else if (j == 15)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                        else if (j == 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                    }

                    else if (i == 13)
                    {
                        if (j == 5)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j == 6)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j > 6 && j < 12)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j == 12)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                        else if (j > 12 && j < 15)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j == 15)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                        else if (j > 15 && j < 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j == 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 22)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, i, j);
                    }

                    else if (i == 14)
                    {
                        if (j == 5)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j == 6)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j > 6 && j < 9)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j > 8 && j < 19)
                        {
                            if (j == 12)
                                _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.SpecialTurn, i, j);
                            else if (j == 15)
                                _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.SpecialTurn, i, j);
                            else
                                _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                        }
                        else if (j > 18 && j < 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j == 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 22)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, i, j);
                    }

                    else if (i == 15)
                    {
                        if (j == 5)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j == 6)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j > 6 && j < 9)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j == 9)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                        else if (j > 9 && j < 18)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j == 18)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                        else if (j > 18 && j < 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j == 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 22)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, i, j);
                    }

                    else if (i == 16)
                    {
                        if (j == 6)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 9)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                        else if (j == 18)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                        else if (j == 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                    }

                    else if (i == 17)
                    {
                        if (j == 6)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                        else if (j == 9)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Turn, i, j);
                        else if (j == 12)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                        else if (j > 12 && j < 15)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Turn, i, j);
                        else if (j == 15)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                        else if (j == 18)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Turn, i, j);
                        else if (j == 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                        else
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                    }
                    else
                        _gameGrid[i, j] = new Dot(Constants.State.Bonus, i, j);
                }
        }

        internal void ChangeState(int x, int y, Constants.State newState)
        {
            _gameGrid[x, y].State = newState;
            _gameGrid[x, y].DotUI.UpdateDot(newState);
        }
    }
}
