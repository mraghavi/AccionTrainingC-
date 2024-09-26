// See https://aka.ms/new-console-template for more information
// Find the factorial of the number

int factorial(int number)
{
    int result = 1;

    if (number > 0)
    {
        for (int i = 1; i <= number; i++) { 
        result *= i;

        }
    }
    return result;

}

Console.WriteLine("Enter a number to get it's factorial");
string num = Console.ReadLine();
int Num = int.Parse(num);
int ans = factorial(Num);

Console.WriteLine(ans);
Console.WriteLine("Enter any key to exit");
Console.ReadKey();

