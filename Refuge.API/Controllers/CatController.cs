using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Refuge.API.DTO;
using Refuge.BLL.Enums;
using Refuge.BLL.Interfaces.Services;
using Refuge.DAL.Entities;

namespace BookingManager.API.Controllers
{
    [ApiController]
    [Route("api/Cat")]
    public class CatController(ICatService catService) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromQuery] char letter, [FromQuery] CatColor color)
        {
            return Ok(catService.SearchByLetterAndColor(letter, color));
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok();

        }

        [HttpPost]
        public IActionResult Post([FromBody]CatFormDTO dto)
        {
            catService.Add(new Cat { Name = dto.Name, Color = dto.Color });
            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody][MaxLength(25)] string name)
        {
            return Ok();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            return Ok();

        }
    }
}
