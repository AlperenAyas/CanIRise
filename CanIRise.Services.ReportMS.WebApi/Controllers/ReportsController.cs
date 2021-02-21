using CanIRise.Service.ReportMS.Business.Dtos.ReportDtos;
using CanIRise.Service.ReportMS.Business.Interfaces;
using CanIRise.Services.ReportMS.WebApi.RabbitMQ;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CanIRise.Services.ReportMS.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IHttpClientFactory _http;
        private readonly IReportService _service;
        private readonly IRabbit _rabbit;

        public ReportsController(IReportService service, IRabbit rabbit, IHttpClientFactory http)
        {
            _service = service;
            _rabbit = rabbit;
            _http = http;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var data = _service.Create(new ReportCreateDto());

            await _rabbit.RabbitInit();
            using var client = _http.CreateClient();
            client.BaseAddress = new Uri("http://localhost:50001");
            var response = await client.GetAsync("/api/Persons/ReportByLocation/adana");

            if (response.IsSuccessStatusCode)
            {
                _service.UpdateStatus(data.CreatingTime);
                return Ok(_service.GetAll());
            }
            else
            {
                return BadRequest();
            }
            
        }
        [HttpPost]
        public IActionResult Create(ReportCreateDto dto)
        {
            try
            {
                return Create(dto);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut]
        public IActionResult UpdateStatus(ReportUpdateDto dto)
        {
            try
            {
                //_service.UpdateStatus(dto);
                return NoContent();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
