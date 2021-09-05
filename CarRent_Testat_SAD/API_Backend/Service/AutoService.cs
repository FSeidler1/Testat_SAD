using System;
using System.Collections.Generic;
using System.Linq;
using API_Backend.Interface;
using CarRent_Testat_SAD.Model;
using static CarRent_Testat_SAD.Model.AutoKlasse;

namespace API_Backend.Service
{
    public class AutoService : IAutoService
    {
        private readonly IRepository<Auto, Guid> _repository;

        public AutoService(IRepository<Auto, Guid> repository)
        {
            _repository = repository;
        }

        public List<Auto> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Auto> GetById(Guid id)
        {
            return _repository.FindById(id);
        }

        public List<Auto> GetByType(AutoKlasseTyp typ)
        {
            return GetAll().Where(x => x.Klasse.Typ == typ).ToList();
        }

        public void Add(Auto auto)
        {
            _repository.Insert(auto);
        }

        public void DeleteById(Guid id)
        {
            _repository.Remove(id);
        }

        public void Delete(Auto entity)
        {
            _repository.Remove(entity);
        }

        public void Update(Auto auto)
        {
            _repository.Update(auto);
        }
    }
}
