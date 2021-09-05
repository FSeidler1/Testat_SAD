using CarRent_Testat_SAD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Backend.Interface
{
    public interface IKundeService
    {
        List<Kunde> GetAll();

        List<Kunde> GetById(Guid id);

        void Add(Kunde entity);

        void DeleteById(Guid id);

        void Delete(Kunde entity);

        void Update(Kunde entity);
    }
}
