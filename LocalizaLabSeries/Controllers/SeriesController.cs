using LocalizaLabSeries.Data;
using LocalizaLabSeries.Entities;
using LocalizaLabSeries.InputModels;
using LocalizaLabSeries.Repositorios;
using LocalizaLabSeries.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizaLabSeries.Controllers
{
    [Route("api/[Controller]")]
    public class SeriesController : ControllerBase
    {        
        private readonly SerieRepositorio _serieRepositorio;

        public SeriesController(SerieRepositorio serieRepositorio)
        {
            _serieRepositorio = serieRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var serie = _serieRepositorio.Lista();
                        
            return Ok(serie);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var serie = _serieRepositorio.GetById(id);

            if (serie == null)
            {
                return NotFound();
            }

           
            return Ok(serie);
        }

        [HttpPost]
        public IActionResult Post([FromBody] AddSerieInputModel entidade)
        {
            _serieRepositorio.Insere(entidade);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateSerieInputModel entidade)
        {
            var serie = _serieRepositorio.Atualiza(id, entidade);

            if (serie == false)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var serie = _serieRepositorio.Exclui(id);

            if(serie == false)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
