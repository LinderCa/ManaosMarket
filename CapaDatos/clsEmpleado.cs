using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class clsEmpleado
    {
        public int CodigoSistema { get; set; }
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string ApellPaterno { get; set; }
        public string ApellMaterno { get; set; }
        public string DNI { get; set; }
        public string Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public bool Vigencia { get; set; }
        public clsArea Area { get; set; }
        public clsEncargatura Encargatura { get; set; }
        public clsCarnet Carnet { get; set; }
        public string NombreEncargatura {
            get
            {
                return Encargatura.Nombre;
            }
        }

        public string NombresCompletos
        {
            get
            {
                return Nombres + " " + ApellPaterno;
            }
        }


    }
}
