using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpımTablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 11;
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("");
                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine($" {j} * {i} = {i*j} ");
                    if (j == a)
                    {
                        Console.Write("");
                        
                    }
                    
                }

            }
            Console.ReadLine();
        }
    }
}
