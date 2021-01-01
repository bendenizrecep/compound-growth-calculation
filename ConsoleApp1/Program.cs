using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double money;
            int j;
            double percent;
            
            Console.WriteLine("Initial value:");
            money = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Number of periods:");
            j = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Compound growth rate:");
            percent = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= j; i++)
            {
                money = (money * percent) / 100 + money;
                Console.WriteLine(i + ".compound value =" + money);
                
            }
            
        }
    }
}
