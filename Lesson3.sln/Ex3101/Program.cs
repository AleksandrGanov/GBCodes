using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3101
{
    class A
    {
        static Random r = new Random();
        int x, y;
       

        public A()
        {
            x = r.Next(100);
            y = r.Next(100);
        }

        public override string ToString()
        {
            return $"{x} {y}";
        }
    }
    

   

    class Program:IEnumerable
    {

        public IEnumerator GetEnumerator()
        {
            return this.Ff();
        }

        private IEnumerator Ff()
        {
            yield return 1;
            yield return 1;
            yield return 1;
            yield return 1;
            yield return 1;
        }

        static void Main(string[] args)
        {


            Program t = new Program();

            foreach (var item in t)
            {
                Console.WriteLine(item);
            }



            for (int i = 0; i < 300; i++)
            {
                Console.WriteLine(new A());
            }

            
            



        }

      
    }
}
