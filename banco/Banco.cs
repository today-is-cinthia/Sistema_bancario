using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    static class Banco
    {
        public static List<string> nombres = new List<string>();
        public static List<string> sevicios = new List<string>();

        public static void Encolar(string nombre, string servicio)
        {
            nombres.Add(nombre);
            sevicios.Add(servicio);
        }

        public static string Desencolarnom()
        {
            string nom = nombres[0];
            nombres.RemoveAt(0);

            return (Convert.ToString(nom));
        }
        public static string Desencolarser()
        {
            string ser = sevicios[0];
            sevicios.RemoveAt(0);

            return (Convert.ToString(ser));
        }

    }
}
