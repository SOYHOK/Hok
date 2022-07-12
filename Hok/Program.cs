using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FirstInterger;
            int SecondInterger;

            Console.WriteLine("This program adds for you two intergers");
            Console.Write("Type the 1st interger: ");
            FirstInterger = int.Parse(Console.ReadLine());

            Console.Write("Type the 2nd interger: ");
            SecondInterger = int.Parse(Console.ReadLine()); 

            Console.WriteLine((FirstInterger + SecondInterger));


        }
    }
}