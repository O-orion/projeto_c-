using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            this._context = context;

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(Evento => Evento.EventoId == id);//retornando evento por ID
        }

        [HttpPost]
        public string Post()
        {
            return "JESUS CRISTO É O REI!";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"JESUS CRISTO É O MEU AMADO! : {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Te amo JESUS CRISTO DE NAZARE";
        }
    }
}
