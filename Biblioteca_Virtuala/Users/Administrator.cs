using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Virtuala
{
    public class Administrator : User
    {
        private string adminPin;


        // Constructori
        public Administrator() { }
        public Administrator(int userID, string userName, string userJoined, string userFullname, string userEmail, int userAge, string adminPin) : base(userID, userName, userJoined, userFullname, userEmail, userAge)
        { 
            this.adminPin = adminPin;       
        }
        // ------------

        public override string[] OnlineInfo()
        {
            string[] infoArray = base.OnlineInfo();
            infoArray[3] = "Administrator";

            return infoArray;
        }
        public override string[] ProfileInfo()
        {
            string[] infoArray = base.ProfileInfo();

            infoArray[4] = "Administrator";

            return infoArray;
        }

        public bool CheckAdminPin(string value)
        {
            if (this.adminPin.Equals(value))
            {
                return true;
            }

            return false;
        }
        public void ChangeAdminPin(string newPin)
        {
            this.adminPin = newPin;
        }
    }
}

