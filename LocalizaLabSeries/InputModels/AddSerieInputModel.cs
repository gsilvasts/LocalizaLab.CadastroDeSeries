using LocalizaLabSeries.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizaLabSeries.InputModels
{
    public class AddSerieInputModel
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public bool Excluido { get; set; }
        public GeneroEnum Genero { get; set; }
    }
}
