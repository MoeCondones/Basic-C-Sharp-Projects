using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class BlackJackGame : Game, IWalkAway
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }
        public override void ListPlayer()
        {
            Console.WriteLine("BlackJack PLayers: ");
            base.ListPlayer();
        }
        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
