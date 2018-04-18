using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasantia
{
    class Program
    {
        static List<Proyecto> proyectos = new List<Proyecto>();
        static List<Empresa> empresas = new List<Empresa>();
        static List<Alumno> alumnos = new List<Alumno>();

        static Empresa CrearEmpresa()
        {
            Empresa empresa = new Empresa();

            Console.Write("ingrese nombre empresa: ");
            empresa.NombreEmp = Console.ReadLine();
            Console.Write("ingrese direccion empresa: ");
            empresa.DireccionEmp = Console.ReadLine();
            Console.Write("ingrese cuil empresa: ");
            empresa.CuilEmp = Console.ReadLine();

            return empresa;
        }

        static Proyecto CrearProyecto()
        {
            Proyecto proyecto = new Proyecto();
            Empresa aux = new Empresa();
            string cuil;

            proyecto.Id = proyectos.Count + 1;

            Console.WriteLine("Ingrese nombre proyecto: ");
            proyecto.NombrePro = Console.ReadLine();
            Console.WriteLine("Ingrese objetivo proyecto: ");
            proyecto.ObjetivoPro = Console.ReadLine();
            Console.WriteLine("Ingrese tipo proyecto: ");
            proyecto.TipoPro = Console.ReadLine();
            Console.WriteLine("Ingrese horas proyecto: ");
            proyecto.HorasPro = Console.ReadLine();
            Console.WriteLine("Ingrese fecha de inicio proyecto en formato DD/MM/AAAA: ");
            proyecto.FechaInicioPro = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese fecha de finalizacion proyecto en formato DD/MM/AAAA: ");
            proyecto.FechaFinPro = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese vacantes proyecto: ");
            proyecto.Vacantes = int.Parse(Console.ReadLine());

            do {
                Console.WriteLine("Ingrese cuil de la empresa a la que pertenece el proyecto: ");
                cuil = Console.ReadLine();

                if (aux.VerificarEmpresa(cuil, empresas) == null)
                    Console.WriteLine("La empresa no existe");
                else
                    proyecto.Empresa = aux.VerificarEmpresa(cuil, empresas);
            } while (proyecto.Empresa == null);
            

            return proyecto;
        }

        static Alumno CrearAlumno()
        {
            Alumno alumno = new Alumno();
            Proyecto aux = new Proyecto();
            string nombre;
            char opc;

            Console.WriteLine("Ingrese dni");
            alumno.Dni = Console.ReadLine();
            Console.WriteLine("Ingrese apellido");
            alumno.ApellidoAlu = Console.ReadLine();
            Console.WriteLine("Ingrese nombre");
            alumno.NombreAlu = Console.ReadLine();
            Console.WriteLine("Ingrese prom");
            alumno.PromAlu = float.Parse(Console.ReadLine());

            do {
                Console.WriteLine("Ingrese preferencia");
                alumno.Preferencias.Add(Console.ReadLine());

                Console.WriteLine("Desea ingresar mas preferencias? S/N");
                opc = char.Parse(Console.ReadLine());

                opc = char.ToUpper(opc);
            } while (opc != 'N');

            

            do {
                Console.WriteLine("Ingrese nombre proyecto al que pertenece este alumno");
                nombre = Console.ReadLine();

                if (aux.VerificarProyect(nombre, proyectos) == null)
                    Console.WriteLine("La empresa no existe");
                else
                    alumno.Proyecto = aux.VerificarProyect(nombre, proyectos);
            } while (alumno.Proyecto == null);

            return alumno;
        }


        static void Main(string[] args)
        {

        }
    }
}
