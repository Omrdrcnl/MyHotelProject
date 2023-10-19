using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult serviceList()
        {
            var values = _serviceService.TGetList();
            return Ok(values);
        }

        [HttpGet("id")]
        public IActionResult GetService(int id)
        {
            var v = _serviceService.TGetById(id);

            return Ok(v);
        }

        [HttpPost]
        public IActionResult Addservice(Service service)
        {
            _serviceService.TInsert(service);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteService(int id)
        {
            var v = _serviceService.TGetById(id);
            _serviceService.TDelete(v);
            return Ok();
        }
    }
}
