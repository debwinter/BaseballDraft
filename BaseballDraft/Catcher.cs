using System;
namespace BaseballDraft
{
	public class Catcher : IPlayer
	{
		public Catcher()
		{
        }

        public Catcher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Catcher(string firstName, string lastName, string rls, double avg)
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

