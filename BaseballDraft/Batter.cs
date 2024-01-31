using System;
namespace BaseballDraft
{
	public class Batter : IPlayer
	{
        public Batter()
        {
        }

        public Batter(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Batter(string firstName, string lastName, string rls, double avg)
        {
            FirstName = firstName;
            LastName = lastName;
            RightyLeftySwitch = rls;
            BattingAverage = avg;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RightyLeftySwitch { get; set; }
        public double BattingAverage { get; set; }
        public string PlaysFor { get; set; }
    }
}

