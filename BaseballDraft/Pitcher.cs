using System;
namespace BaseballDraft
{
	public class Pitcher : IPlayer
	{
		public Pitcher()
		{
		}

		public Pitcher(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}

        public Pitcher(string firstName, string lastName, string rls, double era)
        {
            FirstName = firstName;
            LastName = lastName;
			RightyLeftySwitch = rls;
			ERA = era;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RightyLeftySwitch { get; set; }
		public double ERA { get; set; }
        public string PlaysFor { get; set; }
    }
}

