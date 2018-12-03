using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgTools.Model
{
    public class TalentoModel 
    {
        public TalentoModel(int id, string Name, string Description)
        {
            this.Id = id;
            this.Name = Name;
            this.Description = Description;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}