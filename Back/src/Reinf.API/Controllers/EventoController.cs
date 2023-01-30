using Microsoft.AspNetCore.Mvc;

namespace Reinf.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public EventoController()
    {

    }
    
    [HttpGet]
    public string Get()
    {
        return "value";
    }

        [HttpPost]
    public string Post()
    {
        return "Post";
    }
}
