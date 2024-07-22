using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mafia.Model;

namespace Mafia.Actions.Interfaces
{
    public interface IAction
    {
        public IEnumerable<Player> PlayerFilter(IEnumerable<Player> players, Player sender, int dayNumber);
        public void Perform(Player sender, Player receiver, int moveNumper);

    }
}
