using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using RpgTools.Model;
using MySql.Data.MySqlClient;
using RestNETCORE.Model.Context;

namespace RpgTools.Repository.Implementations
{
    public class ActionRepositoryImpl : IActionRepository
    {
        private readonly MySQLContext _context;

        public ActionRepositoryImpl(MySQLContext context)
        {
            _context = context;
        }
        public ActionModel Create(ActionModel action)
        {
            try{
                _context.Add(action);
                _context.SaveChanges();
            }catch(Exception e){
                throw e;
            }
            return action;
        }

        public void Delete(int? id)
        {
            var result = FindById(id);
            try{
                if(result != null){
                    _context.Actions.Remove(result);
                    _context.SaveChanges();
                }
            }catch(Exception e){
                throw e;
            }
        }

        public List<ActionModel> FindAll()
        {
            return _context.Actions.ToList();
        }

        public ActionModel FindById(int? id)
        {
           return _context.Actions.SingleOrDefault(a => a.Id == id);
        }

        public ActionModel Update(ActionModel action)
        {
             if (!Exists(action.Id)) return null;

         
            var result = FindById(action.Id);
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(action);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return result;
        }
         public bool Exists(long? id)
        {
            return _context.Actions.Any(b => b.Id.Equals(id));
        }
    }
}
