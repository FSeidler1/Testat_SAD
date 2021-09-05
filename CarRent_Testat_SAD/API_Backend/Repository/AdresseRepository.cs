using API_Backend.Interface;
using Backend.Context;
using CarRent_Testat_SAD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Backend.Repository
{
    public class AdresseRepository : IRepository<Adresse, Guid>
    {
        private readonly CarRentDbContext _carRentDbContext;

        public AdresseRepository(CarRentDbContext carRentDbContext)
        {
            _carRentDbContext = carRentDbContext;
        }

        public List<Adresse> GetAll()
        {
            return _carRentDbContext.Adressen.ToList();
        }

        public List<Adresse> FindById(Guid id)
        {
            return _carRentDbContext.Adressen.Where(x => x.Id.Equals(id)).ToList();
        }

        public void Insert(Adresse entity)
        {
            _carRentDbContext.Add(entity);
            _carRentDbContext.SaveChanges();
        }

        public void Update(Adresse entity)
        {
            _carRentDbContext.Update(entity);
            _carRentDbContext.SaveChanges();
        }

        public void Remove(Guid id)
        {
            Remove(FindById(id).FirstOrDefault());
        }

        public void Remove(Adresse entity)
        {
            _carRentDbContext.Remove(entity);
            _carRentDbContext.SaveChanges();
        }
    }
}
