using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportTeamLab
{
    public class Player : SportTeamMember
    {
        public Player(string fullName) : base(fullName)
        {
        }
        public int JerseyNumber { get; set; }
        public string Position { get; set; }
        public string GetPlayerInfo()
        {
            return new StringBuilder("#").AppendFormat($"{JerseyNumber} - {Position} - {FullName}").ToString();
        }
    }
}
