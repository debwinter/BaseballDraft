using System;
namespace BaseballDraft
{
	public interface IPlayer
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName { get { return $"{FirstName} {LastName}"; } }
		public string RightyLeftySwitch { get; set; }
		public string PlaysFor { get; set; }
	}
}

