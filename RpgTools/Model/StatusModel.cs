using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgTools.Model
{
    public class StatusModel
    {
        public StatusModel(int Strength,int Dexterity, int Constitution, int Intelligence, int Wisdom, int Charisma )
        {
            this.Strength = Strength;
            this.Dexterity = Dexterity;
            this.Constitution = this.Constitution;
            this.Intelligence = Intelligence;
            this.Wisdom = Wisdom;
            this.Charisma = Charisma;
        }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
    }
}