using System;

namespace Heist_PartTwo
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public int PercentageCut { get; set; }

        public void PerformSkill(Bank bank)
        {
            int ScoreAfterHack = bank.AlarmScore - SkillLevel;
            Console.WriteLine($"{Name} is hacking the alarm system.  Decrease security {SkillLevel} points.");
            if (ScoreAfterHack <= 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }

        }
    }
}