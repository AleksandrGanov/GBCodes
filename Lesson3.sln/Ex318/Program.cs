using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Ex318
{
    class MyClass
    {
        int myProperty;
        //public int MyProperty { get { return myProperty; } }
        public int MyProperty => myProperty;

        //public int GetMyProperty()
        //{
        //    return myProperty;
        //}

        public int GetMyProperty() => myProperty;
    }    
    class Program
    {

        static void Main(string[] args)
        {

 

        }

     

       
    }
}
