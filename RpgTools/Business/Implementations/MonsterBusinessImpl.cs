using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RpgTools.Model;
using RpgTools.Repository;

namespace RpgTools.Business.Implementations
{
    public class MonsterBusinessImpl : IMonsterBusiness
    {
        private readonly IMonsterRepository _repository;
        public MonsterModel Create(MonsterModel monster)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<MonsterModel> FindAll()
        {
           return _repository.FindAll();
        }

        public MonsterModel FindById(long id)
        {
            throw new NotImplementedException();
        }

        public MonsterModel Update(MonsterModel monster)
        {
            throw new NotImplementedException();
        }
    }
}
