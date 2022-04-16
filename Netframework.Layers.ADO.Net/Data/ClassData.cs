using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Netframework.Layers.ADO.Net.Data
{
    class ClassData
    {
       
        private string Base;
        private string server;
        private string User;
        private string Password;
        private string ConnectionString;
        private bool Seguridad;
        private static ClassData con = null; //metodo autenticacion  de la clase con sql server


        public ClassData()
        {

            this.Base = "Create database SellPoint;";
            this.server = "DESKTOP-H1LCLOS";
            this.User = "sa";
            this.Password = "123";
            this.ConnectionString = "Data Source=" + this.server + ";Initial Catalog=SellPoint;Integrated Security=True";
            this.Seguridad = true;


        }
        //METODO PUBLICO PARA DEVOLVER EL STRING DE CONEXION    //
        
       public SqlConnetion crearConexion()
        {
            ///variable sqlconnetion
            SqlConnetion cadena = new SqlConnetion();
            try
            {
                // cadena de conexion 
                cadena.ConnetionString = "Data Source=" + this.server + ";Initial Catalog=SellPoint;Integrated Security=True";
                //seguridad de conexion//
                if (this.Seguridad)   
                {
                    cadena.ConnetionString = cadena.ConnetionString + ";Integrated Security= SSPI";
                }
                else
                {
                    cadena.ConnetionString = cadena.ConnetionString + ";User ID=" + this.User + ";Password=" + this.Password;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return cadena;
        }
        // crear metodo para generar instacia al constructor dentro de la clase //
        public static ClassData getInstance()
        {
            if (con == null)
            {
                con = new ClassData();
            }
            return con;
        }

    }

    public class SqlConnetion
    {
        internal string? ConnetionString;
    }
}