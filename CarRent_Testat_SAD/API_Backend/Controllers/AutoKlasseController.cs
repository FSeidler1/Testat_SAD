using API_Backend.Interface;
using AutoMapper;
using Backend.Model;
using CarRent_Testat_SAD.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API_Backend.Controllers.AutoVermietung
{
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class AutoKlasseController
    {
        private readonly IAutoKlasseService _service;
        private readonly IMapper _mapper;

        public AutoKlasseController(IAutoKlasseService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public List<AutoKlasseDTO> Get()
        {
            return _service.GetAll().Select(car => _mapper.Map<AutoKlasseDTO>(car)).ToList();
        }

        [HttpGet("{id}")]
        public List<AutoKlasseDTO> Get(Guid id)
        {
            return _service.GetById(id).Select(car => _mapper.Map<AutoKlasseDTO>(car)).ToList();
        }
        
        [HttpPost]
        public void Post([FromBody] AutoKlasseDTO entity)
        {
            var c = _mapper.Map<AutoKlasse>(entity);
            _service.Add(c);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] AutoKlasseDTO entity)
        {
            var c = _mapper.Map<AutoKlasse>(entity);
            _service.Update(c);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _service.DeleteById(id);
        }

    }
}
