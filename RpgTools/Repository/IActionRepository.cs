using RpgTools.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RpgTools.Repository.Implementations;

namespace RpgTools.Repository
{
   public interface IActionRepository
    {
        ActionModel Create(ActionModel action);
        ActionModel FindById(long id);
        List<ActionModel> FindAll();
        ActionModel Update(ActionModel action);
        void Delete(long id);
      
    }
}
