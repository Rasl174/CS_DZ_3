﻿using System;
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
            int timeOfReceipt = 10;
            int oneHour = 60;

            Console.Write("Введите количество старушек: ");
            numberOfOldLadies = Convert.ToInt32(Console.ReadLine());

            timeInLine = numberOfOldLadies * timeOfReceipt;

            int hourInLine = timeInLine / oneHour;
            int minutesInLine = timeInLine % oneHour;

            Console.Write("Вы должны остстоять в очереди " + hourInLine + " часа и " + minutesInLine + " минут ");

        }
    }
}
