using API_Backend.Interface;
using Backend.Model;
using CarRent_Testat_SAD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Backend.Service
{
    public class ReservierungService : IReservierungService
    {
        private readonly IRepository<Reservierung, Guid> _repository;

        public ReservierungService(IRepository<Reservierung, Guid> repository)
        {
            _repository = repository;
        }

        public List<Reservierung> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Reservierung> GetById(Guid id)
        {
            return _repository.FindById(id);
        }

        public void Add(Reservierung entity)
        {
            _repository.Insert(entity);
        }

        public void DeleteById(Guid id)
        {
            _repository.Remove(id);
        }

        public void Delete(Reservierung entity)
        {
            _repository.Remove(entity);
        }

        public void Update(Reservierung entity)
        {
            _repository.Update(entity);
        }
    }
}
