using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Text;
using static System.Console;
using System.Linq;
using System.Text.RegularExpressions;

namespace Cipher
{
    public class cipher
    {
        string alphabet;
        string substitute;
     


        public cipher()
        {
          
            alphabet = "abcdefghijklmnopqrstuvwxyz";
            substitute = "opdefghiqrsxyzabcjklmntuvw";
        }
        public string Encrypt(string _message)
        {
            ForegroundColor = System.ConsoleColor.DarkYellow;
            

            int index;
            char replacement = 'z';
            string result = "";
            _message = _message.ToLower();


            foreach (char x in _message)
            {
                string saying = "Hello everyone!";
                char[] charArray = { 'W', 'o', 'r', 'l', 'd' };
                WriteLine("The old saying: {0}", new string(charArray));
                saying.CopyTo(0, charArray, 0, 5);
                WriteLine("The new saying: {0}", new string(charArray));


            }


            return result;
        }

        public string Decrypt(string _message)
        {
            string result = "";
            return result;
        }
    
    }
   

}
