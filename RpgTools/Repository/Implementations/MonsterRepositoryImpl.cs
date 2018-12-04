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
            List<MonsterModel> listamonstermock = new List<MonsterModel>();
            actionmock = new List<ActionModel>
            {
                new ActionModel {Id =1, Name = "Atacar", Description = "Dá um ataque" },
                new ActionModel {Id = 2, Name = "Defender", Description = "Defende"}
            };


            talentomock = new List<TalentoModel>();
            talentomock.Add(new TalentoModel(1, "Mortal", "Dá um mortal para tras"));

            monstermock = new MonsterModel{
                Name = "Jorge",
                Id = 1,
                Armor = 42,
                Description = "Jorge é um monstro",
                HitPoints = 442,
                Speed = 2,
                Skills = new List<String>{
                    "Rage",
                    "Berserker"
                },
                Status = new StatusModel { 
                    Strength =  10,
                    Dexterity = 2,
                    Constitution = 11,
                    Intelligence = 1,
                    Wisdom = 1,
                    Charisma = 5 },
                Action = actionmock,
                Talent = talentomock,
                Vulnerabilities = new List<String>{
                    "Poison",
                    "Fire"
                }

            };

            // monstermock.Name = "Jorge";
            // monstermock.Id = 1;
            // monstermock.Armor = 42;
            // monstermock.Description = "Jorge é um monstro";
            // monstermock.HitPoints = 442;
            // monstermock.Speed = 2;
            // monstermock.Skills = new List<string>();
            // monstermock.Status = new StatusModel { Strength =  10, Dexterity = 2, Constitution = 11, Intelligence = 1, Wisdom = 1, Charisma = 5 };
            // monstermock.Action = actionmock;    
            // monstermock.Talent = talentomock;

            listamonstermock.Add(monstermock);

            return listamonstermock;
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
