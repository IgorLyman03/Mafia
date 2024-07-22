using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia.Model
{
    public class Role
    {
        public string Name { get; set; }
        public RoleTeam Team { get; set; }
        public IEnumerable<Action> Actions { get; set; }

    }

    public enum RoleTeam
    {
        Red,
        Black,
        Suicider
    }
}
