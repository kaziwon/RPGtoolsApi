using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using RpgTools.Model;
using MySql.Data.MySqlClient;
using RpgTools.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace RpgTools.Repository.Implementations
{
    public class MonsterRepositoryImpl : IMonsterRepository
    {
        // public static MonsterModel monstermock;
        // public static List<ActionModel> actionmock;
        // public static StatusModel statusmock;
        // public static List<TalentoModel> talentomock;
        private List<MonsterModel> _monstersingle = new List<MonsterModel>();

        private readonly MySQLContext _context;

        public MonsterRepositoryImpl(MySQLContext context)
        {
            _context = context;
        }

        public MonsterModel Create(MonsterModel monster)
        {

            _monstersingle.Add(monster);
            return monster;
        }

        public void Delete(long id)
        {
            _monstersingle.Remove(FindById(id));
        }

        public List<MonsterModel> FindAll()
        {
            var teste = _context.Monsters.Include(x => x.Action).ToList();
            return teste;
            // return _monstersingle;
        }

        public MonsterModel FindById(long id)
        {
            return _monstersingle.Where(a => a.Id == id).Single();
        }

        public MonsterModel Update(MonsterModel monster)
        {
            _monstersingle.Where(a => a.Id == monster.Id)
            .ToList().ForEach(ab =>
            {
                //ab.Action = monster.Action;
                ab.Armor = monster.Armor;
                ab.Description = monster.Description;
                ab.HitPoints = monster.HitPoints;
                ab.Name = monster.Name;
                // ab.Skills = monster.Skills;
                // ab.Speed = monster.Speed;
                // ab.Status = monster.Status;
                // ab.Talent = monster.Talent;
                // ab.Vulnerabilities = monster.Vulnerabilities;

            });

            return FindById(monster.Id);
        }
    }
}



//  List<MonsterModel> listamonstermock = new List<MonsterModel>();
//             actionmock = new List<ActionModel>
//             {
//                 new ActionModel {Id =1, Name = "Atacar", Description = "Dá um ataque" },
//                 new ActionModel {Id = 2, Name = "Defender", Description = "Defende"}
//             };


//             talentomock = new List<TalentoModel>();
//             talentomock.Add(new TalentoModel(1, "Mortal", "Dá um mortal para tras"));

//             monstermock = new MonsterModel{
//                 Name = "Jorge",
//                 Id = 1,
//                 Armor = 42,
//                 Description = "Jorge é um monstro",
//                 HitPoints = 442,
//                 Speed = 2,
//                 Skills = new List<String>{
//                     "Rage",
//                     "Berserker"
//                 },
//                 Status = new StatusModel { 
//                     Strength =  10,
//                     Dexterity = 2,
//                     Constitution = 11,
//                     Intelligence = 1,
//                     Wisdom = 1,
//                     Charisma = 5 },
//                 Action = actionmock,
//                 Talent = talentomock,
//                 Vulnerabilities = new List<String>{
//                     "Poison",
//                     "Fire"
//                 }

//             };

//             listamonstermock.Add(monstermock);

//             return listamonstermock;