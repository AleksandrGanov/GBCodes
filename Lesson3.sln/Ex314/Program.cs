using System;
using System.Collections.Generic;

namespace Ex314
{
    delegate void GetArgs(string Value);

    class Program
    {
        #region IoT

        /// <summary>
        /// Получение информации о состоянии системы
        /// </summary>
        /// <returns></returns>
        static string IoTDataGet()
        { return Guid.NewGuid().ToString().Substring(1, 10); }

        /// <summary>
        /// Печать данных, считанных с датчиков
        /// </summary>
        /// <param name="JSON">Данные</param>
        /// <param name="Method">Метод печати</param>
        ///                               void Name(string)  
        static void WorkData(GetArgs Method)
        {
            Method(IoTDataGet());
        }

        #endregion

        static void Main(string[] args)
        {
            #region Ex0
            var io = new IoTData();
            var getArgs = new GetArgs(io.DataConsoleWrite);

            WorkData(getArgs);
            WorkData(io.DataConsoleWrite);
            WorkData(Test);
            #endregion

            #region Ex1



            /*
            static void Test(string JSON)
            {
                Console.WriteLine(JSON);
            }
            */

            WorkData(delegate (string JSON)
            {
                Console.WriteLine(JSON);
            });

            WorkData((string JSON) =>
            {
                Console.WriteLine(JSON);
            });

            WorkData(_ => Console.WriteLine(_));

            List<int> db = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                db.Add(r.Next(100));
                Console.Write($"{db[i]} ");
            }

            var dbOther = db.FindAll(e => e % 5 == 0);

            //List<int> dbOther = new List<int>();

            //for (int i = 0; i < db.Count; i++)
            //{
            //    if (db[i] % 5 == 0) dbOther.Add(db[i]);
            //}
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < dbOther.Count; i++)
            {
                Console.Write($"{dbOther[i]} ");
            }



























































            #endregion
        }


        static bool f(int t)
        {
            return t % 5 == 0;
        }

        static void Test(string JSON)
        {
            Console.WriteLine(JSON);
        }
    }
}