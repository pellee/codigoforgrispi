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
        public bool Status { get; private set; } = true;
        public DateTime FechaInicioPro { get; set; }
        public DateTime FechaFinPro { get; set; }
        public int Vacantes { get; set; }
        public Empresa Empresa { get; set; }


        

        public void CambiarStatus()
        {
            if (Vacantes == 0)
                Status = false;
        }

        public void MostrarProyecto()
        {
            Console.WriteLine(NombrePro + "  " + ObjetivoPro + "  " + HorasPro + "  " + TipoPro + "  que pertenece a la empresa" + Empresa.NombreEmp);
        }
    }
}
