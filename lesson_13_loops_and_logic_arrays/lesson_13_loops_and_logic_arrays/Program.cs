int[] numbers = { 1, 2, 3, 4 };

int i = 0;
while (i < numbers.Length)
{
    Console.WriteLine(numbers[i++]);
}

Console.WriteLine($"Sum: {numbers.Sum()}");