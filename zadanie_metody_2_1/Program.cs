using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_metody_2_1
{
    class Program
    {
        static int wholecredit = 700;

        static void Banking(int payment)
        {
            wholecredit -= payment;
            if (wholecredit == 0)
            {
                Console.WriteLine("кредит погашен");
            }
            else if (wholecredit != 0 && wholecredit > 0)
            {
                Console.WriteLine("Вам осталось внести: {0}", wholecredit);
                Console.WriteLine();
            }
            if (wholecredit < 0)
            {
                Console.WriteLine("Переплата составляе: {0}", wholecredit *  (-1));
            }
        }

        static void Main()
        {
            Banking(200);
            Banking(300);
            Banking(400);
            Console.ReadKey();
        }
    }
}
