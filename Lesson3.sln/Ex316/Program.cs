using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Ex316
{


    class Program
    {
        static void A1() { }
        //delegate void DA1();

        static void A2(int a) { }
        //delegate void DA2(int v);

        static void A2(double a) { }
        //delegate void DA2(double v);

        static void A2(short a) { }
        //delegate void DA2(short v);

        static void A2(string a) { }
        //delegate void DA2(string v);

        static void A3(int a, string b) { }
        //delegate void DA3(int i, string s);

        static void A31(string a, int b) { }
        //delegate void DA31(string i, int s);

        static void A3(int a, string b, byte с) { }
        //delegate void DA3(int i, string s, byte q);

        static void A4(string b, int a, byte с) { }
        //delegate void DA4(string s, int i, byte q);


        static int F1() { throw new NotImplementedException(); }
        //delegate int DF1();

        static double F11() { throw new NotImplementedException(); }
        //delegate double DF11();

        static int F2(double a) { throw new NotImplementedException(); }
        //delegate int DF2(double d);

        static int F3(double a, string b) { throw new NotImplementedException(); }
        //delegate int DF3(double d, string s);

        static int F4(double a, string b, short c) { throw new NotImplementedException(); }
        //delegate int DF4(double d, string s, short h);

        static int F4(int a, string b, short c) { throw new NotImplementedException(); }
        //delegate int DF4(int d, string s, short h);

        public delegate void VoidDel<T1>(T1 t1);
        public delegate R1 NotVoidDel<R1>();
        public delegate R1 NotVoidDel<T1, T2, R1>(T1 value1, T2 value2);

        //NotVoidDel<double> not = F11;
        // static void A2(string a) { }
        // VoidDel<string> vd = A2;
        // static void A2(short a) { }
        // VoidDel<short> vd = A2;


        public delegate void VoidDel<T1, T2>(T1 t1, T2 t2);
        public delegate void VoidDel<T1, T2, T3>(T1 t1, T2 t2, T3 t3);


        // static int F1() { throw new NotImplementedException(); }
        // NotVoidDel<int> nvd = F1;



        public delegate T3 NotVoidDel<T1, T3>(T1 t1);

        // static int F3(double a, string b) { throw new NotImplementedException(); }
        // NotVoidDel<double, string, int> nvd = F3;

        static bool B1<T>(T a) { throw new NotImplementedException(); }
        //delegate bool DB1<T>(T In);


        static bool B2(int a) { throw new NotImplementedException(); }
        delegate bool DB1(int In);


        static bool IsEven(int n)
        {
            return n % 3 == 0;
        }

        static bool search(int a)
        {
            return a % 2 == 0;
        }

        static string Conv(int a)
        {
            return a.ToString();
        }

        



        static void Main(string[] args)
        {
            


            var arr = new[] { 123, 31, 23 };
            Array.FindAll(arr, search);
            Array.ConvertAll(arr, Convert.ToString);

            
            
            
            Func<int> dF = F1;

            //VoidDel<string,int> del = A31;
            Action<string, int> del = A31;





            //NotVoidDel<double, string, int> f = F3;
            Func<double, string, int> f = F3;


            //DA1 da1 = A1;
            //DA2 da2 = A2;
            //DA3 da3 = A3;

            //DF1 df1 = F1;
            //DF2 df2 = F2;
            //DF3 df3 = F3;
            //DF4 df4 = F4;
            //DB1<int> db1 = B1;

            //delegate void DA1();
            Action da1 = A1;

            //delegate void DA2(int v);
            Action<int> da2 = A2;

            //Action<double> da2 = A2;
            //delegate void DA2(double v);

            //delegate void DA3(int i, string s);
            Action<int, string> da3 = A3;



            //delegate int DF1();
            Func<int> df1 = F1;

            //delegate int DF2(double d);
            Func<double, int> df2 = F2;

            //delegate int DF4(double d, string s);
            Func<double, string, int> df3 = F3;

            //delegate int DF4(double d, string s, short h);
            Func<double, string, short, int> df4 = F4;

            // delegate bool MyPredicate(int a)


           
            Func<int, bool> db1 = B1;
            //Func<int, bool> db1 = B1;

            Predicate<int> db2 = B1;
            Func<int, bool> func = B1;

            //Predicate<double> 

            string[] s = "1 2 3 4".Split(' ');

            int[] arr = Array.ConvertAll(s, int.Parse);




        }

       
    }
}
