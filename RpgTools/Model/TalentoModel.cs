using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RpgTools.Model
{
    [Table("talent")]
    public class TalentoModel 
    {
         
        [Column("ID_TALENT")]
        public int Id { get; set; }
        public string Name { get; set; }
         
        public string Description { get; set; }

        [NotMapped]
        [Column("ID_MONSTER")]
        public int IdMonster { get; set; }

        [ForeignKey("IdMonster")]
        public MonsterModel monster { get; set; }
    }
}