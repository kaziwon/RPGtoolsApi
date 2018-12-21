using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RpgTools.Model
{
    public class ItemModel
    {
        public int id;
        public string Description;
        public ICollection<TalentoModel> Talento;
        public StatusModel status;
        
        
       
    }
}