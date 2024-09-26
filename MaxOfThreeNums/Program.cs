// See https://aka.ms/new-console-template for more information
// Find Maximum of three numbers
int MaxOfThreeNums( int a, int b , int c)
{
    int max = 0;
    int[] nums = { a, b, c };
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > max)
        {
            max = nums[i];
        }

    }
    return max;
}
Console.WriteLine("Enter First number");
string x = Console.ReadLine();
int num1 = int.Parse(x);
Console.WriteLine("Enter Second number");
string y = Console.ReadLine();
int num2 = int.Parse(y);
Console.WriteLine("Enter Third number");
string z = Console.ReadLine();
int num3 = int.Parse(z);

int result = MaxOfThreeNums(num1, num2, num3);
Console.WriteLine("The Maximum Number is: ");
Console.WriteLine(result);
Console.WriteLine("Enter any key to exit");
Console.ReadKey();
