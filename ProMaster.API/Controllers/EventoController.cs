using System.Diagnostics.Tracing;
using Microsoft.AspNetCore.Mvc;
using ProMaster.API.Models;

namespace ProMaster.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Eventos> _evento = new Eventos[]
        { new Eventos()
            {
                EventoId = 1,
                Local = "Recife",
                DataEvento = DateTime.Now.AddDays(3).ToString("yy-MM-dd"),
                Tema = "Angular 11",
                QtdPessoas = 400,
                Lote = "2� Lote",
                ImgURL = "FotoLocal.jpg"
            },
            new Eventos()
            {
                EventoId = 2,
                Local = "Pernambuco",
                DataEvento = DateTime.Now.AddDays(3).ToString("yy-MM-dd"),
                Tema = "Angular 11",
                QtdPessoas = 100,
                Lote = "1� Lote",
                ImgURL = "FotoLocal.jpg"
            },
            new Eventos()
            {
                EventoId = 3,
                Local = "Caruaru",
                DataEvento = DateTime.Now.AddDays(1).ToString("yy-MM-dd"),
                Tema = "Angular 11",
                QtdPessoas = 200,
                Lote = "5� Lote",
                ImgURL = "FotoLocal.jpg"
            }

        };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Eventos> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Eventos> GetByID(int id)
        {
            return _evento.Where(evento => evento.EventoId  == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

    }
}
