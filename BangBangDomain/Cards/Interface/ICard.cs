using BangBangDomain.Cards.Enum;

namespace BangBangDomain.Cards.Interface
{
    public interface ICard
    {
        CardSuit Suit { get; set;  }
        CardTypeEnum CardType { get; }
        string Name { get; }
        string Description { get; }
        void PlayCard(Player player);
    }
}
