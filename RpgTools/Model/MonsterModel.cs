using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace RpgTools.Model
{
    public class MonsterModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Armor { get; set; }
        public string HitPoints { get; set; }
        public string Speed { get; set; }
        public StatusModel Status { get; set; }
        public List<string> Skills { get; set; }
        public List<string> Vulnerabilities { get; set; }
        public List<TalentoModel> Talent { get; set; }
        public List<ActionModel> Action { get; set; }
    }
}