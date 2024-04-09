using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class Usuarios
    {
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int Edad {  get; set; }
        public string DNI { get; set; }

        public Usuarios() { }
        public Usuarios(string dni)
        {
            DNI = dni;
        }
    }
}
