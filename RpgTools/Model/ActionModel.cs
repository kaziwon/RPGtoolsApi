using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace RpgTools.Model
{
    [Table("actions")]
    public class ActionModel 
    {
     
        [Column("id_action")]
        [JsonProperty(PropertyName = "ActionID")]
        public int Id { get; set; }
        [Column("name")]
        [JsonProperty(PropertyName="ActionName")]
        public string Name { get; set; }
        [Column("description")]
        [JsonProperty(PropertyName="ActionDescription")]
        public string Description { get; set; }
        [Column("id_monster")]
        [JsonProperty(PropertyName="MonsterID")]
        public int IdMonster{get;set;}

        [ForeignKey("IdMonster")]
        public MonsterModel monster {get;set;}
    }
}