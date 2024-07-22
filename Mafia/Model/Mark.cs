using Mafia.Actions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia.Model
{
    public class Mark
    {
        public MarkName Name { get; set; }
        public int DayNumber { get; set; }
        public Player Sender { get; set; }
        public IAction Action { get; set; }
    }

    public enum MarkName
    {
        Heal,
        Kill,
        CheckRole
    }
}
