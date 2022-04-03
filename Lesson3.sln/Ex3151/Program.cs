
using System;

namespace Ex3151
{


      
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 5, 6, 78 };


            #region Ex1

            VkUser mainUser = new VkUser("Main User");
            mainUser.PublicMessage("Котик1.jpg");
 

            System.Console.WriteLine();

            VkUser user2 = new VkUser("user2");

             

            mainUser.EventPost += user2.Wall;
            
            //mainUser.EventPost -= user2.Wall;


            mainUser.PublicMessage("Котик2.jpg");

            System.Console.WriteLine();

            VkUser user3 = new VkUser("user3");
            mainUser.EventPost += user3.Wall;
            mainUser.PublicMessage("Котик3.jpg");
          


            System.Console.WriteLine();
            VkUser user4 = new VkUser("user4");
            mainUser.EventPost += user4.Wall;
            mainUser.PublicMessage("Котик4.jpg");

            System.Console.WriteLine("-----");

            mainUser.GetMyUsers();
           
 
            #endregion

        }
 
    }
}
