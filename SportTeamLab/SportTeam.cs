using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportTeamLab
{
    public class SportTeam
    {
        public SportTeam(string name)
        {
            TeamName = name;    
        }
        public Coach Coach { get; set; }
        public string TeamName { get; set; }
        private List<Player> players = new List<Player>();

        public List<Player> Players
        {
            get { return players; }
        }
        public List<Player> GetRookies()
        {
            List<Player> rookies = new List<Player>();
            foreach (var item in players)
            {
                if(item.YearsPro == 0)
                {
                    rookies.Add(item);
                }
            }
            return rookies;
        }
        public string ShowTeamInfo()
        {
            StringBuilder sb = new StringBuilder($"Name of team: {TeamName} - Coach: {Coach.FullName} - ");
            foreach (var item in Players)
            {
                sb.AppendFormat($" {item.GetPlayerInfo()} ");
            }
            return sb.ToString();
        }
        public void Sign(Player player)
        {
            Players.Add(player);
        }
        public void Sign(List<Player> newPlayers)
        {
            foreach (var item in newPlayers)
            {
                Sign(item);
            }
        }
        public void Sign(Player player, SportTeam oldTeam)
        {
            oldTeam.Players.Remove(player);
            Sign(player);
        }
        public void Sign(List<Player> newPlayers, SportTeam oldTeam)
        {
            foreach (var item in newPlayers)
            {
                Sign(item, oldTeam);
            }
        }

    }
}
