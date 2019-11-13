using BangBangDomain.Cards.Interface;
using System;
using System.Linq;

namespace BangBangDomain.PlayableCharacters.Interface
{
    public abstract class PlayableCharacter
    {
        public abstract int Health { get; }
        public bool IsDead => Health == 0;
        public Player Player;
        public virtual int InnateRange { get; set; } = 0;
        public virtual int InnateDistance { get; set; } = 0;
        public abstract string Name { get; }
        public abstract string Description { get; }

        public virtual void Draw() {
            for (var i = 0; i < 2; i++)
            {
                var card = this.Player.Game.Cards.Draw();
                this.Player.Hand.Add(card);
            }    
        }

        public virtual void Act() { }

        public virtual void Discard(ICard card)
        {
            var cardInHand = this.Player.Hand.FirstOrDefault(c => c.Name == card.Name);

            if (cardInHand != null)
            {
                this.Player.Hand.Remove(cardInHand);
            } else
            {
                throw new Exception("No such card in your hand!");
            }
        }
    }
}