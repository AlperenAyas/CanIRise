using CanIRise.Services.PersonMS.Business.Dtos.ContactTypeDtos;
using CanIRise.Services.PersonMS.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CanIRise.Services.PersonMS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactTypesController : ControllerBase
    {
        private readonly IContactTypeService _service;

        public ContactTypesController(IContactTypeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok(_service.GetById(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody] ContactTypeCreateDto dto)
        {
            try
            {
                return Create(_service.Create(dto));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] ContactTypeUpdateDto dto)
        {
            try
            {
                _service.Update(dto);
                return NoContent();
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(Guid id)
        {
            try
            {
                _service.Remove(id);
                return NoContent();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
