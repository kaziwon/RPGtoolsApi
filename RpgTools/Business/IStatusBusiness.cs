
using RpgTools.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RpgTools.Business
{
   public interface IStatusBusiness
    {
        StatusModel Create(StatusModel status);
        StatusModel FindById(long id);
        ICollection<StatusModel> FindAll();
        StatusModel Update(StatusModel status);
        void Delete(long id);
    }
}
