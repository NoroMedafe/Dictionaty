using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocabulary
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            string command = "";
            string userPassword = "";
           
            while (command != "Exit")
            {
                Console.Write("Введите команду:");
                command = Console.ReadLine();

                switch (command)
                {

                    case "SetName":

                        Console.Write("Введите имя:");
                        userName = Console.ReadLine();

                        Console.WriteLine();
                        Console.Write("имя задано.");

                        break;

                    case "ChangeConsoleColor":

                        Console.Write("1 - Красный; 2 - Зеленый; 3 - Синий; 4 - Стандартный:");
                        Console.Write("Выберите цвет:");
                        string consoleColor = Console.ReadLine();

                        switch (consoleColor)
                        {
                            case "1":
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case "2":
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            case "3":
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case "4":
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }

                        break;

                    case "SetPassword":

                        if (userPassword == "")
                        {
                            Console.Write("Задайте пароль:");
                            userPassword = Console.ReadLine();

                            Console.WriteLine();
                            Console.WriteLine("Пароль задан");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Чтобы поменять пароль нужно авторизоваться");
                            Console.Write("Введите пароль:");
                            string currentPassword = Console.ReadLine();

                            if (userPassword == currentPassword)
                            {
                                Console.Clear();
                                Console.WriteLine("Вход выполнен");
                                Console.WriteLine();

                                Console.Write("Задайте пароль:");
                                userPassword = Console.ReadLine();

                                Console.WriteLine();
                                Console.WriteLine("Пароль задан");
                            }

                        }

                        break;

                    case "WriteName":

                        if (userName != "")
                        {

                            if (userPassword != "")
                            {
                                Console.WriteLine("Чтобы вывести имя нужно ввести пароль");
                                Console.Write("Введите пароль:");
                                string currentPassword = Console.ReadLine();

                                if (currentPassword == userPassword)
                                {
                                    Console.WriteLine("Ваше имя: " + userName);
                                }

                            }
                            else
                            {
                                Console.WriteLine("Ваше имя: " + userName);
                            }

                        }
                        else
                        {
                            Console.WriteLine("Чтобы увидеть имя, для начала задайте его");
                        }

                        break;

                    case "Help":

                        Console.WriteLine("Все команды которые есть : SetName; ChangeConsoleColor; SetPassword; WriteName; Clear; Exit");

                        break;

                    case "Clear":

                        Console.Clear();

                        break;
                        
                }
            }
        }
    }
}
