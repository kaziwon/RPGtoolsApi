using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RpgTools.Model;
using RpgTools.Repository;

namespace RpgTools.Business.Implementations
{
    public class ActionBusinessImpl : IActionBusiness
    {
        private readonly IActionRepository _repository;

        public ActionBusinessImpl(IActionRepository actionRepository)
        {
            _repository = actionRepository;
        }

        public ActionModel Create(ActionModel action)
        {
            return _repository.Create(action);
        }

        public void Delete(int? id)
        {
             _repository.Delete(id);
        }

        public ICollection<ActionModel> FindAll()
        {
            return _repository.FindAll();
        }

        public ActionModel FindById(int? id)
        {
            return _repository.FindById(id);
        }

        public ActionModel Update(ActionModel action)
        {
            return _repository.Update(action);
        }
    }
}
