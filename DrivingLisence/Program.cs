using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanuse
            //kui kasutaja on noorem kui 18, siis programm kuvab konsoolis
            //"oled liiga noor, et juhilubasid saada"
            //kui kasutaja on vanem kui 18, siis programm kuvab konsoolis
            //"oled piisavalt vana, et juhiluad saada"
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne! Nüüd saad juhilubasid taotleda"

            Console.WriteLine("Palun, sisesta oma sünniaasta");
            int yearOfBirt = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirt;
            Console.WriteLine($"Oled {userAge} aastat vana .");

            if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhiluad saada.");
            }
            else if (userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilubasid saada.");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd saad juhilubasid taotleda!");
            }
            


        }
    }
}
