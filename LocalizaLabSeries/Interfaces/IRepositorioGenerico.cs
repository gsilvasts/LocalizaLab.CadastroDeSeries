using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizaLabSeries.Interfaces
{
    public interface IRepositorioGenerico<T>
    {
        List<T> Lista();
        T GetById(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);      
    }
}
