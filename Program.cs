using System;
using System.Collections.Generic;

namespace Heist_PartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker MarkDaHackerz = new Hacker()
            {
                Name = "Mark McCann",
                SkillLevel = 38,
                PercentageCut = 20
            };

            LockSpecialist TimDaToolMan = new LockSpecialist()
            {
                Name = "Time George",
                SkillLevel = 25,
                PercentageCut = 20
            };

            Muscle ThomasDaTank = new Muscle()
            {
                Name = "Thomas Long",
                SkillLevel = 45,
                PercentageCut = 20
            };

            Hacker FakeDaniel = new Hacker()
            {
                Name = "Daniel Fuqua",
                SkillLevel = 50,
                PercentageCut = 20
            };

            Muscle RealDaniel = new Muscle()
            {
                Name = "Daniel Hero",
                SkillLevel = 40,
                PercentageCut = 20
            };

            List<IRobber> Rolodex = new List<IRobber>()
            {
                MarkDaHackerz,
                TimDaToolMan,
                ThomasDaTank,
                FakeDaniel,
                RealDaniel
            };

            Console.WriteLine("Enter the name of new crew member.");
            Console.ReadLine();

            Console.WriteLine("Choose a specialty");
            Console.WriteLine("Hacker | Muscle | LockpickSpecialist");
            Console.ReadLine();

            Console.WriteLine("Choose skill level between 1 and 100");
            Console.ReadLine();

            Console.WriteLine("Choose the cut percentage");
            Console.ReadLine();
        }
    }
}