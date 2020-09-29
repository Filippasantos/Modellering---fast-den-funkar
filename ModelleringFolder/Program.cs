using System;
using System.Collections.Generic;

namespace Modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            goal goalGirls = new goal();
            goal goalBoys = new goal();

            goalGirls.sizeX = 40;
            goalGirls.sizeY = 40;
            goalGirls.sizeZ = 40;

            goalBoys.sizeX = 40;
            goalBoys.sizeY = 40;
            goalBoys.sizeZ = 40;

            player p1 = new player();
            player p2 = new player();
            player p3 = new player();

            player p4 = new player();
            player p5 = new player();
            player p6 = new player();

            List<player> girls = new List<player>();
            List<player> boys = new List<player>();

            girls.Add(p1);
            girls.Add(p2);
            girls.Add(p3);

            boys.Add(p4);
            boys.Add(p5);
            boys.Add(p6);

            p1.name = "Clara";
            p2.name = "Filippa";
            p3.name = "Emma";

            p4.name = "Byron";
            p5.name = "Max";
            p6.name = "Linus";

            football football = new football();

            football.x = 20;
            football.y = 30;
            football.z = 50;
            football.inAir = false;

            Random random = new Random();

            p1.speed = random.Next(1, 100);
            p2.speed = random.Next(1, 100);
            p3.speed = random.Next(1, 100);

            p4.speed = random.Next(1, 100);
            p5.speed = random.Next(1, 100);
            p6.speed = random.Next(1, 100);

            System.Console.WriteLine("The fastest player has the ball!");
            Console.ReadLine();

            player currentBestG = girls[0];
            player currentBestB = boys[0];

            for (int i = 1; i < girls.Count; i++)
            {
                if (girls[i].speed > currentBestG.speed)
                {
                    currentBestG = girls[i];
                }
            }

            for (int i = 1; i < boys.Count; i++)
            {
                if (boys[i].speed > currentBestB.speed)
                {
                    currentBestB = boys[i];
                }
            }

            if (currentBestB.speed > currentBestG.speed)
            {
                System.Console.WriteLine(currentBestB.name + " has the ball!");
            }
            else if (currentBestG.speed > currentBestB.speed)
            {
                System.Console.WriteLine(currentBestG.name + " has the ball!");
            }

            Console.ReadLine();
        }
    }
}