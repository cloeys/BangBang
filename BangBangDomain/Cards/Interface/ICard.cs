using BangBangDomain.Cards.Enum;

namespace BangBangDomain.Cards.Interface
{
    public interface ICard
    {
        CardSuit Suit { get; set;  }
        CardTypeEnum CardType { get; }
        string Name { get; }
        void PlayCard(Player player);
    }
}
