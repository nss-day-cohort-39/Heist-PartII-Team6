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

            while (true)
            {
                Console.WriteLine("Enter the name of new crew member.");
                string newName = Console.ReadLine();
                if (newName == "")
                {
                    break;
                }

                Console.WriteLine("Choose a specialty");
                Console.WriteLine("Hacker | Muscle | LockpickSpecialist");
                string newSpecialty = Console.ReadLine();

                Console.WriteLine("Choose skill level between 1 and 100");
                int newSkillLevel = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Choose the cut percentage");
                int newPercentageCut = Int32.Parse(Console.ReadLine());

                if (newSpecialty == "Hacker")
                {
                    Hacker newRobber = new Hacker
                    {
                    Name = newName,
                    SkillLevel = newSkillLevel,
                    PercentageCut = newPercentageCut
                    };
                    Rolodex.Add(newRobber);
                }
                else if (newSpecialty == "LockpickSpecialist")
                {
                    LockSpecialist newRobber = new LockSpecialist
                    {
                    Name = newName,
                    SkillLevel = newSkillLevel,
                    PercentageCut = newPercentageCut
                    };
                    Rolodex.Add(newRobber);
                }
                else if (newSpecialty == "Muscle")
                {
                    Muscle newRobber = new Muscle
                    {
                    Name = newName,
                    SkillLevel = newSkillLevel,
                    PercentageCut = newPercentageCut
                    };
                    Rolodex.Add(newRobber);
                };
            };
            Random rand = new Random();

            Bank GothamTrust = new Bank
            {
                AlarmScore = rand.Next(101),
                VaultScore = rand.Next(101),
                SecurityGuardScore = rand.Next(101),
                CashOnHand = rand.Next(50_000, 1_000_001)
            };
            Dictionary<string, int> SecurityScores = new Dictionary<string, int>()
            { { "AlarmScore", GothamTrust.AlarmScore }, { "VaultScore", GothamTrust.VaultScore }, { "SecurityGuardScore", GothamTrust.SecurityGuardScore }
            };

            Console.WriteLine($"Most Secure: ");
            Console.WriteLine($"Least Secure: ");
        }
    }
}