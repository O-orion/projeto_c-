using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _eventos =  new Evento[] {
                new Evento() {
                    EventoId = 1,
                    Local = "Igreja de Jesus",
                    DataEvento = new DateTime(),
                    Tema = "JESUS CRISTO É PERFEITO!!",
                    QtdPessoas = 100000000,
                    Lote = 1,
                    ImagemURL = "wwww.google.com/jesusCristoEOSenhor"
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
        public IEnumerable<Evento> GetById(int id){
            return _eventos.Where(Evento => Evento.EventoId == id);//retornando evento por ID
        }

        [HttpPost]
        public string Post()
        {
            return "JESUS CRISTO É O REI!";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return  $"JESUS CRISTO É O MEU AMADO! : {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Te amo JESUS CRISTO DE NAZARE";
        }
    }
}
