using RpgTools.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgTools.Business
{
   public interface IActionBusiness
    {
        ActionModel Create(ActionModel action);
        ActionModel FindById(int? id);
        List<ActionModel> FindAll();
        ActionModel Update(ActionModel action);
        void Delete(int? id);
    }
}
