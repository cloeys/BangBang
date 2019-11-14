using System;
using System.Collections.Generic;
using System.Text;
using BangBangDomain.Cards.Enum;
using BangBangDomain.Cards.Interface;

namespace BangBangDomain.Cards
{
    public class Schofield : EquipableCard
    {
        public override CardSuit Suit { get; set; }
        public override string Name { get; } = "Schofield";
        public override string Description { get; } = "Weapon with 2 range";
        public override int BonusRange { get; } = 1;
    }
}
