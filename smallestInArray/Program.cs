// See https://aka.ms/new-console-template for more information

int smallestNum(int[] numbers)
{
    int smallest = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        // If the current number is smaller, update the smallest
        if (numbers[i] < smallest)
        {
            smallest = numbers[i];
        }
    }
    return smallest;
}


Console.WriteLine("Enter an array of numbers:");
int[] array = 
