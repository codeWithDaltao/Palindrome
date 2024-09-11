namespace Palindrome
{
    public class Polindrome
    {
        public static bool FirstQueue(string input)
        {
            if (input.Length > 0) return true;
            return false;
        }

        public string SecondQueue(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public bool LoopToCompare(string input, string reverseString)
        {
            if (input == reverseString) return true;
            return false;
        }
    }
}