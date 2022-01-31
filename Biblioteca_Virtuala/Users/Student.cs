using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Virtuala
{
    public class Student : User
    {
        private string educationUnit;

        // Constructori
        public Student() { }
        public Student(int userID, string userName, string userJoined, string userFullname, string userEmail, int userAge, string educationUnit)  : base(userID, userName, userJoined, userFullname, userEmail, userAge)
        { 
            this.educationUnit = educationUnit; 
        }
        // ------------

        public override string[] OnlineInfo()
        {
            string[] infoArray = base.OnlineInfo();

            infoArray[3] = "Student la " + this.educationUnit;

            return infoArray;
        }
        public override string[] ProfileInfo()
        {
            string[] infoArray = base.ProfileInfo();

            infoArray[4] = "Student la " + this.educationUnit;

            return infoArray;
        }
    }
}
