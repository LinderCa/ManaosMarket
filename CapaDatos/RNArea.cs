using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class RNArea
    {
        private static readonly string CadenaConexion = "Data Source=LAPTOP-N19UNALS\\SQLEXPRESS;Initial Catalog=BDManaosMarket;Integrated Security=True";
        public List<clsArea> ListarAreasVigentes()
        {
            List<clsArea> areasVigentes = null;
            String sql = $@"SELECT A.codArea, A.nombre
	                        FROM AREA A
	                        WHERE A.vigencia=1";
            try
            {
                using (var conexion= new SqlConnection(RNArea.CadenaConexion))
                {
                    using (var comandos= new SqlCommand(sql, conexion))
                    {
                        conexion.Open();
                        using (var dr= comandos.ExecuteReader())
                        {
                            areasVigentes = new List<clsArea>();
                            while (dr.Read() == true)
                            {
                                areasVigentes.Add(new clsArea()
                                {
                                    Codigo=dr.GetInt32(dr.GetOrdinal("codArea")),
                                    Nombre = dr.GetString(dr.GetOrdinal("nombre")),
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
            return areasVigentes;
        } 
    }
}
