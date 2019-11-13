using BangBangDomain.Cards.Enum;

namespace BangBangDomain.Cards.Interface
{
    public abstract class BasicCard : ICard
    {
        public abstract CardSuit Suit { get; set; }
        public CardTypeEnum CardType { get; } = CardTypeEnum.Basic;
        public abstract void PlayCard(Player player);
    }
}