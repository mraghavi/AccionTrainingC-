// See https://aka.ms/new-console-template for more information
//Add sum of two numbers
int Sum(int a, int b)
{
   int sum = a + b;
    return sum;

}
Console.WriteLine("Enter  First Number:");
string num1= Console.ReadLine();
int number1 = int.Parse(num1);
Console.WriteLine("Enter  Second Number:");
string num2 = Console.ReadLine();
int number2 = int.Parse(num2);
int result = Sum(number1, number2);
Console.WriteLine(result);

Console.WriteLine("Press any key to Exit");
Console.ReadKey();