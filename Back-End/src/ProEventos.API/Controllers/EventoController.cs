using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
   IEnumerable<Evento> _eventos =  new Evento[] {
         new Evento(){
         EventoId = 1,
         Tema = "Barbie",
         QtdePessoas = 29,
         Lote = "01",
         Local = "Rio de Janeiro",
         DataEvento = DateTime.Now.AddDays(22).ToString(),
         ImagemUrl = "foto1.png"
         },
         new Evento(){
         EventoId = 2,
         Tema = "Barbie2",
         QtdePessoas = 29,
         Lote = "01",
         Local = "Rio de Janeiro",
         DataEvento = DateTime.Now.AddDays(22222).ToString(),
          ImagemUrl = "foto3.png"
         }
       };
    public EventoController()
    {

    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
       return _eventos;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
       return _eventos.Where(e=>e.EventoId == id);
    }

     [HttpPost]
    public string Post()
    {
       return "oi post";
    }
}
