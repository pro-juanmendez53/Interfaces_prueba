using interfaces_prueba.MisInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_prueba.MisClases
{
    internal class Persona : IPersona
    {
      
        public string Nombre { get; }

        public int Edad { get;  }
        int i = 0;

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
           Edad = edad;
        }

        public void cumplirAños()
        {
            i++;
            Console.WriteLine("Tu edad es: " + (Edad + i));
            
        }

        public void DecirMiNombre()
        {
            Console.WriteLine("HOLA, Un gusto Saludar: " + Nombre);
        }
    }
}
