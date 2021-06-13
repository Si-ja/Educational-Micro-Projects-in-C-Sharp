using System;
using Starting_with_Enums.Components;

namespace Starting_with_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Show the current date and time
            FindTime findTime = new();
            string currentTime = findTime.GetCurrentDate();
            Console.WriteLine(currentTime);
        }
    }
}
