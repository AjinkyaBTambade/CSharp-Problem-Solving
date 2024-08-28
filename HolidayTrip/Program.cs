using System;
using System.Linq;

class Solution {
    public int solution(int[] P, int[] S) {
        int N = P.Length;
        
        // Calculate free seats in each car
        int[] freeSeats = new int[N];
        for (int i = 0; i < N; i++) {
            freeSeats[i] = S[i] - P[i];
        }
        
        // Sort cars based on free seats in descending order
        Array.Sort(freeSeats);
        Array.Reverse(freeSeats);

        // Calculate the total number of passengers
        int totalPassengers = P.Sum();

        // Start filling the cars with the most free seats first
        int carsUsed = 0;
        for (int i = 0; i < N; i++) {
            totalPassengers -= S[i]; // Fill this car completely
            carsUsed++;
            if (totalPassengers <= 0) {
                break;
            }
        }
        
        return carsUsed;
    }
}

class Program {
    static void Main(string[] args) {
        // You can run your solution or test cases here
        Solution solution = new Solution();
        
        // Example test cases
        Console.WriteLine(solution.solution(new int[] {1, 4, 1}, new int[] {1, 5, 1})); // Expected: 2
        Console.WriteLine(solution.solution(new int[] {4, 4, 2, 4}, new int[] {5, 5, 2, 5})); // Expected: 3
        Console.WriteLine(solution.solution(new int[] {2, 3, 4, 2}, new int[] {2, 5, 7, 2})); // Expected: 2
    }
}