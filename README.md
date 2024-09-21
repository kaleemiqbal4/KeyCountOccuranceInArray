# Number Count Example

This C# console application demonstrates how to count the occurrences of numbers in an integer array using a dictionary.

## Description

The program initializes an array of integers and utilizes a `Dictionary<int, int>` to store the counts of each unique number. It iterates through the array, updating the count for each number found. Finally, it displays the results in the console.

## Code

```csharp
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 7, 4, 1, 3, 2, 7, 2, 2, 5, 6 };

        // Dictionary to hold counts of each number
        Dictionary<int, int> counts = new Dictionary<int, int>();

        // Using foreach to iterate over the array
        foreach (int number in arr)
        {
            if (counts.ContainsKey(number)) counts[number]++;
            else counts[number] = 1;
        }

        // Display the results
        foreach (var pair in counts)
        {
            Console.WriteLine($"Number: {pair.Key}, Count: {pair.Value}");
        }
    }
}
```
