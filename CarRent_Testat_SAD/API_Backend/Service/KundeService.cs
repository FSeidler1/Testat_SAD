using API_Backend.Interface;
using CarRent_Testat_SAD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Backend.Service
{
    public class KundeService : IKundeService
    {
        private readonly IRepository<Kunde, Guid> _repository;

        public KundeService(IRepository<Kunde, Guid> repository)
        {
            _repository = repository;
        }

        public List<Kunde> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Kunde> GetById(Guid id)
        {
            return _repository.FindById(id);
        }

        public void Add(Kunde entity)
        {
            _repository.Insert(entity);
        }

        public void DeleteById(Guid id)
        {
            _repository.Remove(id);
        }

        public void Delete(Kunde entity)
        {
            _repository.Remove(entity);
        }

        public void Update(Kunde entity)
        {
            _repository.Update(entity);
        }
    }
}
