using System;

namespace Heist_PartTwo
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            int ScoreAfterPunchout = bank.SecurityGuardScore - SkillLevel;
            Console.WriteLine($"{Name} is taking out the guards.  Decrease security {SkillLevel} points.");
            if (ScoreAfterPunchout <= 0)
            {
                Console.WriteLine($"{Name} has knocked out the guards!");
            }

        }
    }
}