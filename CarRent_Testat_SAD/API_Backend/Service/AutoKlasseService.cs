using API_Backend.Interface;
using CarRent_Testat_SAD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Backend.Service
{
    public class AutoKlasseService : IAutoKlasseService
    {
        private readonly IRepository<AutoKlasse, Guid> _repository;

        public AutoKlasseService(IRepository<AutoKlasse, Guid> repository)
        {
            _repository = repository;
        }

        public List<AutoKlasse> GetAll()
        {
            return _repository.GetAll();
        }

        public List<AutoKlasse> GetById(Guid id)
        {
            return _repository.FindById(id);
        }

        public void Add(AutoKlasse entity)
        {
            _repository.Insert(entity);
        }

        public void DeleteById(Guid id)
        {
            _repository.Remove(id);
        }

        public void Delete(AutoKlasse entity)
        {
            _repository.Remove(entity);
        }

        public void Update(AutoKlasse entity)
        {
            _repository.Update(entity);
        }

    }
}
