using CarRent_Testat_SAD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Backend.Interface
{
    public interface IAutoKlasseService
    {
        List<AutoKlasse> GetAll();

        List<AutoKlasse> GetById(Guid id);

        void Add(AutoKlasse auto);

        void DeleteById(Guid id);

        void Delete(AutoKlasse auto);

        void Update(AutoKlasse auto);

    }
}
