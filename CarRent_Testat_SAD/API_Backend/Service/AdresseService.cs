using API_Backend.Interface;
using CarRent_Testat_SAD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Backend.Service
{
    public class AdresseService : IAdresseService
    {
        private readonly IRepository<Adresse, Guid> _repository;

        public AdresseService(IRepository<Adresse, Guid> repository)
        {
            _repository = repository;
        }

        public List<Adresse> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Adresse> GetById(Guid id)
        {
            return _repository.FindById(id);
        }

        public void Add(Adresse entity)
        {
            _repository.Insert(entity);
        }

        public void DeleteById(Guid id)
        {
            _repository.Remove(id);
        }

        public void Delete(Adresse entity)
        {
            _repository.Remove(entity);
        }

        public void Update(Adresse entity)
        {
            _repository.Update(entity);
        }
    }
}
