using BE;
using Netframework.Layers.ADO.Net.Data.Models;
using System.Linq;
using System.Text;
using System;
using System.Data.SqlClient;
using System.Data;
using 

public class clsLnEntidades
{

	private ConnectionManager oConexion = null;

	public void Cargar(ref clsBeEntidades oBeEntidades, ref DataRow dr)
	{

		oBeEntidades.IdEntidad = Convert.ToInt32(dr["id_entidad"].ToString());
		oBeEntidades.Descripcion = string.IsNullOrEmpty(dr["descripcion"].ToString()) == ? true : dr["descripcion"].ToString();
		oBeEntidades.Direccion = string.IsNullOrEmpty(dr["Direccion"].ToString()) == ? true dr.["Direccion"].ToString();
		oBeEntidades.Localidad = string.IsNullOrEmpty(dr["Localidad"].ToString()) == ? true dr.["Localidad"].ToString();


		oBeEntidades.TipoEntidad = string.IsNullOrEmpty(dr["TipoEntidad"].ToString()) == ? true : dr.["TipoEntidad"].ToString();


		oBeEntidades.TipoDocumento = string.IsNullOrEmpty(dr["TipoDocumento"].ToString()) == ? true : dr.["TipoDocumento"].ToString();


		oBeEntidades.NumeroDocumento = string.IsNullOrEmpty(dr["NumeroDocumento"] ? 0 : dr["NumeroDocumento"].ToString();


		oBeEntidades.Teléfonos = string.IsNullOrEmpty(dr["Teléfonos"].ToString()) == ? true : dr.["Teléfonos"].ToString();


		oBeEntidades.URLPaginaWeb = string.IsNullOrEmpty(dr["URLPaginaWeb"].ToString()) == ? true : dr["URLPaginaWeb"].ToString();


		oBeEntidades.URLFacebook = string.IsNullOrEmpty(dr["URLFacebook"].ToString()) == ? true : dr.["URLFacebook"].ToString();


		oBeEntidades.URLInstagram = string.IsNullOrEmpty(dr["URLInstagram"].ToString()) == ? true : dr.["URLInstagram"].ToString();


		oBeEntidades.URLTwitter = string.IsNullOrEmpty(dr["URLTwitter"].ToString()) == ? true : dr.["URLTwitter"].ToString();


		oBeEntidades.URLTikTok = string.IsNullOrEmpty(dr["URLTikTok"].ToString()) == ? true : dr.["URLTikTok"].ToString();


		oBeEntidades.IdGrupoEntidad = string.IsNullOrEmpty(dr["IdGrupoEntidad"] ? 0 : dr.["IdGrupoEntidad"].ToString();


		oBeEntidades.IdTipoEntidad = string.IsNullOrEmpty(dr["IdTipoEntidad"] ? 0 : dr.["IdTipoEntidad"].ToString();


		oBeEntidades.LimiteCredito = string.IsNullOrEmpty(dr["LimiteCredito"] ? 0 : dr.["LimiteCredito"].ToString();


		oBeEntidades.UserNameEntidad = string.IsNullOrEmpty(dr["UserNameEntidad"].ToString()) == ? true : dr.["UserNameEntidad"].ToString();


		oBeEntidades.PassworEntidad = string.IsNullOrEmpty(dr["PassworEntidad"]).ToString())== ? true : dr.["PassworEntidad"].ToString();


		oBeEntidades.RolUserEntidad = string.IsNullOrEmpty(dr["RolUserEntidad"]).ToString())== ? true : dr.["RolUserEntidad"].ToString();


		oBeEntidades.Comentario = string.IsNullOrEmpty(dr["Comentario"]).ToString())== ? true : dr.["Comentario"].ToString();


		oBeEntidades.Statuss = string.IsNullOrEmpty(dr["Statuss"]).ToString())== ? true : dr.["Statuss"].ToString();


		oBeEntidades.NoEliminable = Convert.ToDateTime(dr["NoEliminable"]) ? False : dr.["NoEliminable"].ToString();


		oBeEntidades.FechaRegistro = string.IsNullOrEmpty(dr["FechaRegistro"]) ?  : dr.["FechaRegistro"].ToString();

	


        catch (Exception ex)
        {
	public void Cargar(ref clsBeTbUsuarios oBeEntidades, ref DataRow dr) {
		try {
				oBeEntidades.IdEntidad = ( IsDBNull(dr.Item['IdEntidad']) ? 0 : dr.Item['IdEntidad'] )
				oBeEntidades.Descripcion = ( IsDBNull(dr.Item['Descripcion']) ? '' : dr.Item['Descripcion'] )
				oBeEntidades.Direccion = ( IsDBNull(dr.Item['Direccion']) ? '' : dr.Item['Direccion'] )
				oBeEntidades.Localidad = ( IsDBNull(dr.Item['Localidad']) ? '' : dr.Item['Localidad'] )
				oBeEntidades.TipoEntidad = ( IsDBNull(dr.Item['TipoEntidad']) ? '' : dr.Item['TipoEntidad'] )
				oBeEntidades.TipoDocumento = ( IsDBNull(dr.Item['TipoDocumento']) ? '' : dr.Item['TipoDocumento'] )
				oBeEntidades.NumeroDocumento = ( IsDBNull(dr.Item['NumeroDocumento']) ? 0 : dr.Item['NumeroDocumento'] )
				oBeEntidades.Teléfonos = ( IsDBNull(dr.Item['Teléfonos']) ? '' : dr.Item['Teléfonos'] )
				oBeEntidades.URLPaginaWeb = ( IsDBNull(dr.Item['URLPaginaWeb']) ? '' : dr.Item['URLPaginaWeb'] )
				oBeEntidades.URLFacebook = ( IsDBNull(dr.Item['URLFacebook']) ? '' : dr.Item['URLFacebook'] )
				oBeEntidades.URLInstagram = ( IsDBNull(dr.Item['URLInstagram']) ? '' : dr.Item['URLInstagram'] )
				oBeEntidades.URLTwitter = ( IsDBNull(dr.Item['URLTwitter']) ? '' : dr.Item['URLTwitter'] )
				oBeEntidades.URLTikTok = ( IsDBNull(dr.Item['URLTikTok']) ? '' : dr.Item['URLTikTok'] )
				oBeEntidades.IdGrupoEntidad = ( IsDBNull(dr.Item['IdGrupoEntidad']) ? 0 : dr.Item['IdGrupoEntidad'] )
				oBeEntidades.IdTipoEntidad = ( IsDBNull(dr.Item['IdTipoEntidad']) ? 0 : dr.Item['IdTipoEntidad'] )
				oBeEntidades.LimiteCredito = ( IsDBNull(dr.Item['LimiteCredito']) ? 0 : dr.Item['LimiteCredito'] )
				oBeEntidades.UserNameEntidad = ( IsDBNull(dr.Item['UserNameEntidad']) ? '' : dr.Item['UserNameEntidad'] )
				oBeEntidades.PassworEntidad = ( IsDBNull(dr.Item['PassworEntidad']) ? '' : dr.Item['PassworEntidad'] )
				oBeEntidades.RolUserEntidad = ( IsDBNull(dr.Item['RolUserEntidad']) ? '' : dr.Item['RolUserEntidad'] )
				oBeEntidades.Comentario = ( IsDBNull(dr.Item['Comentario']) ? '' : dr.Item['Comentario'] )
				oBeEntidades.Statuss = ( IsDBNull(dr.Item['Statuss']) ? '' : dr.Item['Statuss'] )
				oBeEntidades.NoEliminable = ( IsDBNull(dr.Item['NoEliminable']) ? False : dr.Item['NoEliminable'] )
				oBeEntidades.FechaRegistro = ( IsDBNull(dr.Item['FechaRegistro']) ?  : dr.Item['FechaRegistro'] )
		catch (Exception ex) {
			throw ex;
		}
	}

    public int Insertar(ref clsBeEntidades oBeEntidades)
    {
        try
        {
            string sp = "SpEntidadesInsertar";
	public int Insertar(ref clsBeEntidades oBeEntidades) {
		try {
			string sp = 'SpEntidadesInsertar';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlClient.SqlCommand cmd = new SqlClient.SqlCommand(sp, cnn);
			
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
		catch (Exception ex) {
			throw ex;
		}
	}

    public int Actualizar(ref clsBeEntidades oBeEntidades)
    {
        try
        {
            string sp = "SpEntidadesActualizar";
	public int Actualizar(ref clsBeEntidades oBeEntidades) {
		try {
			string sp = 'SpEntidadesActualizar';
			
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
		catch (Exception ex) {
			throw ex;
		}
	}

    public int Eliminar(ref clsBeEntidades oBeEntidades)
    {
        try
        {
            string sp = "SpEntidadesEliminar";
	public int Eliminar(ref clsBeEntidades oBeEntidades) {
		try {
			string sp = 'SpEntidadesEliminar';
			
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
		catch (Exception ex) {
			throw ex;
		}
	}

    public DataTable Listar()
    {
        try
        {
            string sp = "SpEntidadesListar";
	public DataTable Listar() {
		try {
			string sp = 'SpEntidadesListar';
			
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
		catch (Exception ex) {
			throw ex;
		}
	}

    public bool Obtener(ref clsBeEntidades oBeEntidades)
    {
        try
        {
            string sp = "SpEntidadesObtener";
	public bool Obtener(ref clsBeEntidades oBeEntidades) {
		try {
			string sp = 'SpEntidadesObtener';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
            if ((dt.Rows.Count == 1))
            {
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeEntidades, dt.Rows(0))

			}
            else
            {
                throw new Exception("No se pudo obtener el registro");
			else {
				throw new Exception('No se pudo obtener el registro');
			}
			
			return true;
			
		}
        catch (Exception ex)
        {
		catch (Exception ex) {
			throw ex;
		}
	}

    public bool Primero(ref clsBeEntidades oBeEntidades)
    {
	public bool Primero(ref clsBeEntidades oBeEntidades) {
		Try

            string sp = "SpEntidadesPrimero";
			string sp = 'SpEntidadesPrimero';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
        if ((dt.Rows.Count == 1))
        {
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeEntidades, dt.Rows[0]);
			}
        else
        {
            throw new Exception("No se pudo obtener el primer registro");
			else {
				throw new Exception('No se pudo obtener el primer registro');
			}
			
			return true;
		}
		catch (Exception ex) {
			throw ex;
		}
	}

	public bool Primero(ref clsBeEntidades oBeEntidades)
{
    try
    {
        string sp = "SpEntidadesUltimo";
	public bool Primero(ref clsBeEntidades oBeEntidades) {
		try {
			string sp = 'SpEntidadesUltimo';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
        if ((dt.Rows.Count == 1))
        {
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeEntidades, dt.Rows[0]);
			}
        else
        {
            throw new Exception("No se pudo obtener el primer registro");
			else {
				throw new Exception('No se pudo obtener el primer registro');
			}
			
			return true;
		}
    catch (Exception ex)
    {
		catch (Exception ex) {
			throw ex;
		}
	}

public bool Anterior(ref clsBeEntidades oBeEntidades)
{
	public bool Anterior(ref clsBeEntidades oBeEntidades) {
		Try

            string sp = "SpEntidadesAnterior";
			string sp = 'SpEntidadesAnterior';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
    if ((dt.Rows.Count == 1))
    {
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeEntidades, dt.Rows[0]);
			}
    else
    {
        throw new Exception("No se pudo obtener el anterior registro");
			else {
				throw new Exception('No se pudo obtener el anterior registro');
			End If

			}
			
			return true;
		}

        catch (Exception ex)
{
		catch (Exception ex) {
			throw ex;
		}
	}

	public bool Siguiente(ref clsBeEntidades oBeEntidades)
{
	public bool Siguiente(ref clsBeEntidades oBeEntidades) {
		Try

            string sp = "SpEntidadesSiguiente";
			string sp = 'SpEntidadesSiguiente';
			
			SqlConnection cnn = new SqlConnection(oConexion.ConexionLocal);
			SqlCommand cmd = new SqlCommand(sp, cnn);
			cmd.CommandType = CommandType.StoredProcedure;
			
			SqlDataAdapter dad = new SqlDataAdapter(cmd);
			dad.SelectCommand.Parameters.Add(new SqlClient.SqlParameter("@IDENTIDAD", oBeEntidades.IdEntidad));
			
			DataTable dt = new DataTable();
			dad.Fill(dt);
			
    if ((dt.Rows.Count == 1))
    {
			if ((dt.Rows.Count == 1)) {
				Cargar(oBeEntidades, dt.Rows[0]);
			}
    else
    {
        throw new Exception("No se pudo obtener el siguiente registro");
			else {
				throw new Exception('No se pudo obtener el siguiente registro');
			End If

			}
			
			return true;
		}

        catch (Exception ex)
{
		catch (Exception ex) {
			throw ex;
		}
	}

}

internal class ConnectionManager
{
}