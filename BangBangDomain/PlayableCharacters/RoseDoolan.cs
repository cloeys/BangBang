using BangBangDomain.PlayableCharacters.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BangBangDomain.PlayableCharacters
{
    public class RoseDoolan : PlayableCharacter
    {
        public override string Name => "Rose Doolan";

        public override string Description => "She sees all players by a distance decreased by 1.";

        public override int Health => 4;

        public override int InnateRange { get; set; } = 1;
        
    }
}
