using BangBangDomain.Cards.Enum;
using BangBangDomain.Cards.Interface;

namespace BangBangDomain.Cards.Weapons
{
    public class RevCarbine : EquipableCard
    {
        public override CardSuit Suit { get; set; }
        public override string Name { get; } = "Rev. Carbine";
        public override string Description { get; } = "Weapon with 4 range";
        public override int BonusRange { get; } = 3;
    }
}