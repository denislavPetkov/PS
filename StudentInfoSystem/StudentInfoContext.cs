using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class StudentInfoContext : DbContext
    {
        public StudentInfoContext() : base(Properties.Settings.Default.DbConnect)
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<UserLogin.User> Users { get; set; }

        public bool TestUsersIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();
            IEnumerable<UserLogin.User> queryUsers = context.Users;
            return queryUsers.Count() == 0;
        }

        public void CopyTestUsers()
        {
            StudentInfoContext context = new StudentInfoContext();

            foreach (UserLogin.User user in UserLogin.UserData.TestUsers)
            {
                context.Users.Add(user);
            }

            context.SaveChanges();
        }

        public bool TestStudentsIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();
            IEnumerable<Student> queryStudents = context.Students;
            return queryStudents.Count() == 0;
        }

        public void CopyTestStudents()
        {
            StudentInfoContext context = new StudentInfoContext();

            foreach (Student st in StudentData.TestStudents)
            {
                context.Students.Add(st);
            }

            context.SaveChanges();
        }

        private static List<Student> GetRegions()
        {
            StudentInfoContext context = new StudentInfoContext();
            List<Student> students = context.Students.ToList();
            return students;
        }
    }
}
