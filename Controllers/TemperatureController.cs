using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEB_APIs_Problema_2._3.Interfaces;
using WEB_APIs_Problema_2._3.Models;
using WEB_APIs_Problema_2._3.Repository;

namespace WEB_APIs_Problema_2._3
{
    [ApiController]
    [Route("api/[controller]")]
    public class TemperatureController : ControllerBase
    {
        private IRegisterTempRepository registerTempRepository;
        public TemperatureController()
        {
            registerTempRepository = RegisterTempRepository.GetInstance();
        }
        [HttpGet]
        public ActionResult<List<RegisterTemp>> GetAll()
        {
            return Ok(registerTempRepository.GetAll());
        }

        [HttpGet("{IOT}")]
        public ActionResult<List<RegisterTemp>> GetById(int IOT)
        {
            return registerTempRepository.GetByIOT(IOT);
        }

        [HttpPost]
        public IActionResult CreateTemp([FromBody] RegisterTemp temp)
        {
            // Console.WriteLine($"debug => {temp}");
            bool wasCreated = registerTempRepository.CreateTemp(temp);

            if (wasCreated)
            {
                return Ok("Temperature created successfully");
            }
            return BadRequest();
        }

    }
}