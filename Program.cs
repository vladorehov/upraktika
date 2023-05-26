using System;

namespace orehov1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello";
            string s2 = "world";
            Console.WriteLine(s1 + s2);

            Console.ReadLine();

            Console.WriteLine("Введите первое число");
            int p1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int p2 = Convert.ToInt32(Console.ReadLine());
            int r = 0;
            Console.WriteLine("Введите знак");
            string znak = Console.ReadLine();
            if (znak == "+")
            {
                r = p1 + p2;
            }
            if (znak == "-")
            {
                r = p1 - p2;
            }
            if (znak == "*")
            {
                r = p1 * p2;
            }
            if (znak == "/")
            {
                r = p1 / p2;
            }
            Console.WriteLine(r);

            Console.ReadKey();

            Console.WriteLine("Введите Имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string fam = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            string otch = Console.ReadLine();
            Console.Write(name+" "+fam+ " " + otch);

            Console.ReadKey();

            int hp_p = 100;
            int hp_m = 65;
            int def_p = 15;
            int def_m = 10;
            int atk_p = 30;
            int atk_m = 20;
            
                
                Console.WriteLine("Ваше хп " + hp_p);
                Console.WriteLine("хп монстра " + hp_m);
                    
                Console.WriteLine("Время удара (нажмите любую кнопку кроме Power)");
                Console.ReadKey();
                int atk2p = atk_p / def_m;
                hp_m = hp_m - atk2p;
                int atk2m = atk_m / def_p;
                hp_p = hp_p - atk2m;
                Console.WriteLine("Ваше хп " +hp_p);
                Console.WriteLine("хп монстра "+hp_m);
                Console.WriteLine("вы нанесли монстру "+ atk2p);
                Console.WriteLine("он нанес вам "+ atk2m);

                
            
        }
    }
}
