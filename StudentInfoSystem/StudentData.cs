using System.Collections.Generic;

namespace StudentInfoSystem

{
    public class StudentData
    {
        public List<Student> TestStudents
        { get; private set; } = new List<Student> { new Student("Denislav", "Biserov", "Petkov", "FKST",
        "KSI", "Bacherlor", StudentStatus.PASSED, "121219099", SemestralCourse.SIXTH, "9th", "31") };
    }
}