// See https://aka.ms/new-console-template for more information
// find if number is odd or even


bool isEven(int number)
{
  int result = number % 2;

    if (result == 0)
    {
        return true;
    }
    else
    {
        return false;
    }

}
Console.WriteLine("Enter a number to know if it's Even:");
string num = Console.ReadLine();
int Num = int.Parse(num);
bool ans = isEven(Num);

Console.WriteLine(ans);
Console.WriteLine("Enter any key to exit");
Console.ReadKey();
