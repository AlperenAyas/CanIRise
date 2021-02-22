using CanIRise.Services.PersonMS.Business.Dtos.ContactDtos;
using CanIRise.Services.PersonMS.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CanIRise.Services.PersonMS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _service;

        public ContactsController(IContactService service)
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
        public IActionResult Post([FromBody] ContactCreateDto dto)
        {
            try
            {
                _service.Create(dto);
                return NoContent();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromBody] ContactUpdateDto dto)
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
