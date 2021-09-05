using API_Backend.Interface;
using Backend.Context;
using CarRent_Testat_SAD.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Backend.Repository
{
    public class KundeRepository : IRepository<Kunde, Guid>
    {
        private readonly CarRentDbContext _carRentDbContext;

        public KundeRepository(CarRentDbContext carRentDbContext)
        {
            _carRentDbContext = carRentDbContext;
        }

        public List<Kunde> GetAll()
        {
            return _carRentDbContext.Kunden.Include(x => x.PLZ).ToList();
        }

        public List<Kunde> FindById(Guid id)
        {
            return _carRentDbContext.Kunden.Include(x => x.PLZ).Where(x => x.Id.Equals(id)).ToList();
        }

        public void Insert(Kunde entity)
        {
            _carRentDbContext.Add(entity);
            _carRentDbContext.SaveChanges();
        }

        public void Update(Kunde entity)
        {
            _carRentDbContext.Update(entity);
            _carRentDbContext.SaveChanges();
        }

        public void Remove(Guid id)
        {
            Remove(FindById(id).FirstOrDefault());
        }

        public void Remove(Kunde entity)
        {
            _carRentDbContext.Remove(entity);
            _carRentDbContext.SaveChanges();
        }
    }
}
