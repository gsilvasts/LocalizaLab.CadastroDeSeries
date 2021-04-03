using LocalizaLabSeries.Data;
using LocalizaLabSeries.Entities;
using LocalizaLabSeries.InputModels;
using LocalizaLabSeries.Interfaces;
using LocalizaLabSeries.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizaLabSeries.Repositorios
{
    public class SerieRepositorio
    {
        private readonly SeriesDbContext _dbContext;

        public SerieRepositorio(SeriesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Atualiza(int id, UpdateSerieInputModel entidade)
        {
            var serie = _dbContext.Series.SingleOrDefault(s => s.Id == id);
            
            if (serie == null)
            {
                return false;
            }
            else
            {
                serie.Atualizar(entidade.Titulo, entidade.Descricao, entidade.Ano, entidade.Genero);
                return true;
            }           

        }

        public bool Exclui(int id)
        {
            var serie = _dbContext.Series.SingleOrDefault(s => s.Id == id);

            if (serie == null)
            {
                return false;
            }
            else
            {
                serie.Excluir();
                return true;
            }                
        }

        public SerieDetailsViewModel GetById(int id)
        {
            var serie = _dbContext.Series.SingleOrDefault(s => s.Id == id);

            var serieDetailsViewModel = new SerieDetailsViewModel(
               serie.Id,
               serie.Titulo,
               serie.Descricao,
               serie.Ano,
               serie.Excluido,
               serie.Genero
               );
            return (serieDetailsViewModel);
        }

        public void Insere(AddSerieInputModel entidade)
        {
            var serie = new Serie(4, entidade.Titulo, entidade.Descricao, entidade.Ano, entidade.Excluido, entidade.Genero);
            _dbContext.Series.Add(serie);
                        
        }

        public List<SerieDetailsViewModel> Lista()
        {
            var serie = _dbContext.Series
                .Select(s => new SerieDetailsViewModel(s.Id, s.Titulo, s.Descricao, s.Ano, s.Excluido, s.Genero))
                .ToList();

            return (serie);
        }
    }
}
