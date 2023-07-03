using System;
using System.Data;
using System.Data.SqlClient;

namespace capaConexion.Login
{
    public abstract class ejecutarConsultasSCP : conexionBD
    {
        public DataTable ejecutarConsultas(string NombreSCP, SqlParameter[] sqlParamameters, bool Directa = false)
        { 
            DataTable DirectorTecnico = new DataTable();
            try
            {
                using (SqlConnection C5N = GetConexion())
                {
                    C5N.Open();
                    using (SqlCommand comandou = new SqlCommand(NombreSCP, C5N)) 
                    {
                        comandou.CommandType = CommandType.StoredProcedure;
                        comandou.Parameters.AddRange(sqlParamameters);
                        if (!Directa)
                        {
                            DirectorTecnico.Load(comandou.ExecuteReader());
                        }
                        else
                        {
                            comandou.ExecuteNonQuery();
                        }
                    }
                }
                return DirectorTecnico;
            }
            catch (Exception ex)
            {
                throw new Exception("Alucina broer, eta vaina no funciona \n" + ex.Message);
            }
            finally
            {

            }
        }
    }
}
