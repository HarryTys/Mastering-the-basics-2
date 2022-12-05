using System;
using System.Threading;

namespace Palidrome
{
    class Palidrome
    {
        static void Main()
        {
            char[] listOfCharacters = new char[]{' ', '\'', '?', '!'};
            Console.WriteLine("Enter a string to be checked...");   string enteredString = Console.ReadLine().ToLower();
            if (string.IsNullOrEmpty(enteredString)) { Console.WriteLine("This is not a palidrome"); Thread.Sleep(2000); Environment.Exit(0); }
            if (enteredString.IndexOfAny(listOfCharacters) >= 0) { enteredString = enteredString.Replace(Convert.ToString(listOfCharacters), ""); }
            for (int x = 0; x < Math.Floor((double)enteredString.Length / 2); x++)
            {
                if (enteredString[x] == enteredString[enteredString.Length - 1 - x]) { }
                if (enteredString[x] != enteredString[enteredString.Length - 1 - x])
                {   Console.WriteLine("This is not a palidrome."); Thread.Sleep(2000); Environment.Exit(0); }
                Console.WriteLine("This is a palidrome."); Thread.Sleep(2000); Environment.Exit(0);
            }
        }
    }
}