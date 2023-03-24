﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class BlackJackGame : Game, IWalkAway
    {
        public BlackJackDealer Dealer { get; set; }
        public override void Play()
        {
            Dealer = new BlackJackDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Console.WriteLine("Place your bet!");

            foreach(Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing..");
                foreach(Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = BlackJackRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("BlackJack: {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.Write("Dealer:");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = BlackJackRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has Blackjack! Everyone loses");
                        foreach(KeyValuePair<Player, int > entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if(answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = BlackJackRules.isBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! you lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again!");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.IsActivlyPlaying = true;
                        }
                        else
                        {
                            player.IsActivlyPlaying = false;
                        }
                    }
                }
            }
            Dealer.isBusted = BlackJackRules.isBusted(Dealer.Hand);
            Dealer.Stay = BlackJackRules.ShouldDealerStay(Dealer.Hand);
            while(!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = BlackJackRules.isBusted(Dealer.Hand);
                Dealer.Stay = BlackJackRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is Staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted!");
                foreach(KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} Won {1}", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach (Player player in Players)
            {
                bool? playerWon = BlackJackRules.CompareHands(player.Hand && Dealer.Hand);
            }

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

