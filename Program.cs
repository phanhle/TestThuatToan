using System;

namespace TestThuatToan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bai1
            System.Console.WriteLine("Bai 1:");
            Bai1 bai1 = new Bai1();
            Console.WriteLine(bai1.CountSquare(3)); 
            //Bai2 
            System.Console.WriteLine("Bai 2:");
            Bai2 bai2 = new Bai2();
            Human[] humans = new Human[]
            {
                new Human(33,0),
                new Human(11,2),
                new Human(22,1),
                new Human(44,1),
                new Human(55,0),
            };
            var SortHumans = bai2.SortingHuman(humans);
            foreach(Human human in SortHumans){
                Console.WriteLine(human.height + " " + human.index);
            }
        }
    }
}
