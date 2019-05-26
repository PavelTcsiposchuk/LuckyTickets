using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTickets
{
    public class UI
    {
        #region Methods

        public static void ShowInstruction()
        {
            Console.WriteLine("============Task 2============");
            Console.WriteLine("Вам нужно ввести путь к файлу, в котором первая строка тип билета(Moskow/Piter)," +
                " вторая и третья - начало и конец диапазона билетов(только числа больше 1 и меньше 100000)");
            Console.WriteLine("Пример : D:\\\\Filename.txt ");
        }
        private static void ShowInstructionWrongPath()
        {
            Console.WriteLine("Ошибка, по указанному пути файла не существует");
            Console.WriteLine("Введите еще раз, пример - D:\\Папка\\filename.txt");

        }
        public static string GetPath()
        {
            string path = Console.ReadLine();
            bool isPathValid = File.Exists(path);

            while (!isPathValid)
            {
                ShowInstructionWrongPath();
                path = Console.ReadLine();
                isPathValid = File.Exists(path);
            }

            return path;
        }
        public static void ShowError(string message)
        {
            Console.Write(message);
        }
        public static void ShowInformationAboutAnalyzator(string type, string startRange, string endRange)
        {
            Console.WriteLine(string.Format("Подсчет счастливых билетов в диапазоне от {1} до {2} введется по {0} способу", type, startRange, endRange));
        }
        public static void ShowCountLuckyTickets(int countLuckyTickets)
        {
            Console.WriteLine(string.Format("В заданном диапазоне находится {0} счастливых билетов", countLuckyTickets));
        }

        #endregion

    }
}
