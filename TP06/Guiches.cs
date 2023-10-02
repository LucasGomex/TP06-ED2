using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lucas Gomes e Miguel Pataro
namespace TP06
{
    class Guiches
    {
        private List<Guiche> listaGuiches;

        public Guiches()
        {
            listaGuiches = new List<Guiche>();
        }

        public List<Guiche> ListaGuiches => listaGuiches;

        public void Adicionar(Guiche guiche)
        {
            listaGuiches.Add(guiche);
        }

        public Guiche Buscar(int id)
        {
            foreach (Guiche guiche in listaGuiches)
            {
                if (guiche.Id == id)
                {
                    return guiche;
                }
            }
            return null;
        }
    }
}
