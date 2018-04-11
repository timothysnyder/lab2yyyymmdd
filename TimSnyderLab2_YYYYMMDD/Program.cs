using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimSnyderLab2_YYYYMMDD
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This Program Will Display the Difference Between Two Dates: ");

            Console.WriteLine("Please Enter a Date and Time in yyyy-mm-dd 00:00 Format: ");

            string entry1 = Console.ReadLine();

            Console.WriteLine("Please Enter Another Date and Time in yyyy-mm-dd 00:00 Format: ");

            string entry2 = Console.ReadLine();



            DateTime dateStart = DateTime.Parse(entry1);

            DateTime dateEnd = DateTime.Parse(entry2);


            int yearDifference = Convert.ToInt32(dateEnd.Year) - Convert.ToInt32(dateStart.Year);

            int monthDifference = Math.Abs(Convert.ToInt32(dateEnd.Month) - Convert.ToInt32(dateStart.Month));

            int days = (dateEnd - dateStart).Days;
            
            TimeSpan span = dateEnd.Subtract(dateStart);


            Console.WriteLine("Time Difference (years): " + yearDifference.ToString());

            Console.WriteLine("Time Difference (months): " + monthDifference.ToString());

            Console.WriteLine("Time Difference (days): " + span.Days);

            Console.WriteLine("Time Difference (hours): " + span.Hours);

            Console.WriteLine("Time Difference (minutes): " + span.Minutes);



            Console.WriteLine("Press Enter to end. ");

            Console.ReadLine();
        }
    }
}
