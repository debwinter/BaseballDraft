using System;
namespace BaseballDraft
{
	public class Infielder : IPlayer
	{
		public Infielder()
		{
        }

        public Infielder(string firstName, string lastName, string position)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }

        public Infielder(string firstName, string lastName, string position, string rls, double avg)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            RightyLeftySwitch = rls;
            BattingAverage = avg;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string RightyLeftySwitch { get; set; }
        public double BattingAverage { get; set; }
        public string PlaysFor { get; set; }
    }
}

