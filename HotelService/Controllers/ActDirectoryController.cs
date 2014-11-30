using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HotelService.Controllers
{
    public class ActDirectoryController : ApiController
    {
        //The context of Active Directory
        #region Context

        PrincipalContext ctx = new PrincipalContext(
            ContextType.Domain, //Name parameters
            "Xavier.Server",
            "DC=Xavier,DC=Server",
            ContextOptions.Negotiate,
            "jahumada@Xavier.Server",//"jahumada@Xavier.Server",
            "Javi123"
            );

        #endregion

        //All the General Methods
        #region General Methods
        public bool ValidateCredentials(string username, string password)
        {
            //Busca la identidads, para no repetir un ususario
            var usuario = UserPrincipal.FindByIdentity(ctx, username);
            return usuario != null && ctx.ValidateCredentials(username, password);
        }

        #endregion



        public bool AddRoom(int roomNumber, string adminPass, string roomPhone, string roomStatus)
        {
            try
            {
                //Se verifica que no exista una habitacion registrada con el mismo numero de habitacion
                var usuario = UserPrincipal.FindByIdentity(ctx, roomNumber.ToString());
                if (usuario != null) return false;

                //Se arma la variable del usuario del Active Directory
                //para crear una habitacion como usuario en el active directory
                var newRoom = new UserPrincipal(ctx)
                {
                    //El nombre del usuario sera el numero de la habitacion
                    GivenName = roomNumber.ToString(),
                    Surname = "",
                    SamAccountName = "",
                    VoiceTelephoneNumber = roomPhone,
                    Description = roomStatus,
                    Enabled = true
                };

                var password = adminPass;
                newRoom.SetPassword(password);
                newRoom.ExpirePasswordNow();
                newRoom.Save();
                return true;
            }


            catch (Exception)
            {
                return false;
            }
        }

        public bool ChangeRoomStatus(int roomNumber, string adminPass, string roomStatus)
        {
            try
            {
                var validUser = ValidateCredentials(roomNumber.ToString(), adminPass);
                if (!validUser)
                    return false;

                var room = UserPrincipal.FindByIdentity(ctx, roomNumber.ToString());
                room.Description = roomStatus;
                room.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool SignInTenant(int roomNumber, string adminPass, string tenantName, string tenantSurname, string tenantAccess,
             string tenantEmail)
        {
            try
            {
                var validUser = ValidateCredentials(roomNumber.ToString(), adminPass);
                if (!validUser)
                    return false;

                var room = UserPrincipal.FindByIdentity(ctx, roomNumber.ToString());
                room.Description = "Occupy";
                room.EmailAddress = tenantEmail;
                room.Surname = tenantName + tenantSurname;
                room.SamAccountName = tenantAccess;
                room.Enabled = true;
                room.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool LogOutTenant(int roomNumber, string adminPass)
        {
            try
            {
                var validUser = ValidateCredentials(roomNumber.ToString(), adminPass);
                if (!validUser)
                    return false;

                var room = UserPrincipal.FindByIdentity(ctx, roomNumber.ToString());
                room.Description = "Enabled";
                room.EmailAddress = "";
                room.Surname = "";
                room.SamAccountName = "";
                room.Enabled = true;
                room.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool BlockRoom(int roomNumber, string adminPass)
        {
            try
            {
                var validUser = ValidateCredentials(roomNumber.ToString(), adminPass);
                if (!validUser)
                    return false;

                var room = UserPrincipal.FindByIdentity(ctx, roomNumber.ToString());
                room.Description = "Locked";
                room.Enabled = false;
                room.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
