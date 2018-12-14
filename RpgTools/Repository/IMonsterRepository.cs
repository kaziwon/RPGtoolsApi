using RpgTools.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RpgTools.Repository.Implementations;

namespace RpgTools.Repository
{
   public interface IMonsterRepository
    {
        MonsterModel Create(MonsterModel monster);
        MonsterModel FindById(long id);
        List<MonsterModel> FindAll();
        MonsterModel Update(MonsterModel monster);
        void Delete(long id);
      
    }
}
