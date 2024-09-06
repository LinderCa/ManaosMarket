using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class RNEncargatura
    {
        private static readonly string CadenaConexion = "Data Source=LAPTOP-N19UNALS\\SQLEXPRESS;Initial Catalog=BDManaosMarket;Integrated Security=True";

        public List<clsEncargatura> ListarVigentes()
        {
            List<clsEncargatura> encargaturas = null;
            String sql = $@"SELECT EN.codEncargatura, EN.nombre
	                        FROM ENCARGATURA EN
	                        WHERE EN.disponibilidad=1";

            try
            {
                using (var conexion = new SqlConnection(RNEncargatura.CadenaConexion))
                {
                    using(var comandos= new SqlCommand(sql, conexion))
                    {
                        conexion.Open();
                        using (var dr= comandos.ExecuteReader())
                        {
                            encargaturas = new List<clsEncargatura>();
                            while (dr.Read() == true)
                            {
                                encargaturas.Add(new clsEncargatura()
                                {
                                    Codigo=dr.GetInt32(dr.GetOrdinal("codEncargatura")),
                                    Nombre=dr.GetString(dr.GetOrdinal("nombre")),
                                });
                            }
                            dr.Close();
                        }
                        conexion.Close();
                    }
                }
            }catch(Exception ex)
            {
                throw ex;
            }
            return encargaturas;
        }
    }
}
