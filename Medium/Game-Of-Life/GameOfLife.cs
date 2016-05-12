using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    { 
         string[] lines = File.ReadAllLines(args[0]);
            GameOfLifeSim life = new GameOfLifeSim();
            life.InitalizeSimulation(lines, '*', '.');

            // Question: Do I need 10 Generations or 11?
            // Run the simulation for 10 iterations
            for (int i = 0; i < 10; i++) { life.UpdateSimulation(); }
            life.DrawSimulation();
    }
    class GameOfLifeSim
        { 
            bool[,] currentState, newState;
            char alive = '*', death = '.';
            int generation = 0;
             
            public void InitalizeSimulation(string[] seedState, char alive = '*', char death = '.')
            {
                this.alive = alive;
                this.death = death;
                generation = 0;
                currentState = new bool[seedState.Length, seedState[0].Length];
                newState = new bool[seedState.Length, seedState[0].Length];

                for (int y = 0; y < seedState.Length; y++)
                {
                    for (int x = 0; x < seedState[0].Length; x++)
                    {
                        bool state = seedState[y][x] == alive ? true : false;
                        currentState[y, x] = state;
                    }
                }
            }

            public void DrawSimulation()
            { 
                char[] output = new char[currentState.GetLength(1)];
                for (int y = 0; y < currentState.GetLength(0); y++)
                {
                    for (int x = 0; x < currentState.GetLength(1); x++)
                    {
                        bool state = currentState[y, x];
                        output[x] = state ? alive : death;
                    }

                    Console.WriteLine(output);
                }
            }

            public void UpdateSimulation()
            { 
                for (int y = 0; y < currentState.GetLength(0); y++)
                {
                    for (int x = 0; x < currentState.GetLength(1); x++)
                    { 

                        bool state = currentState[y, x];
                        int aliveCount = GetAliveNeighboursCount(y, x);
                        if (aliveCount < 2 || aliveCount > 3) { newState[y, x] = false; }
                        else if (aliveCount == 3) { newState[y, x] = true; }
                        else { newState[y, x] = state; }
                    }
                }
                 
                var temp = currentState;
                currentState = newState;
                newState = temp;
                generation++;
            }

            private int GetAliveNeighboursCount(int y, int x)
            {
                int aliveCount = 0;
                for (int row = y - 1; row <= y + 1; row++)
                {
                    for (int column = x - 1; column <= x + 1; column++)
                    { 
                        if (row == y && column == x) { continue; }
                        if (row >= 0 && row < currentState.GetLength(0) && column >= 0 && column < currentState.GetLength(1))
                        {
                            aliveCount += currentState[row, column] ? 1 : 0;
                        }
                    }
                }

                return aliveCount;
            }

        }
} 
