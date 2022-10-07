using System;
using System.IO;
namespace Task4
{
    struct Account
    {
        public string login;
        public string password;

        public Account(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
        public void Info()
        {
            Console.WriteLine($"Логин: {login}  Пароль: {password}");
        }
        public string Logpwd()
        {
            string name = login + ":" + password;
            return name;
        }
    }

    public class PwdArray
    {
        public string[] pwdarray;
        public PwdArray(string filename)
        {
            int count = File.ReadAllLines(filename).Length;
            
            pwdarray = new string[count];
            StreamReader sr = new StreamReader(filename);

            for (int i = 0; i < count; i++)
            {
                pwdarray[i] = sr.ReadLine();
            }
            sr.Close();
        }
        public bool Flag(string checkpair)
        {
            bool c = true;
            
            foreach (string strLine in pwdarray)
            {
                if (strLine.Contains(checkpair)) 
                {
                    c = true;
                    return c;
                }
                c = false;
            }
            return c;
        }
    }
    public class Program
    {
        public static void Prog()
        {
            string login;
            string pwd;
            Console.Clear();
            string filename = "..\\..\\..\\passwd.txt";

            string checkpair;
            PwdArray pwdarray = new PwdArray(filename);

            Console.WriteLine("Задача №4.Реализовать метод проверки логина и пароля из файла." +
                "                                                                     ");
            Console.WriteLine("Логин: ");
            login = Console.ReadLine();
            Console.WriteLine("Пароль: ");
            pwd = Console.ReadLine();
            checkpair = login + ":" + pwd;
            bool res = pwdarray.Flag(checkpair);
            
            if (res == true)
            {
                
                Console.WriteLine("Вы ввели ВЕРНЫЕ логин и пароль!!!");
                
                var usera = new Account($"{login}", $"{pwd}");
                usera.Info();
                Console.WriteLine($"Учетная запись: {usera.Logpwd()}"); 

                Console.WriteLine("Нажмите Enter для возврата в меню.");
                Console.ReadKey();
                MainMenu.Menu.MainMenu();
                return;
            }
            if(res == false)
            {
                var userb = new Account($"{login}", $"{pwd}");
                userb.Info();
                Console.WriteLine($"Учетной записи: {userb.Logpwd()} не найдено");

                Console.WriteLine("Вы ввели НЕВЕРНЫЕ логин или пароль!!!");
                Console.WriteLine("Нажмите Enter для возврата в меню.");
                Console.ReadKey();
                MainMenu.Menu.MainMenu();
                return;
            }
        }
    }
}
