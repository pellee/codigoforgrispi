using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasantia
{
    class Proyecto
    {
        public int Id { get; set; }
        public string NombrePro { get; set; }
        public string ObjetivoPro { get; set; }
        public string TipoPro { get; set; }
        public string HorasPro { get; set; }
        public bool Status { get; set; } = true;
        public DateTime FechaInicioPro { get; set; }
        public DateTime FechaFinPro { get; set; }
        public int Vacantes { get; set; }
        public Empresa Empresa { get; set; }




        public Proyecto VerificarProyect(string nombre, List<Proyecto> proyectos)
        {
            foreach (var item in proyectos) {

                if (item.NombrePro == nombre)
                    return item;
            }

            return null;
        }


    }
}
