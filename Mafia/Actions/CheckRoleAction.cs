using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Mafia.Actions.Interfaces;
using Mafia.Model;

namespace Mafia.Actions
{
    public class CheckRoleAction : IAction
    {
        public void Perform(Player sender, Player receiver, int dayNumber)
        {
            receiver.Marks.Add(new Mark { Sender = sender, Action = this, DayNumber = dayNumber, Name = MarkName.CheckRole });
        }

        public IEnumerable<Player> PlayerFilter(IEnumerable<Player> players, Player sender, int dayNumber) =>
            players.Where(p => 
                p.IsAlive 
                && p != sender 
                && !p.Marks.Any(m => m.Name == MarkName.CheckRole && m.Sender == sender));
    }
}
