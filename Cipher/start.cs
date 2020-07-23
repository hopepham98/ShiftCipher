using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Globalization;

namespace Cipher
{
    public class start
    {
        public string name = "Anonymous Player";
        public void Output()
        {
            ForegroundColor = System.ConsoleColor.Magenta;

            TextInfo TitleCase = new CultureInfo("en-US", false).TextInfo;
          

            WriteLine("Hello anonymous player. What might be your name?");

            name = ReadLine();
            name = TitleCase.ToTitleCase(name);
            WriteLine("Hello " + name + "! Let's begin with our first message. Press any key to continue...");
            ReadLine();
            Clear();

        }

        public void Name()
        {
            WriteLine("Hello Agent" +name+ ".");
            Run();
        }

        public void Run()
        {

            cipher cipher = new cipher();
            string message;
            Clear();
            Write("Enter text: ");
            message = ReadLine();
            WriteLine(cipher.Encrypt(message));

            WriteLine("Press any key to continue...");
            ReadKey();
            Run();
        }
      

    }
   
}