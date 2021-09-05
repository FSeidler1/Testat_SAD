using API_Backend.Interface;
using AutoMapper;
using Backend.Model;
using CarRent_Testat_SAD.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Backend.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class AutoController
    {
        private readonly IAutoService _AutoService;
        private readonly IMapper _Mapper;

        public AutoController(IAutoService carService, IMapper mapper)
        {
            _AutoService = carService;
            _Mapper = mapper;
        }

        [HttpGet]
        public List<AutoDTO> Get()
        {
            return _AutoService.GetAll().Select(auto => _Mapper.Map<AutoDTO>(auto)).ToList();
        }

        [HttpGet("{id}")]
        public List<AutoDTO> Get(Guid id)
        {
            return _AutoService.GetById(id).Select(auto => _Mapper.Map<AutoDTO>(auto)).ToList();
        }

        [HttpGet("search/{searchTerm}")]
        public List<AutoDTO> Search(string searchTerm)
        {
            return _AutoService.GetAll()
                .Where(x => x.Marke.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase) || x.Typ.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase))
                .Select(x => _Mapper.Map<AutoDTO>(x)).ToList();
        }

        [HttpPost]
        public void Post([FromBody] AutoDTO auto)
        {
            var c = _Mapper.Map<Auto>(auto);
            _AutoService.Add(c);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] AutoDTO auto)
        {
            var c = _Mapper.Map<Auto>(auto);
            _AutoService.Update(c);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _AutoService.DeleteById(id);
        }

    }
}
