using Palindrome;

Polindrome polindrome = new();
Console.WriteLine("enter words");
string input = Console.ReadLine();
string reversed = polindrome.SecondQueue(input);

if (polindrome.LoopToCompare(input,reversed))
{
    Console.WriteLine("is a polindrome");
}

else
{
    Console.WriteLine("not a polindrome");
}