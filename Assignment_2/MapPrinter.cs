using System.Text;

namespace Kse.Algorithms.Samples
{
    using System;
    using System.Collections.Generic;

    public class MapPrinter
    {
        public void Print(string[,] maze)
        {
            PrintTopLine();
            for (var row = 0; row < maze.GetLength(1); row++)
            {
                Console.Write($"{row}\t");
                for (var column = 0; column < maze.GetLength(0); column++)
                {
                    Console.Write(maze[column, row]);
                }

                Console.WriteLine();
            }

            void PrintTopLine()
            {
                Console.Write($" \t");
                for (int i = 0; i < maze.GetLength(0); i++)
                {
                    Console.Write(i % 10 == 0? i / 10 : " ");
                }
    
                Console.Write($"\n \t");
                for (int i = 0; i < maze.GetLength(0); i++)
                {
                    Console.Write(i % 10);
                }
    
                Console.WriteLine("\n");
            }
        }
        public void Print(string[,] maze, List<Point> path)
        {
            int rows = maze.GetLength(0);
            int cols = maze.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Point current = new Point(i, j);
                    if (current.Equals(path[0]))
                    {
                        Console.Write("A");
                    }
                    else if (current.Equals(path[path.Count - 1]))
                    {
                        Console.Write("B");
                    }
                    else if (path.Contains(current))
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write(maze[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }
        


    }
    
    

}