using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тему и задание, варианты: 11 12 13 14 15 21 22 23 24 ");
            //
            int vibor = Convert.ToInt32(Console.ReadLine());
            if (vibor == 11)
            {
                int chis = Convert.ToInt32(Console.ReadLine());
                if (chis < 0)
                {
                    Console.WriteLine(chis - 5);
                }
                if (chis > 0)
                {
                    Console.WriteLine(chis + 5);
                }
            }
            if (vibor == 12)
            {
                int chis1 = Convert.ToInt32(Console.ReadLine());
                int chis2 = Convert.ToInt32(Console.ReadLine());
                int chis3 = Convert.ToInt32(Console.ReadLine());
                if (chis1 > chis2 && chis1 > chis3)
                {
                    Console.WriteLine(chis1);
                }
                if (chis2 > chis1 && chis2 > chis3)
                {
                    Console.WriteLine(chis2);
                }
                if (chis3 > chis2 && chis3 > chis1)
                {
                    Console.WriteLine(chis3);
                }
            }
            if (vibor == 13)
            {
                int a = 0;
                int b = 0;
                int c = 0;

                int chis11 = Convert.ToInt32(Console.ReadLine());
                int chis21 = Convert.ToInt32(Console.ReadLine());
                int chis31 = Convert.ToInt32(Console.ReadLine());
                if (chis11 > 0)
                {
                    a = chis11;
                }
                if (chis21 > 0)
                {
                    b = chis21;
                }
                if (chis31 > 0)
                {
                    c = chis31;
                }
                int abc = a + b + c;
                Console.WriteLine(abc);
            }
            if (vibor == 14)
            {
                Console.WriteLine("введите  х");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x > 10)
                {
                    Console.WriteLine(x * 2);
                }
            }
            if (vibor == 15)
            {
                Console.WriteLine("sdfjhsbdhfbsdhf");
                int den = Convert.ToInt32(Console.ReadLine());
                switch (den)
                {
                    case 1: Console.WriteLine("понедельник"); break;
                    case 2: Console.WriteLine("вторник"); break;
                    case 3: Console.WriteLine("среда"); break;
                    case 4: Console.WriteLine("четверг"); break;
                    case 5: Console.WriteLine("пятница"); break;
                    case 6: Console.WriteLine("суббота"); break;
                    case 7: Console.WriteLine("воскресенье"); break;
                }
            }
            if (vibor == 21)
            {
                int number = 200;
                while (number % 17 != 0)
                {
                    number++;
                }
                Console.WriteLine(number);
            }
            if (vibor == 22)
            {
                bool den20 = false;
                bool prob100 = false;
                int denn = 1;
                double vse = 10;
                double beg = 10;
                while (beg < 100)
                {

                    denn++;
                    beg += beg / 20;
                    vse += beg;
                    if (beg >= 20 && den20 == false)
                    {
                        Console.WriteLine("День, когда он пробежал 20км за день: " + denn);
                        den20 = true;
                    }
                    if (vse >= 100 && prob100 == false)
                    {
                        Console.WriteLine("День, когда он пробежал в общем 100км : " + denn);
                        prob100 = true;
                    }
                }
            }
            if (vibor == 23)
            {
                int f = 0;
                int ff = 1;
                Console.WriteLine("Факториал нада? ");
                int fact = Convert.ToInt32(Console.ReadLine());
                for (f = 1; f <= fact; f++)
                {
                    ff = ff * f;
                }
                Console.WriteLine(ff);
            }
            if (vibor == 24)
            {
                Console.WriteLine("Вводи ");
                int nub = Convert.ToInt32(Console.ReadLine());
                int del = 1;
                while (nub < 1000)
                {
                    del++;
                    int ost = nub % del;
                    if (ost == 0)
                    {
                        Console.WriteLine(del);
                        break;
                    }

                }
            }






            Console.ReadKey();
        }
    }
}
