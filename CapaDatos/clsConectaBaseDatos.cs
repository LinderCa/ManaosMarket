using System;
using Microsoft.VisualBasic;
using System.Data; // ADO Net 
using System.Data.SqlClient;


namespace CapaDatos
{

    public class clsConectaBD
    {
        private SqlConnection cn;

        public clsConectaBD()
        {
            cn = new SqlConnection();  // Objeto de conexión a BD

            // Autenticación Windows
            //cn.ConnectionString = @"data source=(LAPTOP-N19UNALS\SQLEXPRESS);Initial catalog=ManaosMarket;integrated security=SSPI;language=spanish";
            cn.ConnectionString = @"Data Source=LAPTOP-N19UNALS\\SQLEXPRESS;Initial Catalog=ManaosMarket;Integrated Security=True";
        }

        public void conectar()
        {
            try
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
            }
            catch (Exception ex)
            {
            }
        }

        public void desconectar()
        {
            try
            {
                if (cn.State != ConnectionState.Closed)
                    cn.Close();
            }
            catch (Exception ex)
            {
            }
        }

        public string estadoCN
        {
            get
            {
                if (cn.State == ConnectionState.Open)
                    return "BD está abierta.";
                else
                    return "BD está cerrada.";
            }
        }

        public SqlConnection miConexion
        {
            get
            {
                return cn;
            }
        }

        public string Servidor
        {
            get
            {
                return cn.DataSource.ToString();
            }
        }

        public void abrirconexion()
        {
            try
            {
                if (cn.State != ConnectionState.Open)
                    cn.Open();
            }
            catch (Exception Ex)
            {
                throw (Ex);
                //Information.Err.Raise(Information.Err.Number, Information.Err.Source, Information.Err.Description);
            }
        }

        public void cerrarconexion()
        {
            try
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            catch (Exception Ex)
            {
                throw (Ex);
              //  Information.Err.Raise(Information.Err.Number, Information.Err.Source, Information.Err.Description);
            }
        }
    }
}