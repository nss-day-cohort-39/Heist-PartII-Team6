using System;

namespace Heist_PartTwo
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            int ScoreAfterLockPicked = bank.VaultScore - SkillLevel;
            Console.WriteLine($"{Name} is lockpicking the vault.  Decrease security {SkillLevel} points.");
            if (ScoreAfterLockPicked <= 0)
            {
                Console.WriteLine($"{Name} has picked the lock!");
            }

        }
    }
}