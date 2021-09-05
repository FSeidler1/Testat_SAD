using CarRent_Testat_SAD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Backend.Interface
{
    public interface IAdresseService
    {
        List<Adresse> GetAll();

        List<Adresse> GetById(Guid id);

        void Add(Adresse entity);

        void DeleteById(Guid id);

        void Delete(Adresse entity);

        void Update(Adresse entity);
    }
}
