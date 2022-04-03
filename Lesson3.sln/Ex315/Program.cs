using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex315
{


    class Program
    {
        static void Main(string[] args)
        {
            #region Ex1

            ////IObservable
            //IObserver


            VkUser mainUser = new VkUser("Main User");

            mainUser.PublicMessage("Котик1.jpg");

            System.Console.WriteLine();

            VkUser user2 = new VkUser("user2");

            mainUser.AddFollower(user2);


            mainUser.PublicMessage("Котик2.jpg");


            Console.ReadLine();


            System.Console.WriteLine();

            VkUser user3 = new VkUser("user3");
            mainUser.AddFollower(user3);
            mainUser.PublicMessage("Котик3.jpg");

            Console.ReadLine();

            System.Console.WriteLine();
            VkUser user4 = new VkUser("user4");
            mainUser.AddFollower(user4);
            mainUser.PublicMessage("Котик4.jpg");
            

            Console.ReadLine();
            Console.WriteLine("\n------");

            mainUser.GetMyUsers();
            Console.WriteLine();

            Console.ReadLine();
            mainUser.RemoveFollower(user2);

            Console.WriteLine();
            mainUser.GetMyUsers();

            Console.WriteLine("======");

            user2.AddFollower(mainUser);
            user2.PublicMessage("Я в Китае!");


            #endregion
        }
    }
}
