using System;
using System.Collections.Generic;

namespace StudentInfoSystem

{
    public class StudentData
    {
        static public List<Student> TestStudents
        { get; private set; } = new List<Student> { new Student("Denislav", "Biserov", "Petkov", "FKST","KSI", "Bachelor", StudentStatus.PASSED, "121219099", 6, 9, 31),
                                                    new Student("Pavel", "Biserov", "Petkov", "FKST","KSI", "Masters", StudentStatus.PASSED, "121213100", 4, 12, 31),
                                                    new Student("Firstname", "Middlename", "Lastname", "Faculty","Specialization", "Degree", StudentStatus.FAILED, "Faculty number", 99, 99, 99)};

        static public Student GetStudentByFacultyNumber(String facNumber)
        {
            foreach (Student student in TestStudents)
            {
                if (student.FacultyNumber.Equals(facNumber))
                {
                    return student;
                }
            }

            return null;
        }

        static public Student GetStudentByNames(String firstName, String middleName, string lastName)
        {
            foreach (Student student in TestStudents)
            {
                if (student.FirstName.Equals(firstName) &&
                    student.MiddleName.Equals(middleName) &&
                    student.LastName.Equals(lastName) )
                {
                    return student;
                }
            }
            return null;
        }
    }
}