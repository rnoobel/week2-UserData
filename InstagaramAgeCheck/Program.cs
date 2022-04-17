using System;

namespace InstagaramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaj avanust;
            //programm kontrollib, kas kasutaja on vähemalt 13 aastat vana või vanem;
            //kui kasutaja on vähemalt 13 aastat vana või vanem, siis ta võib instagram'i kasutada
            //kui kasutaja on noorem kui 13, siis ta on liiga noor.

            Console.WriteLine("Palun sisesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge > 13) 
            {
                Console.WriteLine("Oled piisavalt vana, et Instagram'i kontot luua.");
            }
            else if(userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagram'i kontot luua.");
            }
            else
            {
                Console.WriteLine("Oledki 13, nüüd saad endale Instagram'i kontot luua.");
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
