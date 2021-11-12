// See https://aka.ms/new-console-template for more information

using SportTeamLab;

Coach coach1 = new Coach("Henkie") { Age = 50, FormerPlayer = true, FullName = "Henkie henks", YearsPro = 22};
Coach coach2 = new Coach("Jack") { Age = 24, FormerPlayer = true, FullName = "Jack Septiceye", YearsPro = 7 };

Player player1 = new Player("Dave") { YearsPro = 4, FullName = "Dave Jansen", Age = 24, JerseyNumber = 9, Position = "Ergens in het veld"};
Player player2 = new Player("Chad") { YearsPro = 10, FullName = "Chad Chadson", Age = 33, JerseyNumber = 14, Position = "Op de bank"};

List<Player> allstars = new List<Player>() 
{ 
    new Player("allstar player1") { YearsPro = 1, FullName = "Henry Madsen", Age = 20, JerseyNumber = 124, Position = "A"},
    new Player("allstar player2") { YearsPro = 2, FullName = "Felix Kjellberg", Age = 29, JerseyNumber = 1, Position = "B"},
    new Player("allstar player3") { YearsPro = 3, FullName = "Harry Henrikson", Age = 18, JerseyNumber = 999, Position = "C"}
};

List<Player> legends = new List<Player>()
{
    new Player("legend player1") { YearsPro = 4, FullName = "Legend 1", Age = 24, JerseyNumber = 8, Position = "D"},
    new Player("legend player2") { YearsPro = 5, FullName = "Legend 2", Age = 24, JerseyNumber = 7, Position = "E"},
    new Player("legend player3") { YearsPro = 6, FullName = "Legend 3", Age = 24, JerseyNumber = 656, Position = "F"}
};

SportTeam st1 = new SportTeam("Sporty club1") { Coach = coach1 };
SportTeam st2 = new SportTeam("Sporty club2") { Coach = coach2 };

st1.Sign(player1);
st2.Sign(allstars);

Console.WriteLine(st1.ShowTeamInfo());
Console.WriteLine(st2.ShowTeamInfo());

st1.Sign(player1, st2);
st2.Sign(allstars, st1);
st1.Sign(legends);

Console.WriteLine(st1.ShowTeamInfo());
Console.WriteLine(st2.ShowTeamInfo());
