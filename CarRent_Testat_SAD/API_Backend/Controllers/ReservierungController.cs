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
    public class ReservierungController : ControllerBase
    {
        private readonly IReservierungService _service;
        private readonly IMapper _mapper;

        public ReservierungController(IReservierungService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public List<ReservierungDTO> Get()
        {
            return _service.GetAll().Select(entity => _mapper.Map<ReservierungDTO>(entity)).ToList();
        }

        [HttpGet("{id}")]
        public List<ReservierungDTO> Get(Guid id)
        {
            return _service.GetById(id).Select(entity => _mapper.Map<ReservierungDTO>(entity)).ToList();
        }

        [HttpPost]
        public void Post([FromBody] ReservierungDTO entity)
        {
            var c = _mapper.Map<Reservierung>(entity);
            _service.Add(c);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] ReservierungDTO entity)
        {
            var c = _mapper.Map<Reservierung>(entity);
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
