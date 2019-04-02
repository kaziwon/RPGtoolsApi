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
        private readonly IActionBusiness _actionBusiness;

        public MonsterBusinessImpl(IMonsterRepository monsterRepository, IActionBusiness actionBusiness)
        {
            _repository = monsterRepository;
            _actionBusiness = actionBusiness;
        }

        public MonsterModel Create(MonsterModel monster)
        {
            MonsterModel monsterRetorno = new MonsterModel
            {
                Name = monster.Name,
                Description = monster.Description,
                Armor = monster.Armor,
                HitPoints = monster.HitPoints,
                Speed = monster.Speed
            };

            var monstroBasic = _repository.Create(monsterRetorno);
            if (monstroBasic != null)
            {
                monsterRetorno.Action = CreateAction(monster, monstroBasic).Action;
            }
            return monsterRetorno;
        }

        public MonsterModel CreateAction(MonsterModel monster, MonsterModel monstroBasic)
        {
            foreach (ActionModel action in monster.Action)
            {
                action.IdMonster = monstroBasic.Id;
            }
            _actionBusiness.CreateMany(monster.Action);

            return monster;

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
