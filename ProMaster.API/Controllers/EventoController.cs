using System.Diagnostics.Tracing;
using Microsoft.AspNetCore.Mvc;
using ProMaster.API.Models;

namespace ProMaster.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
        { new Evento()
            {
                EventoId = 1,
                Local = "Recife",
                DataEvento = DateTime.Now.AddDays(3).ToString("yy-MM-dd"),
                Tema = "Angular 11",
                QtdPessoas = 400,
                Lote = "2º Lote",
                ImgURL = "FotoLocal.jpg"
            },
            new Evento()
            {
                EventoId = 2,
                Local = "Pernambuco",
                DataEvento = DateTime.Now.AddDays(3).ToString("yy-MM-dd"),
                Tema = "Angular 11",
                QtdPessoas = 100,
                Lote = "1º Lote",
                ImgURL = "FotoLocal.jpg"
            },
            new Evento()
            {
                EventoId = 3,
                Local = "Caruaru",
                DataEvento = DateTime.Now.AddDays(1).ToString("yy-MM-dd"),
                Tema = "Angular 11",
                QtdPessoas = 200,
                Lote = "5º Lote",
                ImgURL = "FotoLocal.jpg"
            }

        };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetByID(int id)
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
