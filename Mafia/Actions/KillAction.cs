using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mafia.Actions.Interfaces;
using Mafia.Model;

namespace Mafia.Actions
{
    internal class KillAction : IAction
    {
        public void Perform(Player sender, Player receiver, int dayNumber)
        {
            receiver.Marks.Add(new Mark { Sender = sender, Action = this, DayNumber = dayNumber, Name = MarkName.Kill });
        }

        public IEnumerable<Player> PlayerFilter(IEnumerable<Player> players, Player sender, int dayNumber) =>
            players.Where(p =>
                p.IsAlive);

    }
}
