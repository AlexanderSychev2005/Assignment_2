using Kse.Algorithms.Samples;
using System.Collections.Generic;

var generator = new MapGenerator(new MapGeneratorOptions()
{
    Height = 10,
    Width = 15,
    Seed = 3,
    Noise = 0.1f
});

string[,] map = generator.Generate();
var start = new Point(column: 0, row: 5);
var goal = new Point(row: 8, column: 14);
var cur_point = new Point()
var my_result = GetShortestPath(map, start, goal);

List<Point> GetShortestPath(string[,] map, Point start, Point goal)
{
    List<Point> result = new List<Point>();
    result.Add(start);
    result.Add(goal);
    new MapPrinter().Print(map, result);
    return result;
    
}

void BFS(Point start)
{
    var visited = new List<Point>();
    var queue = new Queue<Point>();
    queue.Enqueue(start);
    Visit(start);
    while (queue.Count > 0)
    {
        var next = queue.Dequeue();
        Print(graph);
        var neighbours = GetNeighbours(next.Row, next.Column, graph);
        foreach (var neighbour in neighbours)
        {
            if (!visited.Contains(neighbour))
            {
                Visit(neighbour);
                queue.Enqueue(neighbour);
            }
        }
    }
}
List<Point> GetNeighbours(int row, int column, string[,] maze)
{
    var result = new List<Point>();
    TryAddWithOffset(1, 0);
    TryAddWithOffset(-1, 0);
    TryAddWithOffset(0, 1);
    TryAddWithOffset(0, -1);
    return result;

    void TryAddWithOffset(int offsetRow, int offsetColumn)
    {
        var newX = row + offsetRow;
        var newY = column + offsetColumn;
        if (newX >= 0 && newY >= 0 && newX < maze.GetLength(0) && newY < maze.GetLength(1) && maze[newX, newY] != "#")
        {
            result.Add(new Point(newY, newX));
        }
    }




