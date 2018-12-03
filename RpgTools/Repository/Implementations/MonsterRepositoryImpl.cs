using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RpgTools.Model;

namespace RpgTools.Repository.Implementations
{
    public class MonsterRepositoryImpl : IMonsterRepository
    {
        public static MonsterModel monstermock;
        public static List<ActionModel> actionmock;
        public static StatusModel statusmock;
        public static List<TalentoModel> talentomock;

        
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
            throw new NotImplementedException();
        }

        public MonsterModel FindById(long id)
        {
            actionmock = new List<ActionModel>();
            actionmock.Add(new ActionModel(1, "Atacar", "Dá um ataque"));

            monstermock = new MonsterModel();
            monstermock.Name = "Jorge";
            monstermock.Id = 1;
            monstermock.Armor = 42;
            monstermock.Description = "Jorge é um monstro";
            monstermock.HitPoints = 442;
            monstermock.Speed = 2;
            monstermock.Status = new StatusModel(10,2,10,1,1,2);
           
            

            return monstermock;
        }

        public MonsterModel Update(MonsterModel monster)
        {
            throw new NotImplementedException();
        }
    }
}
