using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mustafa_Gürbay_221120241053
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.Write("birinci sayıyı giriniz: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("ikinci sayıyı giriniz: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Clear();

            if (num1 == 1) num1++;


            for (int num = num1; num <= num2; num++)
            {
                int control = 0;

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0) { control = 1; break; }
                }
                if (control == 1)
                {
                    Console.WriteLine($"{num} sayısı asal değildir");
                }
                if (control == 0)
                {
                    Console.WriteLine($"{num} sayısı asaldır");
                    count++;
                }

            }

            Console.ReadKey();

        }
    }
}
