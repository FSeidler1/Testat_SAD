using API_Backend.Interface;
using AutoMapper;
using Backend.Model;
using CarRent_Testat_SAD.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KundeController : ControllerBase
    {
        private readonly IKundeService _service;
        private readonly IMapper _mapper;

        public KundeController(IKundeService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public List<KundeDTO> Get()
        {
            return _service.GetAll().Select(entity => _mapper.Map<KundeDTO>(entity)).ToList();
        }

        [HttpGet("{id}")]
        public List<KundeDTO> Get(Guid id)
        {
            return _service.GetById(id).Select(entity => _mapper.Map<KundeDTO>(entity)).ToList();
        }

        [HttpGet("search/{searchTerm}")]
        public List<KundeDTO> Search(string searchTerm)
        {
            return _service.GetAll()
                .Where(x => x.Vorname.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase) || x.Nachname.Contains(searchTerm, StringComparison.InvariantCultureIgnoreCase))
                .Select(x => _mapper.Map<KundeDTO>(x)).ToList();
        }

        [HttpPost]
        public void Post([FromBody] KundeDTO entity)
        {
            var c = _mapper.Map<Kunde>(entity);
            _service.Add(c);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] KundeDTO entity)
        {
            var c = _mapper.Map<Kunde>(entity);
            c.Id = id;
            _service.Update(c);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _service.DeleteById(id);
        }
    }
}
