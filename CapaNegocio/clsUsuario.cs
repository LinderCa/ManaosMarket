using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsUsuario
    {

        /*
        //Instanciamos un objeto mantenimiento
        clsMantenimiento mantenimiento = new clsMantenimiento();
        String sql;
        DataTable dt = new DataTable();
        */
        public int CodigoUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string NombresCompletos { get; set; }
    }
}
