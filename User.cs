using System;

namespace SP
{
    public class User
    {

        public User() { }

        public User(string userName, string password, string facNumber, UserRoles role, DateTime creationData)
        {
            Username = userName;
            Password = password;
            FacNumber = facNumber;
            Role = role;
            CreationDate = creationData;
            ExpirationDate = new DateTime(2999, 1, 1);
        }

        public DateTime ExpirationDate
        { get; set; }
        public DateTime CreationDate
        { get; set; }
        public String Username
        { get; set; }
        public String Password
        { get; set; }
        public String FacNumber
        { get; set; }
        public UserRoles Role
        { get; set; }

        public override string ToString()
        {
            return "\nUsername: " + Username +
                    "\nFaculty number: " + FacNumber +
                    "\nRole: " + Role +
                    "\nCreation Date: " + CreationDate.ToString("dddd, dd MMMM yyyy") +
                    "\nExpiration Date: " + ExpirationDate.ToString("dddd, dd MMMM yyyy");
        }

    }
}