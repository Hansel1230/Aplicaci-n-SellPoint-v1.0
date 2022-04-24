using Netframework.Layers.ADO.Net.Data.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class clsLnEntidades
{



    public void Cargar(ref clsBeEntidades oBeEntidades, ref DataRow dr)
    {
        try
        {
            oBeEntidades.IdEntidad = Convert.ToInt32(dr["IdEntidad"].ToString());

            oBeEntidades.Descripcion = string.IsNullOrEmpty(dr["Descripcion"].ToString()) == true ? "" : dr["Descripcion"].ToString();

            oBeEntidades.Direccion = string.IsNullOrEmpty(dr["Direccion"].ToString()) == true ? "" : dr["Direccion"].ToString();

            oBeEntidades.Localidad = string.IsNullOrEmpty(dr["Localidad"].ToString()) == true ? "" : dr["Localidad"].ToString();

            oBeEntidades.TipoEntidad = string.IsNullOrEmpty(dr["TipoEntidad"].ToString()) == true ? "" : dr["TipoEntidad"].ToString();
            oBeEntidades.TipoDocumento = string.IsNullOrEmpty(dr["TipoDocumento"].ToString()) == true ? "" : dr["TipoDocumento"].ToString();
            oBeEntidades.NumeroDocumento = Convert.ToInt32(dr["IdEntidad"].ToString());
            oBeEntidades.Teléfonos = string.IsNullOrEmpty(dr["Teléfonos"].ToString()) == true ? "" : dr["Teléfonos"].ToString();
            oBeEntidades.URLPaginaWeb = string.IsNullOrEmpty(dr["URLPaginaWeb"].ToString()) == true ? "" : dr["URLPaginaWeb"].ToString();
            oBeEntidades.URLFacebook = string.IsNullOrEmpty(dr["URLFacebook"].ToString()) == true ? "" : dr["URLFacebook"].ToString();
            oBeEntidades.URLInstagram = string.IsNullOrEmpty(dr["URLInstagram"].ToString()) == true ? "" : dr["URLInstagram"].ToString();
            oBeEntidades.URLTwitter = string.IsNullOrEmpty(dr["URLTwitter"].ToString()) == true ? "" : dr["URLTwitter"].ToString();
            oBeEntidades.URLTikTok = string.IsNullOrEmpty(dr["URLTikTok"].ToString()) == true ? "" : dr["URLTikTok"].ToString();
            oBeEntidades.IdGrupoEntidad = Convert.ToInt32(dr["IdGrupoEntidad"]);
            oBeEntidades.IdTipoEntidad = Convert.ToInt32(dr["IdTipoEntidad"]);
            oBeEntidades.LimiteCredito = Convert.ToInt32(dr["LimiteCredito"]);
            oBeEntidades.UserNameEntidad = string.IsNullOrEmpty(dr["UserNameEntidad"].ToString()) == true ? "" : dr["UserNameEntidad"].ToString();
            oBeEntidades.PassworEntidad = string.IsNullOrEmpty(dr["PassworEntidad"].ToString()) == true ? "" : dr["PassworEntidad"].ToString();
            oBeEntidades.RolUserEntidad = string.IsNullOrEmpty(dr["RolUserEntidad"].ToString()) == true ? "" : dr["RolUserEntidad"].ToString();
            oBeEntidades.Comentario = string.IsNullOrEmpty(dr["Comentario"].ToString()) == true ? "" : dr["Comentario"].ToString();
            oBeEntidades.Statuss = string.IsNullOrEmpty(dr["Statuss"].ToString()) == true ? "" : dr["Statuss"].ToString();
            oBeEntidades.NoEliminable = Convert.ToBoolean(dr["NoEliminable"]);
            oBeEntidades.FechaRegistro = Convert.ToDateTime(dr["Localidad"]);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public int Insertar(ref clsBeEntidades oBeEntidades)
    {
        try
        {
            string sp = "SpEntidadesInsertar";

            SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
            SqlCommand cmd = new SqlCommand(sp, cnn);

            int rowsAffected = 0;
            cmd.Open();

            cmd.Parameters.Add(new SqlClient.SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));
            cmd.Parameters("@IDENTIDAD").Direction = ParameterDirection.Output;
            cmd.Parameters.Add(new SqlClient.SqlParameter("@DESCRIPCION", oBeEntidades.Descripcion));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@DIRECCION", oBeEntidades.Direccion));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@LOCALIDAD", oBeEntidades.Localidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@TIPOENTIDAD", oBeEntidades.TipoEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@TIPODOCUMENTO", oBeEntidades.TipoDocumento));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@NUMERODOCUMENTO", oBeEntidades.NumeroDocumento));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@TELÉFONOS", oBeEntidades.Teléfonos));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@URLPAGINAWEB", oBeEntidades.URLPaginaWeb));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@URLFACEBOOK", oBeEntidades.URLFacebook));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@URLINSTAGRAM", oBeEntidades.URLInstagram));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@URLTWITTER", oBeEntidades.URLTwitter));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@URLTIKTOK", oBeEntidades.URLTikTok));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@IDGRUPOENTIDAD", oBeEntidades.IdGrupoEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@IDTIPOENTIDAD", oBeEntidades.IdTipoEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@LIMITECREDITO", oBeEntidades.LimiteCredito));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@USERNAMEENTIDAD", oBeEntidades.UserNameEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@PASSWORENTIDAD", oBeEntidades.PassworEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@ROLUSERENTIDAD", oBeEntidades.RolUserEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@COMENTARIO", oBeEntidades.Comentario));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@STATUSS", oBeEntidades.Statuss));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@NOELIMINABLE", oBeEntidades.NoEliminable));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@FECHAREGISTRO", oBeEntidades.FechaRegistro));

            rowsAffected = cmd.ExecuteNonQuery();
            oBeEntidades.IdEntidad = int.Parse(cmd.Parameters["@IDENTIDAD"].Value);

            return rowsAffected;

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public int Actualizar(ref clsBeEntidades oBeEntidades)
    {
        try
        {
            string sp = "SpEntidadesActualizar";

            SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
            SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);

            int rowsAffected = 0;
            cmd.Open();

            cmd.Parameters.Add(new SqlClient.SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@DESCRIPCION", oBeEntidades.Descripcion));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@DIRECCION", oBeEntidades.Direccion));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@LOCALIDAD", oBeEntidades.Localidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@TIPOENTIDAD", oBeEntidades.TipoEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@TIPODOCUMENTO", oBeEntidades.TipoDocumento));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@NUMERODOCUMENTO", oBeEntidades.NumeroDocumento));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@TELÉFONOS", oBeEntidades.Teléfonos));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@URLPAGINAWEB", oBeEntidades.URLPaginaWeb));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@URLFACEBOOK", oBeEntidades.URLFacebook));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@URLINSTAGRAM", oBeEntidades.URLInstagram));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@URLTWITTER", oBeEntidades.URLTwitter));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@URLTIKTOK", oBeEntidades.URLTikTok));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@IDGRUPOENTIDAD", oBeEntidades.IdGrupoEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@IDTIPOENTIDAD", oBeEntidades.IdTipoEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@LIMITECREDITO", oBeEntidades.LimiteCredito));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@USERNAMEENTIDAD", oBeEntidades.UserNameEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@PASSWORENTIDAD", oBeEntidades.PassworEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@ROLUSERENTIDAD", oBeEntidades.RolUserEntidad));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@COMENTARIO", oBeEntidades.Comentario));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@STATUSS", oBeEntidades.Statuss));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@NOELIMINABLE", oBeEntidades.NoEliminable));
            cmd.Parameters.Add(new SqlClient.SqlParameter("@FECHAREGISTRO", oBeEntidades.FechaRegistro));

            rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected;

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public int Eliminar(ref clsBeEntidades oBeEntidades)
    {
        try
        {
            string sp = "SpEntidadesEliminar";

            SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
            SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);

            int rowsAffected = 0;
            cmd.Open();

            cmd.Parameters.Add(new SqlClient.SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));

            rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected;

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public DataTable Listar()
    {
        try
        {
            string sp = "SpEntidadesListar";

            SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dad = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            dad.Fill(dt);

            return dt;

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public bool Obtener(ref clsBeEntidades oBeEntidades)
    {
        try
        {
            string sp = "SpEntidadesObtener";

            SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter dad = new SqlDataAdapter(cmd);
            dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));

            DataTable dt = new DataTable();
            dad.Fill(dt);

            if ((dt.Rows.Count == 1))
            {
                Cargar(oBeEntidades, dt.Rows(0))

            }
            else
            {
                throw new Exception("No se pudo obtener el registro");
            }

            return true;

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

   

}
