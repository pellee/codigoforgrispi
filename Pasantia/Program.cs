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
            int i;
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

                i = aux.VerificarEmpresa(cuil, empresas);

                if (i == -1)
                    Console.WriteLine("No se encontro la empresa");
                else
                    proyecto.Empresa = empresas[i];
            } while (proyecto.Empresa == null);
            

            return proyecto;
        }

        static Alumno CrearAlumno()
        {
            Alumno alumno = new Alumno();
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

            alumno.Proyecto = null;

            return alumno;
        }

        static void Menu()
        {
            char opc;

            do {
                Console.WriteLine("1>Crear Empresa\n2>Crear Alumno\n3>Crear Proyecto");
                opc = char.Parse(Console.ReadLine());

                if (opc == '1')
                    empresas.Add(CrearEmpresa());

                if (opc == '2')
                    alumnos.Add(CrearAlumno());

                if (opc == '3' && empresas.Count == 0)
                    Console.WriteLine("1ro debe haber una empresa creada");
                else if (opc == '3' && empresas.Count != 0)
                    proyectos.Add(CrearProyecto());

                Console.WriteLine("Desea Continuar con el menu? S/N");
                opc = char.Parse(Console.ReadLine());

                opc = char.ToUpper(opc);
            } while (opc != 'N');
        }

        static void Mostrar()
        {
            Console.WriteLine("Los alumnos son: ");

            foreach (var item in alumnos)
                item.MostrarAlumnos();

            Console.WriteLine("Los proyectos son: ");

            foreach (var item in proyectos)
                item.MostrarProyecto();

            Console.WriteLine("Las empresas son: ");

            foreach (var item in empresas)
                item.MostrarEmpresa();
        }

        static void Main(string[] args)
        {
            Alumno aux = new Alumno();

            Menu();

            aux.OrdenarAlumnosPorProm(alumnos);
            aux.AsignarAlumnosEnProyectos(alumnos, proyectos);

            Mostrar();
        }
    }
}