using System;
using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class AStar
    {
        private class Node
        {
            public int X;
            public int Y;
            public int G; // Cost from start node to current node
            public int H; // Heuristic: estimated cost from current node to goal node
            public int F => G + H; // Total cost (G + H)
            public Node Parent;

            public Node(int x, int y)
            {
                X = x;
                Y = y;
            }
        }


        public List<(int, int)> FindPath(int[,] grid, (int, int) start, (int, int) goal)
        {
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);

            // Define offsets for 8 possible neighbors
            int[] dx = { -1, 0, 1, -1, 1, -1, 0, 1 };
            int[] dy = { -1, -1, -1, 0, 0, 1, 1, 1 };

            // Initialize open and closed sets
            var openSet = new List<Node>();
            var closedSet = new HashSet<Node>();

            // Create start and goal nodes
            Node startNode = new Node(start.Item1, start.Item2);
            Node goalNode = new Node(goal.Item1, goal.Item2);

            // Add start node to open set
            openSet.Add(startNode);

            while (openSet.Count > 0)
            {
                // Get node with lowest F value from open set
                Node current = openSet[0];
                for (int i = 1; i < openSet.Count; i++)
                {
                    if (openSet[i].F < current.F || (openSet[i].F == current.F && openSet[i].H < current.H))
                    {
                        current = openSet[i];
                    }
                }

                // Remove current node from open set and add it to closed set
                openSet.Remove(current);
                closedSet.Add(current);

                // If current node is the goal, reconstruct and return path
                if (current.X == goalNode.X && current.Y == goalNode.Y)
                {
                    List<(int, int)> path = new List<(int, int)>();
                    Node node = current;
                    while (node != null)
                    {
                        path.Add((node.X, node.Y));
                        node = node.Parent;
                    }

                    path.Reverse(); // Reverse the path to get it from start to goal
                    return path;
                }

                // Generate neighbors of current node
                for (int i = 0; i < 8; i++)
                {
                    int newX = current.X + dx[i];
                    int newY = current.Y + dy[i];

                    // Skip if out of bounds or blocked
                    if (newX < 0 || newX >= rows || newY < 0 || newY >= cols || grid[newX, newY] == 1)
                        continue;

                    Node neighbor = new Node(newX, newY);
                    neighbor.G = current.G + 1; // Cost of moving to neighbor is always 1

                    // Calculate heuristic (Manhattan distance)
                    neighbor.H = Math.Abs(newX - goalNode.X) + Math.Abs(newY - goalNode.Y);

                    // Check if neighbor is in closed set or open set
                    if (closedSet.Contains(neighbor))
                        continue;

                    // If neighbor is not in open set or has lower cost, update neighbor
                    if (!openSet.Contains(neighbor) || neighbor.G < current.G)
                    {
                        neighbor.Parent = current;
                        if (!openSet.Contains(neighbor))
                            openSet.Add(neighbor);
                    }
                }
            }

            // No path found
            return null;
        }
    }
}