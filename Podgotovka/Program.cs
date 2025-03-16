using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int first_value= 50;
            int second_value = 33;
            int c = 43;
            int min = a;
            if (second_value<min) min = second_value;
            if (c<min) min = c;
            Console.WriteLine(min);
            Console.ReadKey();
            */


            /*
            int[] arr = new int[10];
            Random rand = new Random();
            int max = arr[0];
            for (int i = 0;i < arr.Length; i++) 
            {
                arr[i] = rand.Next(10);
                Console.Write(arr[i]);
            }
            for (int i =0; i<arr.Length;i++)
            {
                if (arr[i]>max) max = arr[i];
               
            }
            Console.WriteLine("  Max = " + max);
            Console.ReadKey();
            */


            /*
            double first_value, second_value;
            Console.WriteLine("Введите 1ое число");
            first_value = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите 2ое число");
            second_value = double.Parse(Console.ReadLine());
            double three_value = (first_value+ second_value)/2;
            Console.WriteLine("Третье число (среднее арифметическое) равно: " + three_value);
            double sum = first_value+ second_value+ three_value;
            Console.WriteLine("Сумма равна: " + sum);
            double mn = first_value* second_value * three_value;
            Console.WriteLine("Произведение равно: " + mn);
           

            double usd_to_rub = 100;
            double usd_to_euro = 0.8;
            double usd;
            Console.WriteLine("Введите сумму в usd: ");
            usd = double.Parse(Console.ReadLine());
            Console.WriteLine(usd +" usd в рублях: " + usd* usd_to_rub) ;
            Console.WriteLine(usd + " usd в евро: " + usd * usd_to_euro);
            Console.ReadKey();
            */
            /*
            double a;
            a = double.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("число четное");
            
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
            Console.ReadKey();
            */

            /*
            Console.WriteLine("Нажмите любую клавишу(кроме отключения компютера) для продолжения");
            double first_value, second_value;
            bool exit = true;
            Console.ReadKey();
            while (exit)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Введите 1ое число");
                    first_value = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите 2ое число");
                    second_value = double.Parse(Console.ReadLine());
                }
                catch(Exception)
                {
                    Console.WriteLine("Не удалось преобразовать строку в число");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("Выберите нужный оператор: '+' '-' '*' '/'");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "+":
                        Console.WriteLine(first_value + second_value); break;
                    case "-":
                        Console.WriteLine(first_value - second_value); break;
                    case "*":
                        Console.WriteLine(first_value * second_value); break;
                    case "/":
                        if (second_value == 0)
                            Console.WriteLine("Я тебя щас сам на 0 поделю");
                        else
                            Console.WriteLine(first_value / second_value); break;
                    default:
                        Console.WriteLine("Неверный оператор");
                        break;
                }
                Console.WriteLine("Если хотите выйти - напишите 'выйти'");
                string ex = Console.ReadLine();
                if (ex == "выйти")
                    exit = false;

            }    
            */

            /* прямоугольник
            int hight, weight;
            Console.WriteLine("Введите высоту");
            hight = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину");
            weight = int.Parse(Console.ReadLine());
            string symbol = "* " ;
            int count = 0;
            for (int i = 0; i < hight; i++)
            {
                for (int j = 0; j < weight; j++)
                {
                    
                    Console.Write(symbol);
                }

                Console.WriteLine();
            }
            Console.ReadKey();
             */


            Console.WriteLine("Введите высоту");
            int height = int.Parse(Console.ReadLine());
            string symbol = "*" ;
            
            for (int i = 0; i < height; i++)
            {
                for (int j = height; j>i; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
