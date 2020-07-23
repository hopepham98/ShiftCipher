# ShiftCipher :infinity:
This application was part of an assignment for my Summer 2020 Intro Programming class. An application that encodes and decodes using a simple substitution cipher.

## Assignment Challenge(s)
The biggest challenge that I face with this application was the idea or process behind it. I had to search the web for videos and other articles to explain the process or logic behind it. I understand a little bit, but not fully yet.

## Example of Code:

```markdown
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
```
