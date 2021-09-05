using CarRent_Testat_SAD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CarRent_Testat_SAD.Model.AutoKlasse;

namespace API_Backend.Interface
{
    public interface IAutoService
    {
        List<Auto> GetAll();

        List<Auto> GetById(Guid id);

        List<Auto> GetByType(AutoKlasseTyp type);

        void Add(Auto car);

        void DeleteById(Guid id);

        void Delete(Auto car);

        void Update(Auto car);
    }
}
