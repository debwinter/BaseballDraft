namespace BaseballDraft;
class Program
{
    static void Main(string[] args)
    {
        var teams = AllTeams();

        Console.WriteLine("Baseball teams, sorted by name length:");
        teams.OrderBy(x => x.TeamName).OrderBy(x => x.TeamName.Length).ToList().ForEach(x => Console.WriteLine(x.TeamName));
    }

    #region Teams Populater
    public static List<Team> AllTeams()
    {
        var teams = new List<Team>();
        teams.Add(new Team("Atlanta", "Braves", "NL East"));
        teams.Add(new Team("Miami", "Marlins", "NL East"));
        teams.Add(new Team("New York", "Mets", "NL East"));
        teams.Add(new Team("Philadelphia", "Phillies", "NL East"));
        teams.Add(new Team("Washington", "Nationals", "NL East"));
        teams.Add(new Team("Chicago", "Cubs", "NL Central"));
        teams.Add(new Team("Cincinnati", "Reds", "NL Central"));
        teams.Add(new Team("Milwaukee", "Brewers", "NL Central"));
        teams.Add(new Team("Pittsburgh", "Pirates", "NL Central"));
        teams.Add(new Team("St. Louis", "Cardinals", "NL Central"));
        teams.Add(new Team("Arizona", "Diamondbacks", "NL West"));
        teams.Add(new Team("Colorado", "Rockies", "NL West"));
        teams.Add(new Team("Los Angeles", "Dodgers", "NL West"));
        teams.Add(new Team("San Diego", "Padres", "NL West"));
        teams.Add(new Team("San Francisco", "Giants", "NL West"));
        teams.Add(new Team("Baltimore", "Orioles", "AL East"));
        teams.Add(new Team("Boston", "Red Sox", "AL East"));
        teams.Add(new Team("New York", "Yankees", "AL East"));
        teams.Add(new Team("Tampa Bay", "Rays", "AL East"));
        teams.Add(new Team("Toronto", "Blue Jays", "AL East"));
        teams.Add(new Team("Chicago", "White Sox", "AL Central"));
        teams.Add(new Team("Cleveland", "Guardians", "AL Central"));
        teams.Add(new Team("Detroit", "Tigers", "AL Central"));
        teams.Add(new Team("Kansas City", "Royals", "AL Central"));
        teams.Add(new Team("Minnesota", "Twins", "AL Central"));
        teams.Add(new Team("Houston", "Astros", "AL West"));
        teams.Add(new Team("Los Angeles", "Angels", "AL West"));
        teams.Add(new Team("Oakland", "Athletics", "AL West"));
        teams.Add(new Team("Seattle", "Mariners", "AL West"));
        teams.Add(new Team("Texas", "Rangers", "AL West"));

        return teams;
    }
    #endregion

}

