using System;

namespace TwelveDaysOfChristmas
{
    class Program
    {

        static void Main(string[] args)
        {

            string[] days = { "first", "second", "third", "fourth", "fifth", "sixth", "seventh", "eighth", "ninth", "tenth", "eleventh", "twelfth" };
            string[] lines = {
                    "A Partridge in a Pear Tree!\n",
                    "Two Turtle Doves,",
                    "Three French Hens,",
                    "Four Calling Birds,",
                    "Five Goooolllldddd Rings!",
                    "Six Geese a Laying,",
                    "Seven Swans a Swimming,",
                    "Eight Maids a Milking,",
                    "Nine Ladies Dancing,",
                    "Ten Lords a Leaping,",
                    "Eleven Pipers Piping,",
                    "Twelve Drummers Drumming,",  
                };

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"On the {days[i]} day of Christmas,");
                Console.WriteLine("My true love sent to me,");
                for (int j = i; j >= 0; j--)
                {
                    if (i > 0)
                    {
                        lines[0] = "And a Partridge in a Pear Tree!\n";
                    }
                    Console.WriteLine(lines[j]);
                }
            }
        }
    }
}