﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Program
    {
        static void Main(string[] args)
        {
            BlackJackGame game = new BlackJackGame();
            game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            game.ListPlayer();
            Console.ReadLine();
            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }

    }

}
