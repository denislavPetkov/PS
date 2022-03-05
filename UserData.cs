using System;
using System.Collections.Generic;

namespace SP
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
            _testUsers.Add(new User("Denislav", "admin", "121219031", UserRoles.ADMIN, DateTime.Now));
            _testUsers.Add(new Student("Pavel", "test1", "1", UserRoles.STUDENT, DateTime.Now, 5, "KSI"));
            _testUsers.Add(new Student("testSt2", "test2", "2", UserRoles.STUDENT, DateTime.Now, 2, "ITI"));
        }

        static public User IsUserPassCorrect(string username, string password)
        {
            ResetTestUserData();
            foreach (User user in _testUsers)
            {
                if (user.Username.Equals(username) && user.Password.Equals(password))
                {
                    return user;
                }
            }

            return null;
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
            Logger.LogActivity("Listing users:");
            foreach (User user in _testUsers)
            {
                Logger.LogActivity("Listed users");
                Console.WriteLine(user);
            }
        }

        static public void PrepareCertificate(string username, string pathToFile)
        {
            Student student = GetStudent(username);
            if (student == null)
            {
                Console.WriteLine("Student " + username + " not found!");
                Logger.LogActivity("Student " + username + " not found!");
                return;
            }
            Logger.LogActivity("Creating a certificate for student " + username);
            Console.WriteLine("Done!");
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