using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacMan.AI;

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
                            else if (j > 12 && j < 15)
                                _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.ExitTurn, i, j);
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
                        {
                            if (j > 12 && j < 15)
                                _gameGrid[i, j] = new Dot(Constants.State.Wall, Constants.Road.Straight, i, j);
                            else
                                _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        }
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
                        else if (j > 12 && j < 15)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, Constants.Road.Straight, i, j);
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
                        else if (j > 9 && j < 12)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j == 12)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                        else if (j > 12 && j < 15)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.ExitTurn, i, j);
                        else if (j == 15)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                        else if (j > 15 && j < 18)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j == 18)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Turn, i, j);
                        else if (j == 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                        else
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                    }

                    else if (i == 18)
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

                    else if (i == 19)
                    {
                        if (j < 5)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, i, j);
                        else if (j == 6)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 9)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                        else if (j == 18)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                        else if (j == 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j > 22)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, i, j);
                        else
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                    }

                    else if (i == 20)
                    {
                        if (j < 5)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, i, j);
                        else if (j == 6)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 9)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Turn, i, j);
                        else if (j > 9 && j < 18)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                        else if (j == 18)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Turn, i, j);
                        else if (j == 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j > 22)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, i, j);
                        else
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                    }

                    else if (i == 21)
                    {
                        if (j < 5)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, i, j);
                        else if (j == 6)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 9)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                        else if (j == 18)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, Constants.Road.Straight, i, j);
                        else if (j == 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j > 22)
                            _gameGrid[i, j] = new Dot(Constants.State.Empty, i, j);
                        else
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                    }

                    else if (i == 22)
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

                    else if (i == 23)
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
                            else if (j == 9)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else if (j == 18)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else if (j == 21)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        }
                    }

                    else if (i == 24)
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

                    else if (i == 25)
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

                    else if (i == 26)
                    {
                        if (j == 0)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j > 3 && j < 6)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j > 21 && j < 24)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j == 27)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else
                        {
                            if (j == 1)
                                _gameGrid[i, j] = new Dot(Constants.State.Energizer, Constants.Road.Straight, i, j);
                            else if (j == 6)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else if (j == 9)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else if (j == 12)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.SpecialTurn, i, j);
                            else if (j == 15)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.SpecialTurn, i, j);
                            else if (j == 18)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else if (j == 21)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else if (j == 26)
                                _gameGrid[i, j] = new Dot(Constants.State.Energizer, Constants.Road.Straight, i, j);
                            else
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        }
                    }

                    else if (i == 27)
                    {
                        if (j == 3)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 6)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 9)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 18)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 24)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                    }

                    else if (i == 28)
                    {
                        if (j == 3)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 6)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 9)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 18)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 21)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 24)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                    }

                    else if (i == 29)
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
                            if (j == 3)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else if (j == 24)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        }
                    }

                    else if (i == 30)
                    {
                        if (j == 1)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 12)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 15)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 26)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                    }

                    else if (i == 31)
                    {
                        if (j == 1)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 12)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 15)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else if (j == 26)
                            _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        else
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                    }

                    else if (i == 32)
                    {
                        if (j == 0)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else if (j == 27)
                            _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                        else
                        {
                            if (j == 12)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else if (j == 15)
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Turn, i, j);
                            else
                                _gameGrid[i, j] = new Dot(Constants.State.Food, Constants.Road.Straight, i, j);
                        }
                    }

                    else if (i == 33)
                        _gameGrid[i, j] = new Dot(Constants.State.Wall, i, j);
                    else
                        _gameGrid[i, j] = new Dot(Constants.State.Empty, i, j);
                }
        }

        internal void ChangeState(int x, int y, Constants.State newState)
        {
            _gameGrid[x, y].State = newState;
        }

        internal void OpenGate()
        {
            _gameGrid[15, 13].State = Constants.State.Empty;
            _gameGrid[15, 14].State = Constants.State.Empty;
            _gameGrid[16, 13].State = Constants.State.Empty;
            _gameGrid[16, 14].State = Constants.State.Empty;
        }

        internal void CloseGate()
        {
            _gameGrid[15, 13].State = Constants.State.Wall;
            _gameGrid[15, 14].State = Constants.State.Wall;
            _gameGrid[16, 13].State = Constants.State.Wall;
            _gameGrid[16, 14].State = Constants.State.Wall;
        }

        private int[] GetCoordinates(Dot dot)
        {
            return new int[2] { dot.DotUI.X, dot.DotUI.Y };
        }

        internal void Move(Move[] moves)
        {
            int[] origin;
            int[] destination;

            switch (moves.Length)
            {
                case 0:
                    break;
                case 1:
                    origin = GetCoordinates(moves[0].Origin);
                    destination = GetCoordinates(moves[0].Destination);
                    if (moves[0].Destination.State == Constants.State.Food)
                        moves[0].Destination.EatFood();
                    ChangeState(destination[0], destination[1], moves[0].Origin.State);
                    moves[0].Origin.SetDefaultState();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }
    }
}
