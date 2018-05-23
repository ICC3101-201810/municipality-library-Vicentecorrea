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
        static void Main(string[] args)
        {

            // PREGUNTA 2

            Person p1 = new Person("Juan", "Perez", new DateTime(1995, 08, 03), null, "18.123.456-7", null, null);
            Address a1 = new Address("Apoquindo", 945, "Las Condes", "Santiago", p1, 2004, 3, 2, true, false);
            Car c1 = new Car("Toyota", "X730", 1997, p1, "AB3709", 4, false);





            //  PREGUNTA 1

            Assembly archivoSem = Assembly.LoadFile("C:/Users/vicen/source/repos/municipality-library-Vicentecorrea/LabMunicipyLib/LabMunicipyLib/ClassLibrary1.dll");
            foreach (Type tipo in archivoSem.GetTypes())
            {
                if (tipo.IsClass)
                {
                    //Console.WriteLine("Atributos: " + tipo.Attributes + ", tipo: " +  + "\n");
                    Console.WriteLine("es clase");
                }
                else if (tipo.IsInterface) Console.WriteLine("es interface");
                else Console.WriteLine("otro tipo");
                Console.WriteLine(tipo.Name);
                MethodInfo[] propiedades = tipo.GetMethods();
                PropertyInfo[] atributos = tipo.GetProperties();
                
                Console.WriteLine("METODOS: ");
                foreach (MethodInfo p in propiedades)
                {
                    Console.WriteLine("\tNombre: " + p.Name + "\n ---> \tTipo de return: " + p.ReturnType);
                    ParameterInfo[] parametros = p.GetParameters();
                    //Console.WriteLine("  PARAMETROS: ");
                    foreach (ParameterInfo par in parametros)
                    {
                        Console.WriteLine("\t  par: " + par);
                    }
                }
                Console.WriteLine();
                Console.WriteLine("ATRIBUTOS: ");
                foreach (PropertyInfo at in atributos)
                {
                    Console.WriteLine("\tNombre: " + at.Name + "\n ---> \tTipo: " + at.PropertyType);
                }
            }
            Console.ReadKey();
        }
        
    }
}
