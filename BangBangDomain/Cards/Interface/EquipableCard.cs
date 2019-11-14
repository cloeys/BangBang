using BangBangDomain.Cards.Enum;

namespace BangBangDomain.Cards.Interface
{
    public abstract class EquipableCard : ICard
    {
        public abstract CardSuit Suit { get; set; }
        public CardTypeEnum CardType { get; } = CardTypeEnum.Equipment;
        public abstract string Name { get; }
        public abstract string Description { get; }
        public virtual int BonusRange { get; } = 0;
        public virtual int BonusDistance { get; } = 0;

        public virtual void PlayCard(Player player)
        {
            player.Equipment.Add(this);
        }
    }
}