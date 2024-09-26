// See https://aka.ms/new-console-template for more information
// check if the word is palindrome

bool isPalindrome(string word)
{
    word = word.ToLower();
    char[] charArray = word.ToCharArray();
    Array.Reverse(charArray);
    string reversedWord = new string(charArray);

    if (word == reversedWord){
  return true;
    }
    else
    {
        return false;
    
    }
     
}

Console.WriteLine("Enter a word:");
string palindrome = Console.ReadLine();
bool result = isPalindrome(palindrome);
Console.WriteLine(result);
Console.WriteLine("Enter any key to exit");
Console.ReadKey();

