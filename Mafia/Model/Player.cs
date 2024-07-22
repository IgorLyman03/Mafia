using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia.Model
{
    public class Player
    {
        public string Name { get; set; }
        public Role Role { get; set; }
        public bool IsAlive { get; set; }
        public Dictionary<string, bool> Value { get; set; }
        public ICollection<Mark> Marks { get; set; }

    }
}
