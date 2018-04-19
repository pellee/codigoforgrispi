using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasantia
{
    class Empresa
    {
        public string NombreEmp { get; set; }
        public string DireccionEmp { get; set; }
        public string CuilEmp { get; set; }




        public int VerificarEmpresa(string cuil, List<Empresa> empresas)
        {
            if(empresas.Count == 0)
                return -1;

            for (int i = 0; i < empresas.Count; i++)
            {
                if (cuil == empresas[i].CuilEmp)
                    return i;
            }

            return -1;
        }

        public void MostrarEmpresa()
        {
            Console.WriteLine(NombreEmp + "  " + DireccionEmp + "\n");
        }

    }
}
