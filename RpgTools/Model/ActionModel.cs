using System.ComponentModel.DataAnnotations.Schema;

namespace RpgTools.Model
{
    [Table("actions")]
    public class ActionModel 
    {
     
        [Column("id_action")]
        public int? Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("id_monster")]
        public int? IdMonster{get;set;}
    }
}