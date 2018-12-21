using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgTools.Model
{
    public class CharacterModel
    {
        public int id{get;set;}
        public string Name{get;set;}
        public string Class{get;set;}
        public int Level{get;set;}
        public string Alignment{get;set;}
        public ICollection<string> Inventory{get;set;}
        public StatusModel Status{get;set;}
        public ICollection<ActionModel> Action{get;set;}
        public ICollection<TalentoModel> Talent{get;set;}



       
    }
}