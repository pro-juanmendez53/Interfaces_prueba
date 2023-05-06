using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_prueba.MisInterfaces
{
    internal interface IPersona
    {
        string Nombre { get; }

        int Edad { get; }

        void DecirMiNombre();

        void cumplirAños();



    }
}
