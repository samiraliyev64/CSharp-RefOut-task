using System;

namespace RefOut_Task3
{
    class Program
    {

        static void Main(string[] args)
        {
            int myNum = 127;
            SquareRoot(ref myNum);
            Console.WriteLine(myNum);
        }

        static void SquareRoot(ref int num)
        {
            bool isTrue = true;
            
            for (int i = num; i >= 1; i--)
            {
                if (isTrue) 
                { 
                    for (int j = 0; j * j < num; j++)
                    {
                        if (j * j == i)
                        {
                            num = j;
                            isTrue = false;
                        }
                    }
                }

                else 
                {
                    break; 
                }
            }

            
        }
    }
}
