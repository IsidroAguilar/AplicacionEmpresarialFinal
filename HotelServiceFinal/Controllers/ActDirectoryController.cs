using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HotelServiceFinal.Controllers
{
    public class ActDirectoryController : ApiController
    {
        //The context of Active Directory
        #region Context

        PrincipalContext ctxH = new PrincipalContext(
        ContextType.Domain,
        "bonafide.local",
        "DC=bonafide,DC=local,OU=Hotel,OU=Admins",
        ContextOptions.Negotiate,
        "emuñoz@bonafide.local",
        "Admin123456"
        );

        PrincipalContext ctxR = new PrincipalContext(
      ContextType.Domain,
      "bonafide.local",
      "DC=bonafide,DC=local,OU=Hotel,OU=Rooms",
      ContextOptions.Negotiate,
      "emuñoz@bonafide.local",
      "Admin123456"
      );

        PrincipalContext ctx = new PrincipalContext(
   ContextType.Domain,
   "bonafide.local",
   "DC=bonafide,DC=local,OU=Hotel,OU=Rooms",
   ContextOptions.Negotiate,
   "emuñoz@bonafide.local",
   "Admin123456"
   );


        #endregion



        //General Methods
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
                var usuario = UserPrincipal.FindByIdentity(ctxR, roomNumber.ToString());
                if (usuario != null) return false;

                //Se arma la variable del usuario del Active Directory
                //para crear una habitacion como usuario en el active directory
                var newRoom = new UserPrincipal(ctx)
                {
                    //El nombre del usuario sera el numero de la habitacion
                    GivenName = roomNumber.ToString(),
                    SamAccountName = roomNumber.ToString(CultureInfo.InvariantCulture),
                    //Surname = "",
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

                var room = UserPrincipal.FindByIdentity(ctxR, roomNumber.ToString());
                room.Description = roomStatus;
                room.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public string SignAdmin(string user, string password)
        {
            try
            {
                var validUser = ValidateCredentials(user, password);
                if (!validUser)
                    return "";


                var room = UserPrincipal.FindByIdentity(ctxH, user);
                return room.GivenName;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public bool SignInTenant(int roomNumber, string adminPass, string tenantName, string tenantSurname, string tenantAccess,
             string tenantEmail, string tenantPassword)
        {
            try
            {
                var validUser = ValidateCredentials(roomNumber.ToString(), adminPass);
                if (!validUser)
                    return false;

                var room = UserPrincipal.FindByIdentity(ctxR, roomNumber.ToString());
                room.Description = "Occupy";
                room.EmailAddress = tenantEmail;
                room.Surname = tenantName + tenantSurname;
                room.SamAccountName = tenantAccess;
                room.Enabled = true;
                room.SetPassword(tenantPassword);
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

                var room = UserPrincipal.FindByIdentity(ctxR, roomNumber.ToString());
                room.Description = "Enabled";
                room.EmailAddress = "Empty";
                room.Surname = "Empty";
                room.SamAccountName = "Empty";
                room.SetPassword("Empty");
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

                var room = UserPrincipal.FindByIdentity(ctxR, roomNumber.ToString());
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