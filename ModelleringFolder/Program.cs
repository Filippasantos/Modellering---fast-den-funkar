using System;
using System.Collections.Generic;

namespace Modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            player p1 = new player();
            player p2 = new player();
            player p3 = new player();

            player p4 = new player();
            player p5 = new player();
            player p6 = new player();

            List<player> girlsName = new List<player>();
            List<player> boysName = new List<player>();

            List<player> girlsSpeed = new List<player>();
            List<player> boysSpeed = new List<player>();
            
            girlsName.Add(p1);
            girlsName.Add(p2);
            girlsName.Add(p3);

            boysName.Add(p4);
            boysName.Add(p5);
            boysName.Add(p6);


            p1.name = "Clara";
            p2.name = "Filippa";
            p3.name = "Emma";

            p4.name = "Byron";
            p5.name = "Max";
            p6.name = "Linus";

            Random random = new Random();

            p1.speed = random.Next(1, 40);
            p2.speed = random.Next(1, 40);
            p3.speed = random.Next(1, 40);

            p4.speed = random.Next(1, 40);
            p5.speed = random.Next(1, 40);
            p6.speed = random.Next(1, 40);


            System.Console.WriteLine(p1.speed + ", " + p2.speed + ", " + p3.speed + ", " + p4.speed + ", " + p5.speed + ", " + p6.speed);
            Console.ReadLine();
        }
    }
}