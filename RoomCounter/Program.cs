using System;

public class Solution {
    public int solution(string[] a) {
        int rows = a.Length;
        int cols = a[0].Length;
        bool[,] visited = new bool[rows, cols];
        int numberOfRuns = 0;

        // Directions for moving up, down, left, and right
        int[] rowDir = { -1, 1, 0, 0 };
        int[] colDir = { 0, 0, -1, 1 };

        // DFS function to mark all connected 'a' cells
        void DFS(int r, int c) {
            visited[r, c] = true;
            for (int d = 0; d < 4; d++) {
                int newRow = r + rowDir[d];
                int newCol = c + colDir[d];
                if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols && 
                    a[newRow][newCol] == 'a' && !visited[newRow, newCol]) {
                    DFS(newRow, newCol);
                }
            }
        }

        // Main logic to find the number of connected components
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (a[i][j] == 'a' && !visited[i, j]) {
                    DFS(i, j);
                    numberOfRuns++;
                }
            }
        }

        return numberOfRuns;
    }
}

class Program {
    static void Main(string[] args) {
        Solution solution = new Solution();
        
        // Example test cases
        string[] plan1 = {
            "waw",
            "a.a",
            "waw"
        };
        Console.WriteLine(solution.solution(plan1)); // Expected: 3

        string[] plan2 = {
            "waw",
            "aaa",
            "waw"
        };
        Console.WriteLine(solution.solution(plan2)); // Expected: 1

        string[] plan3 = {
            "wwww",
            "wawa",
            "wawa",
            "wwww"
        };
        Console.WriteLine(solution.solution(plan3)); // Expected: 2
    }
}
