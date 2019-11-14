using BangBangDomain.Cards.Enum;
using BangBangDomain.Cards.Interface;

namespace BangBangDomain.Cards.Weapons
{
    public class Remington : EquipableCard
    {
        public override CardSuit Suit { get; set; }
        public override string Name { get; } = "Remington";
        public override string Description { get; } = "Weapon with 3 range";
        public override int BonusRange { get; } = 2;
    }
}