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
    public class AutoRepository : IRepository<Auto, Guid>
    {
        private readonly CarRentDbContext _carRentDbContext;

        public AutoRepository(CarRentDbContext carRentDbContext)
        {
            _carRentDbContext = carRentDbContext;
        }

        public List<Auto> GetAll()
        {
            return _carRentDbContext.Autos.Include(x => x.Klasse).ToList();
        }

        public List<Auto> FindById(Guid id)
        {
            return _carRentDbContext.Autos.Include(x => x.Klasse).Where(x => x.Id.Equals(id)).ToList();
        }

        public void Insert(Auto entity)
        {
            _carRentDbContext.Add(entity);
            _carRentDbContext.SaveChanges();
        }

        public void Update(Auto entity)
        {
            _carRentDbContext.Update(entity);
            _carRentDbContext.SaveChanges();
        }

        public void Remove(Guid id)
        {
            Remove(FindById(id).FirstOrDefault());
        }

        public void Remove(Auto entity)
        {
            _carRentDbContext.Remove(entity);
            _carRentDbContext.SaveChanges();
        }
    }
}
