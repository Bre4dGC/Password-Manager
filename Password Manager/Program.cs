﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Password_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* вк.ком-мунизм
            старчекласники
            ютуб.какВыраститьДебила
            меил.русь */

            string passVk = "каждыйМожетКинутьКаменьвВолкаНоНеКаждыйМожетКинутьВолкавКамень",
            passOk = "Людмила1964", passYt = null, passMail = "KupitmanIvanNatanych", password = "bibabredow";
            string userPassword = null;

            bool isOpen = false;

            Console.Write("Введите пароль: ");
            string userInput = Console.ReadLine();

            if (userInput != password) 
            {
                Console.Write("Пароль не верный");
            }
            else
            {
                isOpen = true; Console.Clear();
            }

            while ( isOpen )
            {
                Console.SetCursorPosition(15, 0);
                Console.WriteLine("|МЕНЕДЖЕР ПАРОЛЕЙ|");
                
                Console.SetCursorPosition(10, 15);
                Console.Write("Ресурсы \nвк.ком-мунизм\nстарчекласники\nютуб.какВыраститьДебила\nмеил.русь");
                
                Console.SetCursorPosition(10, 10);
                Console.WriteLine("Команды\n'1' - Поиск пароля для ресурса\n'2' - Поменять пароль");

                Console.SetCursorPosition(0, 1);
                Console.Write("Введите команду: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("\nВведите ресурс:");
                        switch (Console.ReadLine())
                        {
                            case "вк.ком-мунизм":
                                Console.WriteLine("Пароль - " + passVk);
                                break;
                            case "старчекласники":
                                Console.WriteLine("Пароль - " + passOk);
                                break;
                            case "ютуб.какВыраститьДебила":
                                Console.WriteLine("Пароль - " + passYt);
                                break;
                            case "меил.русь":
                                Console.WriteLine("Пароль - " + passMail);
                                break;
                            default:
                                Console.Write("Неизвестный ресурс");
                                break;
                        }
                        Console.ReadKey(); Console.Clear(); break;

                    case "2":
                        Console.Write("\nВведите ресурс: ");

                        switch (Console.ReadLine())
                        {
                            case "вк.ком-мунизм":
                                Console.Write("\nКакой пароль поставить: ");
                                userPassword = Console.ReadLine();
                                passVk = userPassword;
                                break;
                            case "старчекласники":
                                Console.Write("\nКакой пароль поставить: ");
                                userPassword = Console.ReadLine();
                                passOk = userPassword;
                                break;
                            case "ютуб.какВыраститьДебила":
                                Console.Write("\nКакой пароль поставить: ");
                                userPassword = Console.ReadLine();
                                passYt = userPassword;
                                break;
                            case "меил.русь":
                                Console.Write("\nКакой пароль поставить: ");
                                userPassword = Console.ReadLine();
                                passMail = userPassword;
                                break;
                            default:
                                Console.Write("Неизвестный ресурс");
                                break;
                        }
                        Console.WriteLine($"\nПароль успешно поменялся на {userPassword} \n-аххаха чувак ты что серьезно что это за пароль XD");
                        Console.ReadKey(); Console.Clear();break;
                    default:
                        Console.Write("Неизвестная команда");
                        break;
                }
            }
        }
    }
}
