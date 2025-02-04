using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a)");
            for (int i = 0; i < 4; i++) 
            {
                for (int j = 1; j <= 10; j++) 
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(); 

            
            Console.WriteLine("b)");
            int num = 41; 
            for (int i = 0; i < 4; i++) 
            {
                for (int j = 0; j < 10; j++) 
                {
                    Console.Write(num + " ");
                    num++; 
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            
            Console.WriteLine("в)");
            for (int i = 1; i <= 6; i++) 
            {
                for (int j = 0; j < i; j++) 
                {
                    Console.Write("5 ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            
            Console.WriteLine("г)");
            for (int i = 6; i > 0; i--) 
            {
                for (int j = 0; j < i; j++) 
                {
                    Console.Write("1 ");
                }
                Console.WriteLine();
            }
        }
    }
}
