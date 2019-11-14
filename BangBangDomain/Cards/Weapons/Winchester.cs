using BangBangDomain.Cards.Enum;
using BangBangDomain.Cards.Interface;

namespace BangBangDomain.Cards.Weapons
{
    public class Winchester : EquipableCard
    {
        public override CardSuit Suit { get; set; }
        public override string Name { get; } = "Winchester";
        public override string Description { get; } = "Weapon with 5 range";
        public override int BonusRange { get; } = 4;
    }
}