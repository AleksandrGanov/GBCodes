using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex311
{
    class Program
    {

        #region Swap

        static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        static void Swap(ref int[] a, ref int[] b)
        {
            int[] t = a;
            a = b;
            b = t;
        }

        static void Swap(ref double a, ref double b)
        {
            double t = a;
            a = b;
            b = t;
        }

        static void Swap(ref object a, ref object b)
        {
            object t = a;
            a = b;
            b = t;
        }

        #endregion

        static void Main(string[] args)
        {
            #region Ex of T 1

            
            int c = 1, d = 2;

            Console.WriteLine($"c = {c}   d = {d}");
            Swap(ref c, ref d);
            Console.WriteLine($"c = {c}   d = {d}");

            
            int[] a = { 1, 2 }, b = { 3, 4 };
            Console.WriteLine("До");
            foreach (var item in a) { Console.Write($"Ai = {item}  "); }
            Swap(ref a, ref b);
            foreach (var item in b) { Console.Write($"Bi = {item}  "); }

            double[] d1 = { 1, 2 }, d2 = { 3, 4 };

            object o1 = d1, o2 = d2;

            Swap(ref o1, ref o2);

            d1 = o1 as double[];
            d2 = o2 as double[];

            Console.WriteLine("\nПосле");

            foreach (var item in a) { Console.Write($"Ai = {item}  "); }
            foreach (var item in b) { Console.Write($"Bi = {item}  "); }

            #endregion

            Console.ReadLine();
        }

    }
}
