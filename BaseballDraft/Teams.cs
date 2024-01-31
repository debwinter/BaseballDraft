using System;
namespace BaseballDraft
{
	public class Team
	{
		public Team()
		{
		}

		public Team(string city, string name)
		{
			TeamName = name;
			City = city;
		}

        public Team(string city, string name, string division)
        {
            TeamName = name;
            City = city;
			Division = division;
        }

        public string TeamName { get; set; }
		public string City { get; set; }
		public string Division { get; set; }
		public string? League
		{
			get
			{
				if (Division.ToUpper().Contains("NL")) return "National";
				else if (Division.ToUpper().Contains("AL ")) return "American";
				else return null;
			}
		}
		public int Wins2023 { get; set; }
		public int Losses2023 { get { return 162 - Wins2023; } }
		public bool Postseason2023 { get; set; } = false;
		public List<IPlayer> Players { get { return new List<IPlayer>().Where(x => x.PlaysFor.ToLower() == TeamName.ToLower()).ToList(); } }
	}
}

