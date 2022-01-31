using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Virtuala
{
    public class User
    {
        private const int onlineInfoArraySize = 4, profileInfoArraySize = 5;

        protected string userName, userEmail, userJoined, userFullname;
        protected int userID, userAge;

        private fProfile profileForm = null;

        public string GetUsername
        {
            get { return userName; }
        }
        public int GetID
        {
            get { return userID; }
        }

        // Constructori
        public User() { }
        public User(int userID, string userName, string userJoined, string userFullname, string userEmail, int userAge) 
        { 
            this.userName = userName; 
            this.userAge = userAge;  
            this.userID = userID;
            this.userEmail = userEmail;
            this.userJoined = userJoined;
            this.userFullname = userFullname;
        }
        // ------------

        public virtual string[] OnlineInfo()
        {
            string[] infoArray = new string[onlineInfoArraySize];

            infoArray[0] = "" + this.userID;
            infoArray[1] = this.userName;
            infoArray[2] = "" + this.userAge;
            infoArray[3] = "Nu exista informatii suplimentare";

            return infoArray;
        }
        public virtual string[] ProfileInfo()
        {
            string[] infoArray = new string[profileInfoArraySize];

            infoArray[0] = this.userName;
            infoArray[1] = this.userFullname;
            infoArray[2] = this.userJoined;
            infoArray[3] = this.userEmail;
            infoArray[4] = "Utilizator normal";

            return infoArray;
        }

        public void ShowProfile()
        {
            if(profileForm == null)
            {
                profileForm = new fProfile(this);
            }

            profileForm.ShowDialog();
        }
    }
}
