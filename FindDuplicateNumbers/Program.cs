void FindDuplicates(int[] array)
{
    HashSet<int> seen = new HashSet<int>();
    List<int> duplicates = new List<int>();

    foreach (int num in array)
    {
        if (seen.Contains(num))
        {
            duplicates.Add(num);
        }
        else
        {
            seen.Add(num);
        }
    }

    Console.WriteLine("Duplicate Numbers: " + string.Join(", ", duplicates));
}

// Example Usage
int[] numbers = { 1, 3, 5, 5, 6, 7, 6, 2, 8 };
FindDuplicates(numbers);
// Output: Duplicate Numbers: 5, 6
