using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class RNUsuario
    {
        private static readonly string CadenaConexion = "Data Source=LAPTOP-N19UNALS\\SQLEXPRESS;Initial Catalog=BDManaosMarket;Integrated Security=True";
        public bool Verificar(string usuario, string contrasena)
        {

            String sql = $@"SELECT NombresCompletos
                             FROM USUARIO
                              WHERE NUsuario = '{usuario}' AND Contraseña = '{contrasena}'";
            try
            {
                using (var conexion= new SqlConnection(RNUsuario.CadenaConexion))
                {
                    using (var comandos= new SqlCommand(sql, conexion))
                    {
                        conexion.Open();
                        using (var dr= comandos.ExecuteReader())
                        {
                            if (dr.Read() == true)
                            {
                                return true;
                            }
                            else
                            {
                                return false;
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
        }
    }
}
