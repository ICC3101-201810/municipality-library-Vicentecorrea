using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using ClassLibrary1;

namespace LabMunicipyLib
{
    class Program
    {
        public static int ChequearOpcion(int inicio, int fin)
        {
            int NumerodeComparacion = 0;
            EmpiezaDeNuevo:
            string strOpcion = Console.ReadLine();
            while (!Char.IsNumber(strOpcion, NumerodeComparacion))
            {
                Console.Write("Ingrese una opcion valida: ");
                strOpcion = Console.ReadLine();
            }

            int opcion = Convert.ToInt32(strOpcion);
            if (opcion > fin || opcion < inicio)
            {
                Console.Write("Ingrese una opcion valida: ");
                goto EmpiezaDeNuevo;
            }
            else return opcion;
        }

        static void Main(string[] args)
        {

            // PREGUNTA 2

            Person p0 = new Person("Pepe", "Fernandez", new DateTime(1995, 08, 03), null, "18.123.456-7", null, null);


            Console.WriteLine("¿Que quieres inscribir? (elige el numero de la opcion)\n" +
                "1. una persona\n" +
                "2. una propiedad\n" +
                "3. un auto\n");
            int opcion = ChequearOpcion(1, 3);
            if (opcion == 1)
            {
                Console.WriteLine("Vamos a inscribir una persona!");
                Person p1 = new Person("Juan", "Perez", new DateTime(1995, 08, 03), null, "18.123.456-7", null, null);
            }
            if (opcion == 2)
            {
                Console.WriteLine("Vamos a inscribir una propiedad!");
                Address a1 = new Address("Apoquindo", 945, "Las Condes", "Santiago", p0, 2004, 3, 2, true, false);
            }
            if (opcion == 3)
            {
                Console.WriteLine("Vamos a inscribir un auto!");
                Car c1 = new Car("Toyota", "X730", 1997, p0, "AB3709", 4, false);
            }



            //  PREGUNTA 1

            Assembly archivoSem = Assembly.LoadFile("C:/Users/vicen/source/repos/municipality-library-Vicentecorrea/LabMunicipyLib/LabMunicipyLib/ClassLibrary1.dll");
            foreach (Type tipo in archivoSem.GetTypes())
            {
                if (tipo.IsClass)
                {
                    //Console.WriteLine("es clase");
                }
                //else if (tipo.IsInterface) Console.WriteLine("es interface");
                //else Console.WriteLine("otro tipo");
                //Console.WriteLine(tipo.Name);
                MethodInfo[] propiedades = tipo.GetMethods();
                PropertyInfo[] atributos = tipo.GetProperties();
                
                //Console.WriteLine("METODOS: ");
                foreach (MethodInfo p in propiedades)
                {
                    //Console.WriteLine("\tNombre: " + p.Name + "\n ---> \tTipo de return: " + p.ReturnType);
                    ParameterInfo[] parametros = p.GetParameters();
                    //Console.WriteLine("  PARAMETROS: ");
                    foreach (ParameterInfo par in parametros)
                    {
                        //Console.WriteLine("\t  par: " + par);
                    }
                }
                Console.WriteLine();
                //Console.WriteLine("ATRIBUTOS: ");
                foreach (PropertyInfo at in atributos)
                {
                    //Console.WriteLine("\tNombre: " + at.Name + "\n ---> \tTipo: " + at.PropertyType);
                }
            }
            Console.ReadKey();
        }
        
    }
}
