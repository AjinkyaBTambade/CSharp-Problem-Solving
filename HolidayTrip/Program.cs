using System;
using System.Linq;

class Solution {
    public int solution(int[] P, int[] S) {
        int N = P.Length;
        
        // Calculate the total number of passengers
        int totalPassengers = P.Sum();
        
        // Calculate the capacity of each car
        int[] carCapacities = new int[N];
        for (int i = 0; i < N; i++) {
            carCapacities[i] = S[i];
        }
        
        // Sort car capacities in descending order
        Array.Sort(carCapacities);
        Array.Reverse(carCapacities);

        int carsUsed = 0;

        // Start filling cars from the one with the highest capacity
        foreach (int capacity in carCapacities) {
            totalPassengers -= capacity;
            carsUsed++;
            if (totalPassengers <= 0) {
                return carsUsed;
            }
        }
        
        // If we still have passengers left, return the number of cars used
        return carsUsed;
    }
}

class Program {
    static void Main(string[] args) {
        Solution solution = new Solution();
        
        // Example test cases
        Console.WriteLine(solution.solution(new int[] {1, 4, 1}, new int[] {1, 5, 1})); // Expected: 2
        Console.WriteLine(solution.solution(new int[] {4, 4, 2, 4}, new int[] {5, 5, 2, 5})); // Expected: 3
        Console.WriteLine(solution.solution(new int[] {2, 3, 4, 2}, new int[] {2, 5, 7, 2})); // Expected: 2
    }
}
