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

        public MonsterBusinessImpl(IMonsterRepository monsterRepository)
        {
            _repository = monsterRepository;
        }

        public MonsterModel Create(MonsterModel monster)
        {
           return  _repository.Create(monster);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public ICollection<MonsterModel> FindAll()
        {
           return _repository.FindAll();
        }

        public MonsterModel FindById(long id)
        {
            return _repository.FindById(id);
        }

        public MonsterModel Update(MonsterModel monster)
        {
            return _repository.Update(monster);
        }
    }
}
