using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RpgTools.Model;
using RpgTools.Repository;

namespace RpgTools.Business.Implementations
{
    public class StatusBusinessImpl : IStatusBusiness
    {
        private readonly IStatusRepository _repository;

        public StatusBusinessImpl(IStatusRepository repository)
        {
            _repository = repository;
        }
        public StatusModel Create(StatusModel status)
        {
           return  _repository.Create(status);
        }

        public void Delete(long id)
        {
           _repository.Delete(id);
        }

        public ICollection<StatusModel> FindAll()
        {
           return _repository.FindAll();
        }

        public StatusModel FindById(long id)
        {
            return _repository.FindById(id);
        }

        public StatusModel Update(StatusModel status)
        {
            return _repository.Update(status);
        }
    }
}
