using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class RNCarnet
    {
        private static readonly string CadenaConexion = "Data Source=LAPTOP-N19UNALS\\SQLEXPRESS;Initial Catalog=BDManaosMarket;Integrated Security=True";

        public clsCarnet LeerCarnet()
        {
            clsCarnet carnet = null;
            String sql = $@"SELECT CE.codCarnet,  CE.fechaEntrega, CE.vigente
	                        FROM CARNET_EMPLEADO CE";

            try
            {
                using (var conexion = new SqlConnection(RNCarnet.CadenaConexion))
                {
                    using (var comandos= new SqlCommand(sql, conexion))
                    {
                        conexion.Open();
                        using (var dr= comandos.ExecuteReader())
                        {
                            
                            if (dr.Read() == true)
                            {
                                carnet = new clsCarnet()
                                {
                                    Codigo=dr.GetInt32(dr.GetOrdinal("")),
                                    FechaEntrega = dr.GetDateTime(dr.GetOrdinal("")),
                                    Vigente = dr.GetBoolean(dr.GetOrdinal("")),
                                };
                            }
                            dr.Close();
                        }
                    }
                    conexion.Close();
                }
                return carnet;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Registrar(clsCarnet carnet)
        {
            String sql = $@"INSERT INTO CARNET_EMPLEADO(fechaEntrega,vigente)
	                        VALUES('2023-02-27',1)";

            try
            {
                using (var conexion = new SqlConnection(RNCarnet.CadenaConexion))
                {
                    using (var comandos= new SqlCommand(sql, conexion))
                    {
                        conexion.Open();
                        comandos.ExecuteNonQuery();
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
