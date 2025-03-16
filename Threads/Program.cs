using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int a = 5;
            void thr()
            {
                new Thread(() =>                         //создаем поток
                {
                    //M(a);                             // какой-то код
                })
                {
                    IsBackground = true,
                    Priority = ThreadPriority.Normal    // задаем приоритет распределения производительности 
                }.Start();

            }


            /* Либо пишем так
            delegate () //анонимный метод, который 
            {
                M(a);
            });
            */
            // Можно так поток создавать:     new Thread(() => { /* какой-то код */}).Start();
            void M(int b)
            {

                Thread.Sleep(1000);
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
        }
    }
}
