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




        public Empresa VerificarEmpresa(string cuil, List<Empresa> empresas)
        {
            if (empresas.Count == 0)
                return null;

            foreach (var item in empresas) {

                if (item.CuilEmp == cuil)
                    return item;
            }

            return null;
        }

    }
}
