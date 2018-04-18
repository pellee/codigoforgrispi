using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasantia
{
    class Alumno
    {
        public string Dni { get; set; }
        public string NombreAlu { get; set; }
        public string ApellidoAlu { get; set; }
        public float PromAlu { get; set; }
        public List<string> Preferencias { get; set; } = new List<string>();
        public Proyecto Proyecto { get; set; }




        public void OrdenarAlumnosPorProm(List<Alumno> alumnos)
        {
            for (int i = 0; i < alumnos.Count - 1; i++)
            {
                for (int j = i; j < alumnos.Count; j++)
                {
                    if (alumnos[i].PromAlu > alumnos[j].PromAlu) {
                        Alumno aux = alumnos[i];
                        alumnos[i] = alumnos[j];
                        alumnos[j] = aux;
                    }
                }
            }
        }

    }
}
