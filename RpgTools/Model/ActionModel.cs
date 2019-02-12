using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;

namespace RpgTools.Model
{
    [Table("actions")]
    public class ActionModel 
    {
      
     
        [Column("id_action")]
        [JsonProperty(PropertyName = "ActionID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("name")]
        [JsonProperty(PropertyName="ActionName")]
        public string Name { get; set; }
        [Column("description")]
        [JsonProperty(PropertyName="ActionDescription")]
        public string Description { get; set; }
        [Column("ID_MONSTER")]
        [JsonProperty(PropertyName="MonsterID")]
        public int IdMonster{get;set;}

        [ForeignKey("IdMonster")]
        public MonsterModel monster {get;set;}
    }
}