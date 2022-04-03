using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex312
{
    class Program
    {
        #region of T

        static void Swap<T>(ref T a, ref T b)
        {
            T t = a;
            a = b;
            b = t; 
        }

        #endregion

        static void Main(string[] args)
        {
            List<int> l = new List<int>();

            int c = 1, d = 2;

            Console.WriteLine($"c = {c}   d = {d}");
            Swap<int>(ref c, ref d);
            Console.WriteLine($"c = {c}   d = {d}");


            double[] a = { 1, 2 }, b = { 3, 4, 5,6 };

            Console.WriteLine("До");
            foreach (var item in a) { Console.Write($"Ai = {item}  "); }
            Console.WriteLine();
            foreach (var item in b) { Console.Write($"Bi = {item}  "); }

            //object o1 = a, o2 = b;

            //Swap<Activator>()

            Swap<double[]>(ref a, ref b);


            //a = o1 as double[];
            //b = o2 as double[];
            Console.WriteLine("\nПосле");

            foreach (var item in a) { Console.Write($"Ai = {item}  "); }
            Console.WriteLine();
            foreach (var item in b) { Console.Write($"Bi = {item}  "); }

            Console.WriteLine();
        }
    }
}
