using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace RpgTools.Model
{
    [Table("status")]
    public class StatusModel
    {
        [Column("ID_STATUS")]
        [JsonProperty(PropertyName = "StatusID")]
        [Key]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "Strength")]
        [Column("Strength")]
        public int Strength { get; set; }
        [JsonProperty(PropertyName = "Dexterity")]
        [Column("Dexterity")]
        public int Dexterity { get; set; }
        [JsonProperty(PropertyName = "Constitution")]
        [Column("Constitution")]
        public int Constitution { get; set; }
        [JsonProperty(PropertyName = "Intelligence")]
        [Column("Intelligence")]
        public int Intelligence { get; set; }
        [JsonProperty(PropertyName = "Wisdom")]
        [Column("Wisdom")]
        public int Wisdom { get; set; }
        [JsonProperty(PropertyName = "Charisma")]
        [Column("Charisma")]
        public int Charisma { get; set; }
        [Column("ID_MONSTER")]
        public int IdMonster { get; set; }
        
        [ForeignKey("IdMonster")]
        public MonsterModel monster { get; set; }
    }
}