using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    class Banco
    {
        public List<string> nombres;
        public List<string> sevicios;

        public Banco()
        {
            nombres = new List<string>();
            sevicios = new List<string>();
        }

        public void Encolar(string nombre, string servicio)
        {
            nombres.Add(nombre);
            sevicios.Add(servicio);
        }


    }
}
