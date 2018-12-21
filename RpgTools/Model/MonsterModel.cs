﻿using System;
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
        public string Armor { get; set; }
        public int HitPoints { get; set; }
        public string Speed { get; set; }
        public StatusModel Status { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<string> Vulnerabilities { get; set; }
        public ICollection<TalentoModel> Talent { get; set; }
        public ICollection<ActionModel> Action { get; set; }
    }
}