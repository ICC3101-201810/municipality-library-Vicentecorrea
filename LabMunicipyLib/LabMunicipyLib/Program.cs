using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LabMunicipyLib
{
    class Program
    {
        static void Main(string[] args)
        {
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
