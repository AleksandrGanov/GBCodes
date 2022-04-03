using System;

namespace Ex310
{

    class Foo
    {
        private int state = 0;

        public event Action<string> EventAction;

        public event Action<string> EVENT
        {
            add
            {
                Console.WriteLine(value.GetType());
                Console.WriteLine("Кто -то подписался");
            }
            remove
            {
                Console.WriteLine("Кто -то отписался");
            }
        }

        public int Add
        {
            set
            {
                if (value > 2) EventAction?.Invoke("Перебор");
                else state = value;
            }
            get => state;
        }

    }

    class Program
    {
        static void Main()
        {
            var f = new Foo();
            f.EVENT += F_eventAction;
            f.EVENT -= F_eventAction;
            f.EventAction += F_eventAction;
            f.EventAction += R_eventAction;

            for (int i = 0; i < 5; i++)
                f.Add = i;

            Console.ReadLine();
        }

        private static void F_eventAction(string obj)
        {
            Console.WriteLine("Вывод в консоль: " + obj);
        }
        private static void R_eventAction(string obj)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вывод красненьким: " + obj);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}