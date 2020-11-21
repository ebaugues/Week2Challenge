using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenge
{
    class Greeter
    {

        public string GetName()
        {
            Console.WriteLine("Please enter your name:");
            string newName = Console.ReadLine();
            Console.WriteLine($"Your Name is {newName}.");
            return newName;
       
        }

        public void ExitMessage(string Name)
        {
            Console.WriteLine($"Thanks for playing {Name}.  Please try again!");

        }

        public void TimeofDay()
        {
            DateTime CurrentDate = DateTime.Now;
            string TimeNow = CurrentDate.TimeOfDay.ToString();

            Console.WriteLine($"Time of Day {TimeNow}");

            //split time
            string sub = TimeNow.Substring(0, 2);
            int HourNumber = Convert.ToInt16(sub);
            Console.WriteLine($"Test HourNumber {HourNumber}");
            if ((HourNumber > 0) && (HourNumber < 7))
            {
                Console.WriteLine("Night!");

            }
            else if ((HourNumber > 7) && (HourNumber < 12))
            {
                Console.WriteLine("Morning");
            }

            else if ((HourNumber >= 12) && (HourNumber < 17))
            {

                Console.WriteLine("Afternoon");
            }
            else if ((HourNumber >= 17) && (HourNumber < 24))
            {

                Console.WriteLine("Evening");
            }
            else
            {
                Console.WriteLine("I don't know what time it is.");
            }


        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Greeter Person = new Greeter();
            string Name = Person.GetName();
            Person.ExitMessage(Name);
            Person.TimeofDay();

            Console.WriteLine("Hit any key to exit...");
            Console.ReadLine();

        }

    }
}
