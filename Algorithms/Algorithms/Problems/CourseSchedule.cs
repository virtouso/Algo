using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Problems
{
    public class CourseSchedule
    {
        public bool CanFinish(int numCourses, int[][] prerequisites) {
     
            List<int>[] graph = new List<int>[numCourses];
            for (int i = 0; i < numCourses; i++) {
                graph[i] = new List<int>();
            }
            foreach (var prerequisite in prerequisites) {
                int course = prerequisite[0];
                int prereq = prerequisite[1];
                graph[course].Add(prereq);
            }

            // Step 2: Initialize arrays to keep track of visited nodes
            bool[] visited = new bool[numCourses];
            bool[] onPath = new bool[numCourses];

            // Step 3: Perform DFS to detect cycles
            for (int i = 0; i < numCourses; i++) {
                if (HasCycle(i, graph, visited, onPath)) {
                    return false; // Cycle detected
                }
            }

            return true; // No cycles, all courses can be finished
        }

        private bool HasCycle(int node, List<int>[] graph, bool[] visited, bool[] onPath) {
            if (visited[node]) {
                return false; // Node has already been visited and no cycle was found through it
            }
            if (onPath[node]) {
                return true; // Cycle detected
            }

            // Mark the node as being visited on the current path
            onPath[node] = true;

            // Perform DFS for all prerequisites of the current node
            foreach (int neighbor in graph[node]) {
                if (HasCycle(neighbor, graph, visited, onPath)) {
                    return true;
                }
            }

            // Mark the node as visited and remove it from the current path
            onPath[node] = false;
            visited[node] = true;

            return false;
        }
    }
}