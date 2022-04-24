using System.Configuration;


namespace Netframework.Layers.ADO.Net.Data
{
    public class ConexionDB
    {
        public static string StringConnection = ConfigurationMananer.ConnectionString["DBConnection"].ConnectionString;

    }
}
