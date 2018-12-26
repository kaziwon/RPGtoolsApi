using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using RpgTools.Model;
using MySql.Data.MySqlClient;
using RpgTools.Model.Context;

namespace RpgTools.Repository.Implementations
{
    public class StatusRepositoryImpl : IStatusRepository
    {

        private readonly MySQLContext _context;
        public StatusRepositoryImpl(MySQLContext context)
        {
            _context = context;
        }
        public StatusModel Create(StatusModel status)
        {
            try
            {
                _context.Status.Add(status);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }

            return status;


        }

        public void Delete(long id)
        {
            var result = FindById(id);
            try
            {
                if(result != null){
                    _context.Status.Remove(result);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ICollection<StatusModel> FindAll()
        {
            return _context.Status.ToList();
        }

        public StatusModel FindById(long id)
        {
            return _context.Status.Where(a => a.Id == id).First();
        }

        public StatusModel Update(StatusModel status)
        {
           var result = FindById(status.Id);
           if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(status);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return result;

        }
    }
}