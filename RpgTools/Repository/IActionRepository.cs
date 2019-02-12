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
        ActionModel FindById(int id);
        ICollection<ActionModel> FindAll();
        ActionModel Update(ActionModel action);
        void Delete(int id);

        List<ActionModel> CreateMany(List<ActionModel> listAction);

        ActionModel FindByName(String nomeacao);
      
    }
}
