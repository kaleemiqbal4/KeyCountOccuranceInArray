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