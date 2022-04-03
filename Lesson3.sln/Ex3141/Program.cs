using System;
using System.IO;
using System.Linq;

namespace Ex3141
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            using (StreamReader sr = new StreamReader("data.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string data = sr.ReadLine();
                    var srr = data.Split(' ');

                    for (int i = 0; i < srr.Length; i++)
                    {
                        int temp = int.Parse(srr[i]);
                        if (temp > 0 && temp % 2 == 0) sum += temp;
                    }
                }

                Console.WriteLine(sum);
                sum = 0;


            }

            var res =
            File.ReadAllText("data.txt")
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(e => e > 0 && e % 2 == 0)
                .Sum();

            Console.WriteLine(res);


        }


    }
}
