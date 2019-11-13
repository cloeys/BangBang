using System;
using System.Collections.Generic;
using System.Text;
using BangBangDomain.Cards.Interface;
using BangBangDomain.PlayableCharacters.Interface;
using BangBangDomain.Roles.Interface;

namespace BangBangDomain
{
    public class Player
    {
        public Game Game { get; set; }
        public PlayableCharacter Character { get; set; }
        public IRole Role { get; set; }
        public List<ICard> Hand { get; set; }
        public List<EquipableCard> Equipment { get; set; }
        public List<ChargingCard> ChargingCards { get; set; }

        public Player(Game game, IRole role, PlayableCharacter character)
        {
            this.Game = game;
            this.Role = role;
            this.Character = character;

            this.Character.Player = this;
        }

        public void Draw()
        {
            this.Character.Draw();
        }
        
    }
}
