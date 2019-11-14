using BangBangDomain.Cards.Enum;
using BangBangDomain.Cards.Interface;

namespace BangBangDomain.Cards.Weapons
{
    public class Volcanic : EquipableCard
    {
        public override CardSuit Suit { get; set; }
        public override string Name { get; } = "Volcanic";
        public override string Description { get; } = "Weapon with 1 range. You can play any number of BANG! cards per turn.";
    }
}