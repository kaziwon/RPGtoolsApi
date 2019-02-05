using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;



namespace RpgTools.Model
{
    [Table("monsters")]
    public class MonsterModel
    {
        public MonsterModel()
        {
            Action = new List<ActionModel>();
        }
        [Column("ID_MONSTER")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Armor { get; set; }
       
        public int HitPoints { get; set; }
        public string Speed { get; set; }

        [InverseProperty("monster")]
        public List<ActionModel> Action { get; set; }

        [InverseProperty("monster")]
        public StatusModel Status { get; set; }

        [InverseProperty("monster")]
        public List<TalentoModel> Talent { get; set; }

        [InverseProperty("monster")]
        public List<Vulnerabilities> vulnerabilities { get; set; }

        // public List<string> Skills { get; set; }
        // public List<string> Vulnerabilities { get; set; }
    }
}