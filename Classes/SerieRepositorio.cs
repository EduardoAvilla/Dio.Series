using Banco.Serie;
using DIO.Series.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {

        private List<Serie> listaSerie = new List<Serie>();
        private int id;
        private Serie objeto;

        public void Atualiza(int id, Serie entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Exclui(int id)
        {

            listaSerie[id].Exclui();

        }

        public void Insere(Serie entidade)
        {

            listaSerie.Add(objeto);
        
        
        
        }

        public List<Serie> Lista()
        {
            throw new NotImplementedException();
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {

            return listaSerie[id];
        }
    }
}
