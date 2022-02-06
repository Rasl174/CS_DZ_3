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
            int timeInLine;

            Console.Write("Введите количество старушек: ");
            numberOfOldLadies = Convert.ToInt32(Console.ReadLine());

            timeInLine = numberOfOldLadies * 10;

            int hour = timeInLine / 60;
            int minutes = timeInLine % 60;

            Console.Write("Вы должны остстоять в очереди " + hour + " часа и " + minutes + " минут ");

        }
    }
}
