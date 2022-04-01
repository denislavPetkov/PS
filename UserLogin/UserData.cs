using System;
using System.Collections.Generic;
using System.Linq;


namespace UserLogin
{
    public static class UserData
    {
        private static List<User> _testUsers;

        static private void ResetTestUserData()
        {
            if (_testUsers != null)
            {
                return;
            }
            _testUsers = new List<User>();
            _testUsers.Add(new User("Denislav", "admin", "121219031", UserRoles.INSPECTOR, DateTime.Now));
            _testUsers.Add(new Student("Pavel", "test1", "1", UserRoles.STUDENT, DateTime.Now, 5, "KSI"));
            _testUsers.Add(new Student("Denislav", "Petkov", "121219031", UserRoles.STUDENT, DateTime.Now, 2, "ITI"));
        }

        static public User IsUserPassCorrect(string username, string password)
        {
            ResetTestUserData();
            return (from user in _testUsers
                    where user.Username.Equals(username) && user.Password.Equals(password)
                    select user).First();
        }

        static public void SetUserExpirationDate(string username, DateTime newExpirationDate)
        {
            foreach (User user in _testUsers)
            {
                if (user.Username.Equals(username))
                {
                    Logger.LogActivity("Changed account expiration date of user " + user.Username);
                    user.ExpirationDate = newExpirationDate;
                    return;
                }
            }
            Logger.LogActivity("User " + username + " not found!");
        }

        static public void AssignUserRole(string username, UserRoles newUserRole)
        {
            foreach (User user in _testUsers)
            {
                if (user.Username.Equals(username))
                {
                    Logger.LogActivity("Changed role of user " + user.Username);
                    user.Role = newUserRole;
                    return;
                }
            }
            Logger.LogActivity("User " + username + " not found!");
        }

        static public void ListUsers()
        {
            Logger.LogActivity("Listed users");
            foreach (User user in _testUsers)
            {
                Console.WriteLine(user);
            }
        }

        static public void PrepareCertificate(string username, string pathToFile)
        {
            Student student = GetStudent(username);
            if (student == null)
            {
                Logger.LogActivity("Student " + username + " not found!");
                return;
            }
            Logger.LogActivity("Creating a certificate for student " + username);
            Logger.CreateCertificate("Certificate for a completed semester for student " + student.Username + student.ToString(), pathToFile);
            return;
        }



        static private Student GetStudent(string username)
        {
            foreach (User user in _testUsers)
            {
                if (user.Username.Equals(username) && user.Role == UserRoles.STUDENT)
                {
                    return (Student)user;
                }
            }

            return null;

        }
    }

}