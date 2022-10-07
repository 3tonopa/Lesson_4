using System;
using System.IO;
namespace Task1 // Д/З урок 4. Стрелков Максим
                //Задачи 1-3
{
   
    public class MyArray 
    {
        int[] arr; 
        public MyArray(int n, int min, int max)//Создание массива по введенным параметрам
        {

            arr = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(min, max);
        }
        public int Sum //Сумма элементов массива
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sum += arr[i];
                }
                return sum;
            }
        }
        public override string ToString() //Метод вывода всех значений массива
        {
            string s = "";
            foreach (int v in arr)
                s = s + v + " ";
            return s;
        }
        public int MaxCount(int max) //свойство, возвращающее количество максимальных элементов на основе значения заданного при создании массива
        {
                int count = 0;

                for (int i = 0; i < arr.Length; i++)

                    if (arr[i] == max-1)

                        count++;

                return count;
        }
        public void pair3count() //Метод подсчета пар чисел одно из которых делится на 3
        {
            
                int count = 0;
                for (int i = 0; i < arr.Length - 1; i++)

                    if (arr[i] % 3 == 0 | arr[i + 1] % 3 == 0)
                        count++;
            Console.WriteLine($"Количество пар с числом делимым на 3: {count}");


        }
        public void Inverse() //метод создания массива с измененными знаками значений
        {
            int[] invarr;
            int N = arr.Length;

            invarr = new int[N];
                      
            for (int i = 0; i < N; i++)

                invarr[i] = arr[i] * -1;

            string s = "";
            
            foreach (int v in invarr)
                s = s + v + " ";

            Console.WriteLine($"Значения в массиве с измененными знаками у всех элементов массива :  {s}");
            Console.WriteLine("Нажмите Enter для продолжения.");
            Console.ReadKey();
        }
        public void Mult() //метод умножения значений массива на заданное число 
        {
            string inputmult;
            Console.WriteLine("Задайте число на которое умножить каждый элемент массива:");
            inputmult = Console.ReadLine();
            int mult = int.Parse(inputmult);
            int[] multarr;
            int N = arr.Length;

            multarr = new int[N];

            for (int i = 0; i < N; i++)

                multarr[i] = arr[i] * mult;

            string s = "";

            foreach (int v in multarr)
                s = s + v + " ";

            Console.WriteLine($"Значения в массиве умноженные на {mult} :  {s}");
            Console.WriteLine("Нажмите Enter для продолжения");
            Console.ReadKey();
        }
        public static void ArrayReadFile(string filename) //метод создания массива из файла с проверкой наличия файла
        {
            int[] arrfile;

            bool check = File.Exists(filename);

            if (check == false)
            {
                Console.WriteLine("Файл не найден!!!");
                Console.WriteLine("Нажмите Enter для возврата в меню.");
                Console.ReadKey();
                MainMenu.Menu.MainMenu();
            }
            else

            if (check == true)
            {
                StreamReader sr = new StreamReader(filename);
                int count = File.ReadAllLines(filename).Length;
                Console.WriteLine($"Задайте количество чисел в массиве из файла {filename} не более {count}");
                int N = int.Parse(Console.ReadLine());

                arrfile = new int[N];

                for (int i = 0; i < N; i++)
                {
                    arrfile[i] = int.Parse(sr.ReadLine());
                }
                sr.Close();

                string s = "";
                foreach (int v in arrfile)
                    s = s + v + " ";

                Console.WriteLine($"Значения в массиве из файла {filename}  :  {s}");
                Console.WriteLine("Нажмите Enter для возврата в меню.");
                Console.ReadKey();
                MainMenu.Menu.MainMenu();
            }
        }
    }

    public class Program
    {
        public static void Prog()
        {
            //int count;
            string inputcount;
            string inputmax;
            string inputmin;
            Console.WriteLine("Задайте количество чисел в массиве:");
            inputcount = Console.ReadLine();
            int count = int.Parse(inputcount);
            Console.WriteLine("Задайте минимальное значение чисел в массиве:");
            inputmin = Console.ReadLine();
            int min = int.Parse(inputmin);
            Console.WriteLine("Задайте максимальное значение чисел в массиве:");
            inputmax = Console.ReadLine();
            int max = int.Parse(inputmax);
            MyArray arr = new MyArray(count, min, max);
            Console.WriteLine($"Числа в массиве {count} шт.: {arr.ToString()}");
            arr.pair3count();
            Console.WriteLine($"Сумма чисел в массиве: {arr.Sum}");
            Console.WriteLine($"Количество максимальных чисел в массиве:{arr.MaxCount(max)}"); 
            arr.Mult();
            arr.Inverse();
            MainMenu.Menu.MainMenu();
        }
        
    }
}