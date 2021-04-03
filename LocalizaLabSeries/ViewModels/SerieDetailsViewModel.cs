using LocalizaLabSeries.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizaLabSeries.ViewModels
{
    public class SerieDetailsViewModel
    {
        public SerieDetailsViewModel(string titulo, string descricao, int ano, bool excluido, GeneroEnum genero)
        {            
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = excluido;
            Genero = genero;
        }

        public SerieDetailsViewModel(int id, string titulo, string descricao, int ano, bool excluido, GeneroEnum genero)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = excluido;
            Genero = genero;
        }

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public bool Excluido { get; set; }
        public GeneroEnum Genero { get; set; }
    }
}
