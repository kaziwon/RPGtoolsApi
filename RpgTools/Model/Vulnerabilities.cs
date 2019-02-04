using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace RpgTools.Model
{
    [Table("vulnerabilitie")]
    public class Vulnerabilities 
    {
        [Column("id_vulnerabilitie")]
        public int Id { get; set; }

        [Column("name_vulnerabilitie")]
        public string Name { get; set; }

        [Column("Description")]
        public string Description { get; set; }

          [Column("ID_MONSTER")]
        public int IdMonster { get; set; }
        
        [ForeignKey("IdMonster")]
        public MonsterModel monster { get; set; }
    }
}