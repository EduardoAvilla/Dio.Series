using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Series.Interface
{
   public interface IRepositorio<T>
    {

        List<T> Lista();
        T RetornaPorId(int id);

        void Insere(T entidade);

        void Exclui(int idade);

        void Atualiza(int id, T entidade);

        int ProximoId();
        
    }
}
