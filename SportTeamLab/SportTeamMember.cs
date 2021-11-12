using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportTeamLab
{
    public abstract class SportTeamMember
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public int YearsPro { get; set; }

        public SportTeamMember(string fullName)
        {
            FullName = fullName;
        }
    }
}
