using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RpgTools.Model
{
    [Table("status")]
    public class StatusModel
    {
        [Column("ID_STATUS")]
        [Key]
        public int Id {get; set;}
        [Column("Strength")]
        public int Strength { get; set; }
        [Column("Dexterity")]
        public int Dexterity { get; set; }
        [Column("Constitution")]
        public int Constitution { get; set; }
        [Column("Intelligence")]
        public int Intelligence { get; set; }
        [Column("Wisdom")]
        public int Wisdom { get; set; }
        [Column("Charisma")]
        public int Charisma { get; set; }
        [Column("ID_MONSTER")]
        public int? IdMonster {get; set;}
    }
}