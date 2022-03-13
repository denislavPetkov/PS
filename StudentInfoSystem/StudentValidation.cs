
using System;
using Microsoft.Win32;
using UserLogin;

namespace StudentInfoSystem
{
    public class StudentValidation
    {
        public Student GetStudentDataByUser(User user)
        {
            if (user.Role != UserRoles.STUDENT)
            {
                return null;
            }

            return StudentData.GetStudentByFacultyNumber(user.FacNumber);
        }
    }
}