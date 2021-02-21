using CanIRise.Services.PersonMS.Business.Dtos.PersonDtos;
using CanIRise.Services.PersonMS.Business.Interfaces;
using CanIRise.Services.PersonMS.WebApi.RabbitMQPro;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Text;
using System.Threading.Tasks;

namespace CanIRise.Services.PersonMS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _service;
        private readonly IRabbitPro _rabbitPro;

        public PersonsController(IPersonService service, IRabbitPro rabbitPro)
        {
            _service = service;
            _rabbitPro = rabbitPro;
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
        public IActionResult Create([FromBody] PersonCreateDto dto)
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
        public IActionResult Update([FromBody] PersonUpdateDto dto)
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
        [HttpGet("[action]/{param}")]
        public async Task<IActionResult> ReportByLocation(string param)
        {
            //var factory = new ConnectionFactory { Uri = new Uri("amqp://guest:guest@localhost:5672") };
            //using var connection = factory.CreateConnection();
            //using var channel = connection.CreateModel();
            //channel.QueueDeclare("test-queue", durable: true, exclusive: false, autoDelete: false, arguments: null);
            //var message = new { Name = "Producer", Message = "Report Stuffs" };
            //var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));

            //channel.BasicPublish("", "test-queue", null, body);

            _rabbitPro.RabbitInit();
            return Ok( await _service.ReportByLocation(param));
        }
    }
}
