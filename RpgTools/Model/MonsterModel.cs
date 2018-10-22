using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace RpgTools.Model
{
    public class MonsterModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Armor { get; set; }
        public int HitPoints { get; set; }
        public int Speed { get; set; }
        public StatusModel Status { get; set; }
        public List<string> Skills { get; set; }
        public List<string> Vulnerabilities { get; set; }
        public List<TalentoModel> Talent { get; set; }
        public List<ActionModel> Action { get; set; }
    }
}