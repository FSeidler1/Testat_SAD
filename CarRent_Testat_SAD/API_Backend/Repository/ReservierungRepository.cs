using API_Backend.Interface;
using Backend.Context;
using Backend.Model;
using CarRent_Testat_SAD.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Backend.Repository
{
    public class ReservierungRepository : IRepository<Reservierung, Guid>
    {
        private readonly CarRentDbContext _carRentDbContext;

        public ReservierungRepository(CarRentDbContext carRentDbContext)
        {
            _carRentDbContext = carRentDbContext;
        }

        public List<Reservierung> GetAll()
        {
            return _carRentDbContext.Reservierungen.Include(x => x.Auto).Include(x => x.Kunde).ToList();
        }

        public List<Reservierung> FindById(Guid id)
        {
            return _carRentDbContext.Reservierungen.Include(x => x.Auto).Include(x => x.Kunde).Where(x => x.Id.Equals(id)).ToList();
        }

        public void Insert(Reservierung entity)
        {
            _carRentDbContext.Add(entity);
            _carRentDbContext.SaveChanges();
        }

        public void Update(Reservierung entity)
        {
            _carRentDbContext.Update(entity);
            _carRentDbContext.SaveChanges();
        }

        public void Remove(Guid id)
        {
            Remove(FindById(id).FirstOrDefault());
        }

        public void Remove(Reservierung entity)
        {
            _carRentDbContext.Remove(entity);
            _carRentDbContext.SaveChanges();
        }
    }
}
