using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizaLabSeries.Entities
{
    public class Serie : EntidadeBase
    {
        public Serie(int id, string titulo, string descricao, int ano, bool excluido, GeneroEnum genero)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = excluido;
            Genero = genero;
        }

        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public int Ano { get; private set; }
        public bool Excluido { get; private set; }
        public GeneroEnum Genero { get; private set; }


        public void Excluir()
        {
            Excluido = true;
        }

        public void Atualizar(string titulo, string descricao, int ano, GeneroEnum genero)
        {           
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;            
            Genero = genero;
        }
    }
}
