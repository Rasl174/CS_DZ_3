using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOldLadies;
            int time;

            Console.Write("Введите количество старушек: ");
            numberOfOldLadies = Convert.ToInt32(Console.ReadLine());

            time = numberOfOldLadies * 10;

            int chas = time / 60;
            int min = time % 60;

            Console.Write("Вы должны остстоять в очереди " + chas + " часа и " + min + " минут ");

        }
    }
}
