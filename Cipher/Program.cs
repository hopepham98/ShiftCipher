using System;
using static System.Console;

/* Cipher by Hope Pham
 * PROG 101 (1), June 29, 2020
 * [Assisted by professor Janell Baxter]
 * Project: Code from GitHub page https://gist.github.com/janell-baxter/650c9e7b50fe760ef7d07f9b80b407e7
 * Code Author: https://gist.github.com/janell-baxter
 * More Info at Microsoft https://docs.microsoft.com/en-us/dotnet/api/system.string.contains?redirectedfrom=MSDN&view=netcore-3.1#System_String_Contains_System_String_
 */


namespace Cipher
{
    class Program
    {
        static void Main()
        {
            SetWindowSize(LargestWindowWidth - 110, LargestWindowHeight - 10);


           

            Title = "Cipher";







            start start = new start();
            start.Output();
            start.Name();
            Clear();

            cipher cipher = new cipher();
          

            








        }
    }
}
