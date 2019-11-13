using System;
using System.Collections.Generic;
using System.Text;
using BangBangDomain.Cards.Interface;

namespace BangBangDomain
{
    public class PlayingCards
    {
        public Stack<ICard> Deck;
        public Stack<ICard> DiscardPile;

        private static Random rng = new Random();

        public PlayingCards(ICollection<ICard> cards)
        {
            this.Deck = new Stack<ICard>(cards);
            this.DiscardPile = new Stack<ICard>();
        }

        public void Shuffle(bool shuffleDiscardIntoDeck = false)
        {
            var cardsToShuffle = new List<ICard>(Deck);
            if (shuffleDiscardIntoDeck) cardsToShuffle.AddRange(new List<ICard>(DiscardPile));

            int n = cardsToShuffle.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                ICard value = cardsToShuffle[k];
                cardsToShuffle[k] = cardsToShuffle[n];
                cardsToShuffle[n] = value;
            }

            this.Deck = new Stack<ICard>(cardsToShuffle);
            if (shuffleDiscardIntoDeck) this.DiscardPile = new Stack<ICard>();
        }

        public ICard Draw()
        {
            return this.Deck.Pop();
        }

        public void Discard(ICard card)
        {
            this.DiscardPile.Push(card);
        }
    }
}
