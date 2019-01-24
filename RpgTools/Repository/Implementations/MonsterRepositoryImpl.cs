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

            var result = FindById(id);
            try{
                if(result != null){
                    _context.Monsters.Remove(result);
                    _context.SaveChanges();
                }
            }catch(Exception e){
                throw e;
            }
        }

        public List<MonsterModel> FindAll()
        {
            var monsterList = _context.Monsters.Include(monster => monster.Action).Include(monster => monster.Status).ToList();
            return monsterList;

        }

        public MonsterModel FindById(long id)
        {
            return _context.Monsters.Where(a => a.Id == id).
                                     Include(monster => monster.Action).
                                     Include(monster => monster.Status).
                                     Single();
        }

        public MonsterModel Update(MonsterModel monster)
        {
            var result = FindById(monster.Id);
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(monster);
                    _context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return result;
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