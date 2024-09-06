using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class RNEmpleado
    {
        private static readonly string CadenaConexion = "Data Source=LAPTOP-N19UNALS\\SQLEXPRESS;Initial Catalog=BDManaosMarket;Integrated Security=True";

        public void Registrar(clsEmpleado empleado)
        {
            clsEmpleado nuevo = null;
            String sql = $@"INSERT INTO EMPLEADO(nombres,apellPaterno,apellMaterno,
                                                fechaNacimiento,correo,telefono,genero,
                                                DNI,direccion,vigente,codEmpleado,codArea,
                                                codEncargatura,codCarnet)
	                        VALUES('{empleado.Nombres}','{empleado.ApellPaterno}','{empleado.ApellMaterno}',
                                    '2001-11-24','{empleado.Correo}',
                                     '{empleado.Telefono}','{empleado.Genero}','{empleado.DNI}','{empleado.Direccion}',1,
                                    '{empleado.Codigo}',{empleado.Area.Codigo},{empleado.Encargatura.Codigo},{empleado.Carnet.Codigo})";

            try
            {
                using (var conexion= new SqlConnection(RNEmpleado.CadenaConexion))
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

        public List<clsEmpleado> Listar()
        {
            List<clsEmpleado> empleados = null;
            String sql = $@"SELECT E.codSistema, E.nombres, E.ApellPaterno, EN.nombre, E.vigente
	                        FROM EMPLEADO E JOIN ENCARGATURA EN ON E.codEncargatura= EN.codEncargatura";
            try
            {
                using (var conexion= new SqlConnection(RNEmpleado.CadenaConexion))
                {
                    using (var comandos= new SqlCommand(sql, conexion))
                    {
                        conexion.Open();
                        using (var dr= comandos.ExecuteReader())
                        {
                            empleados = new List<clsEmpleado>();
                            while (dr.Read() == true)
                            {
                                empleados.Add(new clsEmpleado()
                                {
                                    CodigoSistema=dr.GetInt32(dr.GetOrdinal("codSistema")),
                                    Nombres = dr.GetString(dr.GetOrdinal("nombres")),
                                    ApellPaterno=dr.GetString(dr.GetOrdinal("ApellPaterno")),
                                    Encargatura = new clsEncargatura()
                                    {
                                        Nombre = dr.GetString(dr.GetOrdinal("nombre"))
                                    },
                                    Vigencia=dr.GetBoolean(dr.GetOrdinal("vigente")),
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
            return empleados;
        }
   
        public List<clsEmpleado> ListarEmpleados(string codigo)
        {
            List<clsEmpleado> empleados = null;

            String sql = $@"SELECT E.codSistema, E.nombres, E.ApellPaterno, EN.nombre, E.vigente
	                    FROM EMPLEADO E JOIN ENCARGATURA EN ON E.codEncargatura= EN.codEncargatura
	                    WHERE E.codEmpleado LIKE '{codigo}%'";

            try
            {
                using (var conexion = new SqlConnection(RNEmpleado.CadenaConexion))
                {
                    using (var comandos = new SqlCommand(sql, conexion))
                    {
                        conexion.Open();
                        using (var dr = comandos.ExecuteReader())
                        {
                            empleados = new List<clsEmpleado>();
                            while (dr.Read() == true)
                            {
                                empleados.Add(new clsEmpleado()
                                {
                                    CodigoSistema = dr.GetInt32(dr.GetOrdinal("codSistema")),
                                    Nombres = dr.GetString(dr.GetOrdinal("nombres")),
                                    ApellPaterno = dr.GetString(dr.GetOrdinal("ApellPaterno")),
                                    Encargatura = new clsEncargatura()
                                    {
                                        Nombre = dr.GetString(dr.GetOrdinal("nombre"))
                                    },
                                    Vigencia = dr.GetBoolean(dr.GetOrdinal("vigente")),
                                });
                            }
                            dr.Close();
                        }
                        conexion.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return empleados;
        }

        public clsEmpleado Leer(int codigo)
        {
            clsEmpleado empleado = null;
            string sql = $@"SELECT E.nombres, E.apellPaterno, E.apellMaterno, E.codSistema,
                                    E.fechaNacimiento,E.correo,E.telefono, E.genero,E.DNI,E.direccion,
                                    E.vigente,E.codEmpleado,E.codArea,E.codEncargatura,E.codCarnet
	                    FROM EMPLEADO E
	                    WHERE E.codSistema={codigo}";

            try
            {
                using (var conexion = new SqlConnection(RNEmpleado.CadenaConexion))
                {
                    using (var comandos = new SqlCommand(sql, conexion))
                    {
                        conexion.Open();
                        using (var dr = comandos.ExecuteReader())
                        {
                            if (dr.Read() == true)
                            {
                                empleado = new clsEmpleado()
                                {
                                    Nombres = dr.GetString(dr.GetOrdinal("nombres")),
                                    ApellPaterno = dr.GetString(dr.GetOrdinal("apellPaterno")),
                                    ApellMaterno = dr.GetString(dr.GetOrdinal("apellMaterno")),
                                    CodigoSistema = codigo,
                                    FechaNacimiento = dr.GetDateTime(dr.GetOrdinal("fechaNacimiento")),
                                    Correo = dr.GetString(dr.GetOrdinal("correo")),
                                    Telefono=dr.GetString(dr.GetOrdinal("telefono")),
                                    Genero = dr.GetString(dr.GetOrdinal("genero")),
                                    DNI = dr.GetString(dr.GetOrdinal("DNI")),
                                    Direccion = dr.GetString(dr.GetOrdinal("direccion")),
                                    Vigencia = dr.GetBoolean(dr.GetOrdinal("vigente")),
                                    Codigo = dr.GetString(dr.GetOrdinal("codEmpleado")),
                                    Area = new clsArea()
                                    {
                                        Codigo = dr.GetInt32(dr.GetOrdinal("codArea")),
                                    },
                                    Encargatura = new clsEncargatura()
                                    {
                                        Codigo = dr.GetInt32(dr.GetOrdinal("codEncargatura"))
                                    },
                                    Carnet = new clsCarnet()
                                    {
                                        Codigo = dr.GetInt32(dr.GetOrdinal("codCarnet"))
                                    },
                                };
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
            return empleado;
        }

        public void Actualizar(clsEmpleado empleado)
        {
            string sql = $@"UPDATE EMPLEADO
	            SET nombres='{empleado.Nombres}',apellPaterno='{empleado.ApellPaterno}',apellMaterno='{empleado.ApellMaterno}',
                fechaNacimiento='1990-05-11',correo='{empleado.Correo}',telefono='{empleado.Telefono}',
                genero='{empleado.Genero}',DNI='{empleado.DNI}',direccion='{empleado.Direccion}',vigente=1,codEmpleado='{empleado.Codigo}',
                codArea={empleado.Area.Codigo},codEncargatura={empleado.Encargatura.Codigo},codCarnet={empleado.Carnet.Codigo}
	            WHERE codSistema={empleado.CodigoSistema}";

            try
            {
                using (var conexion = new SqlConnection(RNEmpleado.CadenaConexion))
                {
                    using (var comandos = new SqlCommand(sql, conexion))
                    {
                        conexion.Open();
                        comandos.ExecuteNonQuery();
                        conexion.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DarDeBaja(clsEmpleado empleado)
        {
            String sql = $@"UPDATE EMPLEADO
	                            SET vigente=0
	                            WHERE codSistema={empleado.CodigoSistema}";
            try
            {
                using (var conexion = new SqlConnection(RNEmpleado.CadenaConexion))
                {
                    using (var comandos = new SqlCommand(sql, conexion))
                    {
                        conexion.Open();
                        comandos.ExecuteNonQuery();
                        conexion.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
