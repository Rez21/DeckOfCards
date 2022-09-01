using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class PlayCards
    {
        public void ShuffleCards()
        {
            Random random = new Random();
            var suits = new List<string> { "Diamond", "Heart", "Spades", "Club" };
            var rank = new List<string> { "2", "3", "4", "5", "6", "7", "8", "8", "9", "10", "J", "Q", "K", "A" };
            LinkedList<string> cards = new LinkedList<string>();
            LinkedList<string> players = new LinkedList<string>();
            for (int i = 0; i < suits.Count; i++)
            {
                foreach (var mem in rank)
                {
                    cards.AddLast(suits[i] + mem);
                }
            }

            Dictionary<string, LinkedList<string>> playWithCards = new Dictionary<string, LinkedList<string>>();

            int player = 1;
            while (player != 5)
            {

                LinkedList<string> card = new LinkedList<string>();
                while (card.Count < 9)
                {
                    int suit = random.Next(0, suits.Count);
                    int Rank = random.Next(0, rank.Count);
                    card.AddLast(rank[Rank] + suits[suit]);
                }
                playWithCards.Add((" player " + player), cards);
                player++;
            }
            foreach (var member in playWithCards)
            {
                players.AddLast(member.Key);
                Console.WriteLine(member.Key);
                Swapping(member.Value);
                Console.WriteLine(" ");
            }
        }
        public void Swapping(LinkedList<string> playarray)
        {
            Char[] arr = { '2', '3', '4', '5', '6', '7', '8', '9' };
            LinkedList<string> sorted = new LinkedList<string>();
            var temp = new LinkedList<string>();

            foreach (var i in playarray.OrderBy(value => value))
            {
                if (arr.Contains(i[0]))
                {
                    sorted.AddLast(i);
                }
                else
                {
                    temp.AddLast(i);
                }
            }

            foreach (var i in temp)
            {
                sorted.AddLast(i);
            }
            Console.WriteLine("******************** After Shuffling ********************");
            foreach (var member in sorted)
            {
                Console.WriteLine(" " + member + " ");
            }
        }
    }
}