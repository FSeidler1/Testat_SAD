using API_Backend.Interface;
using Backend.Context;
using CarRent_Testat_SAD.Entity;
using CarRent_Testat_SAD.Helper;
using CarRent_Testat_SAD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Backend.Repository
{
    public class AutoKlasseRepository : IRepository<AutoKlasse, Guid>
    {
        private readonly CarRentEntities _carRentDbContext;

        public AutoKlasseRepository(CarRentEntities carRentDbContext)
        {
            _carRentDbContext = carRentDbContext;
        }

        public List<AutoKlasse> GetAll()
        {
            return _carRentDbContext.AutoKlassen.ToList();
        }

        public List<AutoKlasse> FindById(Guid id)
        {
            return _carRentDbContext.AutoKlassen.Where(x => x.Id.Equals(id)).ToList();
        }

        public void Insert(AutoKlasse entity)
        {
            _carRentDbContext.Add(entity);
            _carRentDbContext.SaveChanges();
        }

        public void Update(AutoKlasse entity)
        {
            _carRentDbContext.Update(entity);
            _carRentDbContext.SaveChanges();
        }

        public void Remove(Guid id)
        {
            Remove(FindById(id).FirstOrDefault());
        }

        public void Remove(AutoKlasse entity)
        {
            _carRentDbContext.Remove(entity);
            _carRentDbContext.SaveChanges();
        }

    }
}
