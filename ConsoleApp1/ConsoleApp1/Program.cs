using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Command Line Example");

            // Check for null array
            if (args == null)
            {
                Console.WriteLine("Array args is null");
            }
            else
            {
                Console.Write("args length is {0} \n", args.Length);

                //Loop through array
                for (int i = 0; i < args.Length; i++)
                {
                    string argument = args[i];

                    Console.Write("args index is {0} ", i);
                    Console.Write("args value is [{0}] \n", argument);
                }
            }

            //Console.ReadLine();
        }
    }
}

