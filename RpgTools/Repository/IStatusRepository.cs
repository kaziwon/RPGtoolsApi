using RpgTools.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RpgTools.Repository.Implementations;

namespace RpgTools.Repository
{
   public interface IStatusRepository
    {
        StatusModel Create(StatusModel status);
        StatusModel FindById(long id);
        ICollection<StatusModel> FindAll();
        StatusModel Update(StatusModel status);
        void Delete(long id);
      
    }
}
