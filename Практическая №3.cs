using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Оформление_окна_консоли
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Title = "Махвиладзе Давид";
            //Console.WindowWidth = 65;
            //Console.WindowHeight = 30;

            //Console.WriteLine("WindowWidth : "+ Console.WindowWidth ); //Ширина консоли
            //Console.WriteLine("WindowHeight: " + Console.WindowHeight); //Высота консоли

            //Console.WriteLine("Строка 1");//вывод строки (по умолчанию - белый цвет шрифта на черном фоне)
            //Console.BackgroundColor = ConsoleColor.DarkRed;//свойство установки белого цвета фона для текста
            //Console.ForegroundColor = ConsoleColor.DarkYellow;// свойство установки красного цвета шрифта
            //Console.WriteLine("Строка 2");// выводим строку
            //Console.ResetColor();// метод сброса настройки цвета на стандартные
            //Console.WriteLine("Строка 3");// выводим строку
            //Console.ForegroundColor = ConsoleColor.Cyan; // устанавливаем синий цвет шрифта
            //Console.WriteLine("Строка 4"); // выводим строку
            //Console.ResetColor();

            //Console.CursorVisible = false; // инициализациядля невидимого курсора
            //bool saveCursorVisibile = Console.CursorVisible;
            ////Console.CursorVisible = true; // инициализациядля видимого курсора
            ////bool saveCursorVisibile = Console.CursorVisible;
            //if (Console.CapsLock == true)
            //{ Console.WriteLine("The Caps Lock key is ON."); }
            //else
            //{ Console.WriteLine("The Caps Lock key is OFF."); }
            //if (Console.NumberLock == true)
            //{ Console.WriteLine("The Num Lock key is ON."); }
            //else
            //{ Console.WriteLine("The Num Lock key is OFF."); }
            //Console.ReadKey();

            //Задание 1

            //Console.Title = "Махвиладзе Давид"; //Имя студента

            //Console.WindowWidth = 50; // размер окна
            //Console.WindowHeight = 50;

            //Console.WriteLine("Введите ваше имя:");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Привет, {name}!");

            //Console.CursorVisible = false; //Невидимый курсор
            //bool saveCursorVisibile = Console.CursorVisible;

            //if (Console.CapsLock == true)
            //{ Console.WriteLine("The Caps Lock key is ON."); }
            //else
            //{ Console.WriteLine("The Caps Lock key is OFF."); }
            //if (Console.NumberLock == true)
            //{ Console.WriteLine("The Num Lock key is ON."); }
            //else
            //{ Console.WriteLine("The Num Lock key is OFF."); }

            //Console.ReadKey();

            //Задание 2

            /*
            // Устанавливаем размер окна и буфера
            Console.WindowWidth = 40;
            Console.WindowHeight = 40;

            // Запрашиваем символ у пользователя
            Console.Write("Введите символ для рисования ромба: ");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Сообщение о предстоящем рисунке
            Console.WriteLine($"Будет нарисован ромб из символов '{symbol}'");
            Console.ReadKey();

            Console.ReadKey();
            // Очищаем экран и устанавливаем цвета
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Gray;

            // Вычисляем координаты центра окна
            int centerX = Console.WindowWidth / 2;
            int centerY = Console.WindowHeight / 2;

            // Рисуем ромб
            for (int i = -3; i <= 3; i++)
            {
                for (int j = -3 + Math.Abs(i); j <= 3 - Math.Abs(i); j++)
                {
                    Console.SetCursorPosition(centerX + j, centerY + i);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Write(symbol);
                    Console.BackgroundColor = ConsoleColor.Red;
                }
            }

            // Задержка перед закрытием
            Console.ReadKey();
            */

            /*
            //Задание 3
            Console.ForegroundColor = ConsoleColor.Green;

            // Устанавливаем размер окна и буфера
            Console.WindowWidth = 40;
            Console.WindowHeight = 40;

            // Строка для анимации
            string text = "Движение";
            int x = Console.WindowWidth - text.Length; // Начальная позиция по горизонтали
            int y = 0; // Начальная позиция по вертикали

            while (y < Console.WindowHeight - 1 && x >= 0) // Цикл завершится, когда значение y доходит до последней строки в консоли
            {
                // Очищаем предыдущее положение строки
                Console.SetCursorPosition(x, y);
                Console.Write(new string(' ', text.Length));

                // Устанавливаем курсор и выводим текст только один раз
                Console.SetCursorPosition(x, y);
                Console.Write(text);

                // Перемещаем курсор вниз и влево
                y++;
                x--;

                // Пауза на 1 секунду
                Thread.Sleep(1000);
            */
            }
        }
    }
}

