using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportTeamLab
{
    public class Coach : SportTeamMember
    {
        public Coach(string fullName) : base(fullName)
        {
        }
        public bool FormerPlayer { get; set; }
    }
}
