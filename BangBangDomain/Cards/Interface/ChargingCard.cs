using BangBangDomain.Cards.Enum;

namespace BangBangDomain.Cards.Interface
{
    public abstract class ChargingCard : ICard
    {
        public abstract CardSuit Suit { get; set; }
        public CardTypeEnum CardType { get; } = CardTypeEnum.Equipment;
        public abstract void PlayCard(Player player);
    }
}