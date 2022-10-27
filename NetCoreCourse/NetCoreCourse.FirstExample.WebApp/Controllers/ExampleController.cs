using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using NetCoreCourse.FirstExample.WebApp.Configuration;

namespace NetCoreCourse.FirstExample.WebApp.Controllers
{
    
    [Route("api/[controller]")] //Este decorador permite que el Middleware UseRouting pueda encontrar este endpoint.
    //Mira! Estamos heredando de ControllerBase
    public class ExampleController : ControllerBase
    {
        private readonly AnotherConfigurationOptions anotherConfiguration;

        public ExampleController(IOptions<AnotherConfigurationOptions> options)

        {
            anotherConfiguration = options?.Value ?? throw new ArgumentNullException("AnotherConfigurationOptions was not properly set.");
        }

        [HttpGet]
        public IActionResult Hey()
        {
            return Ok("Hola Dev!.");
        }

        [HttpGet("another")]
        public IActionResult AnotherHey()
        {
            return Ok(anotherConfiguration);
        }
    }
}