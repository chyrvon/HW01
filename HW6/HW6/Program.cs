﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;



namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {

            //string value = Console.ReadLine();
            //ColorMy result;

            //Enum.TryParse(value, true, out result);

            //switch (result)
            //{
            //    case ColorMy.Red:
            //        Console.WriteLine("Red");
            //        break;
            //    case ColorMy.Green:
            //        Console.WriteLine("Green");
            //        break;
            //    case ColorMy.Blue:
            //        Console.WriteLine("Blue");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown color");
            //        break;
            //}

            /*TODO: 
            add Menu,
            1. Set number of lamps to Simple Garland
            2. Set number of lamps to Color Garland
            3. Set color to lamp (index)
            4. Get color of lamp (index)
            5. Print status of garland 
            6. Show garlands
            */

            UserMenu userMenu = new UserMenu();


            //Console.Write("Enter number of lamps in Simple Garland: ");
            //GetValue zxc = new GetValue();
            //int z = 5;
            //z = zxc.ReadValueConsoleToMenu();
            //int lamps = new GetValue().ReadValueConsoleToMenu();

            //int lamps;
            //Int32.TryParse(Console.ReadLine(), out lamps);



            ////get current time
            //string currentMinutes = DateTime.Now.ToShortTimeString();
            //Console.WriteLine($"Current time: {currentMinutes}");
            //Int32.TryParse(currentMinutes.Substring(currentMinutes.Length - 1), out int lastNumberMinute);


            //SimpleGarland simpleGarland = new SimpleGarland(lamps);
            //simpleGarland.PrintStatusGarland(lastNumberMinute % 2 == 0);
            //Console.ResetColor();
            //Console.ReadLine();



            //Console.Write("Enter number of lamps in Simple Garland: ");
            //Int32.TryParse(Console.ReadLine(), out int lamps);



            //////get current time
            //string currentMinutes = DateTime.Now.ToShortTimeString();
            //Console.WriteLine($"Current time: {currentMinutes}");
            //Int32.TryParse(currentMinutes.Substring(currentMinutes.Length - 1), out int lastNumberMinute);


            //SimpleGarland simpleGarland = new SimpleGarland(lamps);
            //simpleGarland.PrintStatusGarland(lastNumberMinute % 2 == 0);
            //Console.ResetColor();
            //Console.ReadLine();

        }
    }
}
