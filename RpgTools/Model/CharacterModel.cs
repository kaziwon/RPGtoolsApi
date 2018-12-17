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
        public List<string> Inventory{get;set;}
        public StatusModel Status{get;set;}
        public List<ActionModel> Action{get;set;}
        public List<TalentoModel> Talent{get;set;}



       
    }
}