using Mafia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mafia
{
    public class Game
    {
        public Game(IEnumerable<Player> players)
        {
            //TODO
        }

        protected readonly IEnumerable<Player> _players;
        private readonly int _dayNumber = 0;
        private readonly bool _isDay = true;

        public void FinishNight()
        {
            foreach (var player in _players)
            {
                var marks = player.Marks.Where(m => m.DayNumber == _dayNumber).ToList();

                if(marks.Any( m => m.Name == MarkName.Heal))
                {
                    marks.RemoveAll(m => m.Name == MarkName.Kill);
                }

                var checkRoleMarks = marks.Where(m => m.Name == MarkName.CheckRole);
                if (checkRoleMarks.Any())
                {
                    foreach (var mark in checkRoleMarks)
                    {
                        Send(mark.Sender, $"Is mafia: { player.Role.Team == RoleTeam.Black}");
                    }
                }

                if (marks.Any(m => m.Name == MarkName.Kill))
                {
                    player.IsAlive = false;
                }
            }
        }



        public void Send(Player player, string message) 
        {
            //TODO
        }

    }
}
