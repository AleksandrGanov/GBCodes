using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;

namespace Ex313
{
    class A
    {
        private A() { }
    }

    partial class Program
    {
        static void Main(string[] args)
        {



            //MyList<StreamReader> my1 = new MyList<StreamReader>();

            //MyList<S> my1 = new MyList<S>();
            //MyList<B> my1 = new MyList<B>();
            //MyList<C> my2 = new MyList<C>();
            //MyList<D> my3 = new MyList<D>();
            
            List<int> list = new List<int>();
            list.Add(123);
            MyList<int> my = new MyList<int>();

            my.Add(1);
            my.Add(12);
            my.Add(12);
            my.Add(12);
            my.Add(2);
            my.Add(2);
            my.Add(2);
            my.Add(8);
            my.Add(8);
            my.Add(8);
            my.RemoveAt(2);
            my.Add(8);
            my.Add(8);







        }
    }
}
