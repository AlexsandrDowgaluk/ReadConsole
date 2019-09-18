using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReadConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                bool endApp = false;
                while (!endApp)
                {
                    Trying();
                        Console.Write("Нажмите q для закрытия приложения " + "Для продолжения нажмите Enter");
                    if (Console.ReadLine() == "q") endApp = true;

                    Console.WriteLine("\n");
                }

            }

        }
        public static char Trying()
        {
            while (true)
            {
               
                Console.WriteLine("Введите букву: ");
                string input = Console.ReadLine();
              
                if (input.Length == 1 && Regex.IsMatch(input, @"[а-яА-Я]"))
                {
                    char c =  Convert.ToChar(input);
                       int ascii = (int)c;
                                     int nextAscii = ascii + 1;
                                        char nextChar = (char)nextAscii;
                    Console.WriteLine("Вы ввели букву   " + nextChar);
                    return input[0];
                }
                else if (input.Length > 1 ){
                    Console.WriteLine("Введите одну букву");

                    return input[0];
                }
                else if (Regex.IsMatch(input, @"[a-zA-Z]") & !Regex.IsMatch(input, @"[0-9]"))
                {
                    Console.WriteLine("You entered the letter  " +input);
                    return input[0];
                }
                else if (Regex.IsMatch(input, @"[0-9]") )
                {
                    Console.WriteLine("Вы ввели цифру введите букву! " );
                    return input[0];
                }

                else
                    Console.WriteLine("Пожалуйста, вводите русскую букву");
            }
        }
    }
    
}
