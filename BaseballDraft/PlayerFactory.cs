using System;
namespace BaseballDraft
{
	public static class PlayerFactory
	{
		public static IPlayer GetPlayer(string position, string firstName, string lastName)
		{
			switch (position.ToUpper())
			{
				case "1B" or "2B" or "3B" or "SS" or "IF":
					return new Infielder(firstName, lastName, position);
				case "LF" or "RF" or "CF" or "OF":
					return new Outfielder(firstName, lastName, position);
				case "SP" or "RP" or "P" or "PITCHER":
					return new Pitcher(firstName, lastName);
				case "C" or "CATCHER":
					return new Catcher(firstName, lastName);
				default:
					return new Batter(firstName, lastName);
			}
		}
	}
}

