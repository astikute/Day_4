﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int mainigais = 3;

            if (mainigais < 5)
            {
                Console.WriteLine("mazaks");
            }
            else
            {
                Console.WriteLine("lielaks");
            }

            string mainigais2 = "sdl";
            
            if (mainigais2 == "sdl")
            {
                Console.WriteLine("vienads");
            }
            else
            {
                Console.WriteLine("nav");
            }


            //Lietotajs ievada skaitli, ja lielaks par 5 - izvada ##, ja mazaks par 5 - #
            Console.Write("Ievadiet skaitli: ");
            string ievade = Console.ReadLine();
            int a = Convert.ToInt32(ievade);
            if (a < 5)
            {
                Console.WriteLine("#");
            }
            else if (a > 5)
            {
                Console.WriteLine("##");
            }
            else
            {
                Console.WriteLine("vienads");
            }
  
        
            //Exercise 37 - ievada skaitli - izvada atbilstoso figuru no stura skaita!
            Console.Write("Ievadiet skaitli: ");
            string nolasijums = Console.ReadLine();
            int b = Convert.ToInt32(nolasijums);

            if (b == 3)
            {
                Console.WriteLine("Figura: trissturis");
            }
            else
            {
                if (b == 4)
                {
                    Console.WriteLine("Figura: cetrsturis");
                }
                else
                {
                    if (b == 5)
                    {
                        Console.WriteLine("Figura: piecsturis");
                    }
                    else
                    {
                        Console.WriteLine("Figura: neatbilst nevienam");
                    }
                }
            }
            Console.Read();


            //tas pats uzdevums ar switch un case - tos izmanto, ja ir vairaki nosacijumi!

            nolasijums = Console.ReadLine();
            b = Convert.ToInt32(nolasijums);
            switch (b)
            {
                case 3:
                    Console.WriteLine("3-sturis");
                    break;
                case 4:
                    Console.WriteLine("4-sturis");
                    break;
                case 5:
                    Console.WriteLine("5-sturis");
                    break;
                default:
                    Console.WriteLine("kluda!");
                    break;
            }

            //to pasu var atkartot ari ar string!
            switch (ievade)
            {
                case "piecsturis":
                    Console.WriteLine("Ja!");
                    break;
            }
        }
    }
}
