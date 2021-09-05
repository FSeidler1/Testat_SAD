using Backend.Model;
using CarRent_Testat_SAD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Backend.Interface
{
    public interface IReservierungService
    {
        List<Reservierung> GetAll();

        List<Reservierung> GetById(Guid id);

        void Add(Reservierung entity);

        void DeleteById(Guid id);

        void Delete(Reservierung entity);

        void Update(Reservierung entity);
    }
}
