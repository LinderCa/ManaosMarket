using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;


namespace CapaNegocio
{
    public class clsMantenimiento
    {
        private clsConectaBD objConecta = new clsConectaBD();
        private SqlCommand cm = new SqlCommand();

        // Insert, update y delete
        public void ejecutarComando(string strConsulta)
        {
            try
            {
                objConecta.abrirconexion();
                cm.Connection = objConecta.miConexion;
                cm.CommandText = strConsulta;
                cm.ExecuteNonQuery(); // Ejecuta la consulta en la base de datos
                objConecta.cerrarconexion();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar la operación...");
            }
        }

        // select
        public DataTable listarComando(string strConsulta)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            try
            {
                objConecta.abrirconexion(); // No es necesario??
                da = new SqlDataAdapter(strConsulta, objConecta.miConexion);
                da.Fill(dt); // Llenar la tabla, ejecuta la consulta de selección
                objConecta.cerrarconexion();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al realizar la consulta...");
            }
            return null;
        }

        public DataSet listarComando(string strConsulta, DataSet ds)
        {
            // Dim ds As New DataSet
            SqlDataAdapter da;
            try
            {
                objConecta.abrirconexion(); // No es necesario??
                da = new SqlDataAdapter(strConsulta, objConecta.miConexion);
                da.Fill(ds, "tabla"); // Llenar la tabla, ejecuta la consulta de selección
                objConecta.cerrarconexion();
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al realizar la consulta...");
            }
            return null;
        }
    }

}



