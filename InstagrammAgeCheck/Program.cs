﻿using System;

namespace InstagrammAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //programm kontrollib kas kasutaja on vanem kui 13 või 13 aastat vana
            //kui kasutaj on 13 aastat vana või vanem, siis võib Instagrammi kasutada
            //kui kasutaja on noorem kui 13, siis ta on liiga noor.

            Console.WriteLine("Palun, sisesta oma vanus");
            int userAge = Convert.ToInt32(Console.ReadLine());
            if (userAge > 13)
            {
            Console.WriteLine("Oled piisavalt vana, et Instagrammi kontot luua.");
             }
             else if(userAge < 13)
               {
             Console.WriteLine("Oled liiga noor, et Instagrammi kontot luua.");
                            }
             else
            {
                Console.WriteLine("Oled 13 ja võid Instagrammi konto luua.");
                            }
            Console.WriteLine("Kena päeva!");

          





        }
    }
}
