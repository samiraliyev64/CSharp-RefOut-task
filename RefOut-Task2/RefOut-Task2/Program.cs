using System;

namespace RefOut_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = " Hikmet  Abbasov ";

            RemoveWhiteSpace(ref name);

            Console.WriteLine(name);
        }

        static void RemoveWhiteSpace(ref string text)
        {
            string newStr = "";

            foreach  (char letter in text)
            {
                if(letter == ' ')
                {
                    continue;
                }
                else
                {
                    newStr += letter;
                }
            }

            text = newStr;
        }
    }
}
