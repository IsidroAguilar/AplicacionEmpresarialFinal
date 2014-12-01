using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

///LIBRERIAS PARA ENCRIPTAR
using System.Web.Configuration;
using System.Web.Security;
using System.Configuration;



namespace HotelService.EnryptConnection
{
    public class encrypt
    {
        //Encriptar la cadenada de conexion a la base de datos
        //cuando cargar la pagina web
        public void EncryptConnection()
        {
            Configuration config = WebConfigurationManager.OpenWebConfiguration("~");
            ConfigurationSection connSection = config.GetSection("connectionStrings");

            if (!connSection.SectionInformation.IsProtected)
            {
                connSection.SectionInformation.ProtectSection("RsaProtectedConfigurationProvider");
                config.Save();
            }
        }


        //Desencriptar la cadenada de conexion a la base de datos
        //cuando cargar la pagina web
        public void DecryptConnString()
        {
            Configuration config = WebConfigurationManager.OpenWebConfiguration("~");
            ConfigurationSection connSection = config.GetSection("connectionStrings");

            if (connSection.SectionInformation.IsProtected)
            {
                connSection.SectionInformation.UnprotectSection();
                config.Save();
            }
        }


    }
}