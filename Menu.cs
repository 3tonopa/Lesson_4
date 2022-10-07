using System;

namespace MainMenu
{
    class Menu
    {
        public static void Main(string[] args)

        {
            MainMenu();
        }
            #region
        public static void MainMenu()

        {
            Console.Clear();
            bool flag = true;

            while (flag)

            {
                Console.WriteLine("Задачи №1-3, работа с классом массива.      Нажмите  [1]");
                Console.WriteLine("Задача №2(б), создание массива из файла.    Нажмите  [2]");
                Console.WriteLine("Задача №3, проверка логина-пароля из файла. Нажмите  [3]");
                Console.WriteLine("Для выхода нажмите [0]" +
                "                  ");
                Console.WriteLine();
                Console.Write("Выбор: ");

                int num = int.Parse(Console.ReadLine());

                switch (num)
                {

                    case 0:
                        Console.WriteLine("Выход");
                        flag = false;
                        break;

                    case 1:
                        Task1.Program.Prog(); //Выполнение Задачи №1 работа с классом массива
                        break;

                    case 2:
                        Task1.MyArray.ArrayReadFile("..\\..\\..\\data.txt"); //Выполнение Задачи №2(б) создание массива из файла
                        break;

                    case 3:
                        Task4.Program.Prog(); //Выполнение Задачи №3 проверка логина-пароля из файла
                        break;
                    
                }

                if (num > 3 && true)

                {
                    Console.WriteLine("Вы ввели неправильный номер, нажмите Enter и повторите попытку.");
                    Console.ReadKey();
                    MainMenu();
                }

                if (false)
                { }

                break;
            }
            #endregion
        }
    }
}
