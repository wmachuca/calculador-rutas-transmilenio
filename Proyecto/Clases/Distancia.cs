using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Clases
{
    class Distancia
    {
        int padre;
        int valor;

        public void setPadre(int padre)
        {
            this.padre = padre;
        }

        public int getPadre()
        {
            return this.padre;
        }

        public void setValor(int valor)
        {
            this.valor = valor;
        }

        public int getValor()
        {
            return this.valor;
        }
    }
}
