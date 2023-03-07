using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>() { "Diamonds", "Spades", "Hearts", "Clubs" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "Kind", "Ace"
            };

            foreach (string suit in Suits)
            {
                foreach (string face in Faces)
                {
                    Card card = new Card();
                    card.Face = face;
                    card.Suit = suit;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

    }
}
