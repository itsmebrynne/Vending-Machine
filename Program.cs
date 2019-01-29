using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility_App
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("╔╦╦╦═╦╗╔═╦═╦══╦═╗ ╔══╦═╗ ╔╗            ╔═╗           ╔╦╗              ╔╗╔╗      ");
            Console.WriteLine("║║║║╩╣╚╣═╣╬║║║║╩╣ ╚╗╔╣║║ ║╚╦╦╦╦╦═╦╦═╦╦═╣═╣ ╔═╦═╦═╦═╦╦╝╠╬═╦╦═╗ ╔══╦═╗╔═╣╚╬╬═╦╦═╗");
            Console.WriteLine("╚══╩═╩═╩═╩═╩╩╩╩═╝  ║║║║║ ║╬║╔╣║║║║║║║║╩╬═║ ╚╗║╔╣╩╣║║║╬║║║║║╬║ ║║║║╬╚╣═╣║║║║║║╩╣");
            Console.WriteLine("                   ╚╝╚═╝ ╚═╩╝╠╗╠╩═╩╩═╩═╩═╝  ╚═╝╚═╩╩═╩═╩╩╩═╬╗║ ╚╩╩╩══╩═╩╩╩╩╩═╩═╝");
            Console.WriteLine("                             ╚═╝                          ╚═╝                  ");      

            
            
            menu1();
            Console.ReadLine();
        }
        public static void menu1()
        {
            int input;
            Console.WriteLine("===================================");
            Console.WriteLine("|     Brynne's Vending Machine   | ");
            Console.WriteLine("===================================");
            Console.WriteLine("|           [1] Drinks           | ");
            Console.WriteLine("===================================");
            Console.WriteLine("|           [2] Snacks           | ");
            Console.WriteLine("===================================");
            Console.WriteLine("|        [3] CANCEL ORDER        | ");
            Console.WriteLine("===================================");

            Console.WriteLine("===================================");
            Console.WriteLine("|      Please select your order  | ");
            Console.WriteLine("===================================");
            Console.WriteLine("|          Press the number      | ");
            Console.WriteLine("===================================");
            input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Drinks();
                    break;
                case 2:
                    Snacks();
                    break;
                case 3:
                    exit();
                    break;
            }
        }
        public static void Drinks()
        {
            int input2;
            float cost = 0, money = 0, change;
            int ArwaMineralWater = 1, MountainDew = 3, Pepsi = 3, ChocolateMilk = 2, Coffee = 5;

            Console.WriteLine("=====================================");
            Console.WriteLine("|Welcome to Brynne's Vending Machine|");
            Console.WriteLine("=====================================");

            Console.WriteLine("=====================================");
            Console.WriteLine("|           Available Items:        | ");
            Console.WriteLine("=====================================");
            Console.WriteLine("| [1] Arwa Mineral Water (1 AED)    |");
            Console.WriteLine("=====================================");
            Console.WriteLine("| [2] Mountain Dew (3 AED)          |");
            Console.WriteLine("=====================================");
            Console.WriteLine("| [3] Pepsi (3 AED)                 |");
            Console.WriteLine("=====================================");
            Console.WriteLine("| [4] Chocolate Milk (2 AED)        |");
            Console.WriteLine("=====================================");
            Console.WriteLine("| [5] Coffee (5 AED)                |");
            Console.WriteLine("=====================================");

            Console.WriteLine("=====================================");
            Console.WriteLine("           [6] Go back               ");
            Console.WriteLine("=====================================");
            Console.WriteLine("       Please select a number        ");
            Console.WriteLine("=====================================");
            Console.WriteLine("           Press a Number            ");
            Console.WriteLine("=====================================");
            input2 = Convert.ToInt32(Console.ReadLine());

            switch (input2)
            {
                case 1:
                    Console.WriteLine("=====================================");
                    Console.WriteLine("|You selected [1] Arwa Mineral Water|");
                    Console.WriteLine("=====================================");

                    Console.WriteLine("===================================");
                    Console.WriteLine("|          Insert Money           |");
                    Console.WriteLine("===================================");

                    money = Convert.ToInt32(Console.ReadLine());
                    money = money - ArwaMineralWater;
                    break;
                case 2:
                    Console.WriteLine("=====================================");
                    Console.WriteLine("|   You selected [2] Mountain Dew   |");
                    Console.WriteLine("=====================================");

                    Console.WriteLine("===================================");
                    Console.WriteLine("|          Insert Money           |");
                    Console.WriteLine("===================================");

                    money = Convert.ToInt32(Console.ReadLine());
                    money = money - MountainDew;
                    break;
                case 3:
                    Console.WriteLine("=====================================");
                    Console.WriteLine("|      You selected [3] Pepsi       |");
                    Console.WriteLine("=====================================");

                    Console.WriteLine("===================================");
                    Console.WriteLine("|          Insert Money           |");
                    Console.WriteLine("===================================");

                    money = Convert.ToInt32(Console.ReadLine());
                    money = money - Pepsi;
                    break;
                case 4:
                    Console.WriteLine("=====================================");
                    Console.WriteLine("|  You selected [4] Chocolate Milk  |");
                    Console.WriteLine("=====================================");

                    Console.WriteLine("===================================");
                    Console.WriteLine("|          Insert Money           |");
                    Console.WriteLine("===================================");

                    money = Convert.ToInt32(Console.ReadLine());
                    money = money - ChocolateMilk;
                    break;
                case 5:
                    Console.WriteLine("=====================================");
                    Console.WriteLine("|     You selected [5] Coffee       |");
                    Console.WriteLine("=====================================");

                    Console.WriteLine("===================================");
                    Console.WriteLine("|          Insert Money           |");
                    Console.WriteLine("===================================");

                    money = Convert.ToInt32(Console.ReadLine());
                    money = money - Coffee;
                    break;
                case 6:
                    Console.WriteLine("Go back");
                    menu1();
                    break;

                default:
                    Console.WriteLine("Error");
                    break;

            }
            if (money >= cost)
            {
                Console.WriteLine("================================================");
                Console.WriteLine("|             Transaction Complete             |");
                Console.WriteLine("================================================");
                change = money - cost;
                Console.WriteLine("================================================");
                Console.WriteLine("|Please collect your remaining balance {0} AED.|", change);
                Console.WriteLine("================================================");
                Console.WriteLine("________$$$$_______________");
                Console.WriteLine("_______$$__$_______________");
                Console.WriteLine("_______$___$$______________");
                Console.WriteLine("_______$___$$______________");
                Console.WriteLine("_______$$___$$_____________");
                Console.WriteLine("________$____$$____________");
                Console.WriteLine("________$$____$$$__________");
                Console.WriteLine("_________$$_____$$_________");
                Console.WriteLine("_________$$______$$________");
                Console.WriteLine("__________$_______$$_______");
                Console.WriteLine("____$$$$$$$________$$______");
                Console.WriteLine("__$$$_______________$$$$$$");
                Console.WriteLine("_$$____$$$$____________$$$");
                Console.WriteLine("_$___$$$__$$$____________$$");
                Console.WriteLine("_$$________$$$____________$");
                Console.WriteLine("__$$____$$$$$$____________$");
                Console.WriteLine("__$$$$$$$____$$___________$");
                Console.WriteLine("__$$_______$$$$___________$");
                Console.WriteLine("___$$$$$$$$$__$$_________$$");
                Console.WriteLine("____$________$$$$_____$$$$");
                Console.WriteLine("____$$____$$$$$$____$$$$$$");
                Console.WriteLine("_____$$$$$$____$$__$$");
                Console.WriteLine("_______$_____$$$_$$$");
                Console.WriteLine("________$$$$$$$$$$");
                Console.WriteLine("Enjoy your drink!");
            }
            else
            {
                Console.WriteLine("Insufficient Fund");
            }
            Console.WriteLine("===================================================");
            Console.WriteLine("Press [X] to Continue, Press [B] to go back to menu");
            Console.WriteLine("===================================================");
            char input4;
            input4 = Convert.ToChar(Console.ReadLine());

            switch (input4)
            {
                case 'X':
                    exit();
                    break;
                case 'B':
                    menu1();
                    break;
            }
        }
        public static void exit()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("|Thank you for using Brynne's Vending Machine|");
            Console.WriteLine("|          Have a Marvelous DAY!             |");
            Console.WriteLine("==============================================");
            Console.ReadLine();
        }
        public static void Snacks()
        {
            int input3;
            float cost = 0, money = 0, change;
            int OmanChips = 2, SoharChips = 2, Cookies = 3, Falafel = 10, Muffin = 7;

            Console.WriteLine("=====================================");
            Console.WriteLine("|Welcome to Brynne's Vending Machine|");
            Console.WriteLine("=====================================");

            Console.WriteLine("=====================================");
            Console.WriteLine("           Available Items:          ");
            Console.WriteLine("=====================================");
            Console.WriteLine("| [1] Oman Chips (2 AED)            |");
            Console.WriteLine("=====================================");
            Console.WriteLine("| [2] Sohar Chips (2 AED)           |");
            Console.WriteLine("=====================================");
            Console.WriteLine("| [3] Cookies (3 AED)               |");
            Console.WriteLine("=====================================");
            Console.WriteLine("| [4] Falafel (10 AED)              |");
            Console.WriteLine("=====================================");
            Console.WriteLine("| [5] Muffin (7 AED)                |");
            Console.WriteLine("=====================================");

            Console.WriteLine("=====================================");
            Console.WriteLine("|           [6] Go back             |");
            Console.WriteLine("=====================================");
            Console.WriteLine("|        Please select a number     |");
            Console.WriteLine("=====================================");
            Console.WriteLine("|           Press a Number          |");
            Console.WriteLine("=====================================");

            input3 = Convert.ToInt32(Console.ReadLine());

            switch (input3)
            {
                case 1:
                    Console.WriteLine("=====================================");
                    Console.WriteLine("|     You selected [1] Oman Chips   |");
                    Console.WriteLine("=====================================");

                    Console.WriteLine("===================================");
                    Console.WriteLine("|          Insert Money           |");
                    Console.WriteLine("===================================");

                    money = Convert.ToInt32(Console.ReadLine());
                    money = money - OmanChips;
                    break;
                case 2:
                    Console.WriteLine("=====================================");
                    Console.WriteLine("|    You selected [2] Sohar Chips   |");
                    Console.WriteLine("=====================================");

                    Console.WriteLine("===================================");
                    Console.WriteLine("|          Insert Money           |");
                    Console.WriteLine("===================================");

                    money = Convert.ToInt32(Console.ReadLine());
                    money = money - SoharChips;
                    break;
                case 3:
                    Console.WriteLine("=====================================");
                    Console.WriteLine("|      You selected [3] Cookies     |");
                    Console.WriteLine("=====================================");

                    Console.WriteLine("===================================");
                    Console.WriteLine("|          Insert Money           |");
                    Console.WriteLine("===================================");

                    money = Convert.ToInt32(Console.ReadLine());
                    money = money - Cookies;
                    break;
                case 4:
                    Console.WriteLine("=====================================");
                    Console.WriteLine("|     You selected [4] Falafel      |");
                    Console.WriteLine("=====================================");

                    Console.WriteLine("===================================");
                    Console.WriteLine("|          Insert Money           |");
                    Console.WriteLine("===================================");

                    money = Convert.ToInt32(Console.ReadLine());
                    money = money - Falafel;
                    break;
                case 5:
                    Console.WriteLine("=====================================");
                    Console.WriteLine("|      You selected [5] Muffin      |");
                    Console.WriteLine("=====================================");

                    Console.WriteLine("===================================");
                    Console.WriteLine("|          Insert Money           |");
                    Console.WriteLine("===================================");

                    money = Convert.ToInt32(Console.ReadLine());
                    money = money - Muffin;
                    break;
                case 6:
                    Console.WriteLine("Go back");
                    menu1();
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }
            if (money >= cost)
            {
                Console.WriteLine("================================================");
                Console.WriteLine("|             Transaction Complete             |");
                Console.WriteLine("================================================");
                change = money - cost;
                Console.WriteLine("================================================");
                Console.WriteLine("|Please collect your remaining balance {0} AED.|", change);
                Console.WriteLine("================================================");
                Console.WriteLine("________$$$$_______________");
                Console.WriteLine("_______$$__$_______________");
                Console.WriteLine("_______$___$$______________");
                Console.WriteLine("_______$___$$______________");
                Console.WriteLine("_______$$___$$_____________");
                Console.WriteLine("________$____$$____________");
                Console.WriteLine("________$$____$$$__________");
                Console.WriteLine("_________$$_____$$_________");
                Console.WriteLine("_________$$______$$________");
                Console.WriteLine("__________$_______$$_______");
                Console.WriteLine("____$$$$$$$________$$______");
                Console.WriteLine("__$$$_______________$$$$$$");
                Console.WriteLine("_$$____$$$$____________$$$");
                Console.WriteLine("_$___$$$__$$$____________$$");
                Console.WriteLine("_$$________$$$____________$");
                Console.WriteLine("__$$____$$$$$$____________$");
                Console.WriteLine("__$$$$$$$____$$___________$");
                Console.WriteLine("__$$_______$$$$___________$");
                Console.WriteLine("___$$$$$$$$$__$$_________$$");
                Console.WriteLine("____$________$$$$_____$$$$");
                Console.WriteLine("____$$____$$$$$$____$$$$$$");
                Console.WriteLine("_____$$$$$$____$$__$$");
                Console.WriteLine("_______$_____$$$_$$$");
                Console.WriteLine("________$$$$$$$$$$");
                Console.WriteLine("Enjoy your snack!");
            }
            else
            {
                Console.WriteLine("Insufficient Fund");
            }
            Console.WriteLine("=====================================================");
            Console.WriteLine("|Press [X] to Continue, Press [B] to go back to menu|");
            Console.WriteLine("=====================================================");
            char input4;
            input4 = Convert.ToChar(Console.ReadLine());

            switch (input4)
            {
                case 'X':
                case 'x':
                    exit();
                    break;

                case 'b':
                case 'B':
                    menu1();
                    break;

                default:
                    break;

            }
            



























        }
    }
}
