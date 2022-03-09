namespace StudentInfoSystem
{
    public class Student
    {

        public Student() { }

        public Student(string name, string middleName, string lastName, string faculty, string specialization, string qualificationDegree, StudentStatus studentStatus, string facultyNumber, SemestralCourse semestralCourse, string semestralStream, string semestralGroup)
        {
            Name = name;
            MiddleName = middleName;
            LastName = lastName;
            Faculty = faculty;
            Specialization = specialization;
            QualificationDegree = qualificationDegree;
            StudentStatus = studentStatus;
            FacultyNumber = facultyNumber;
            SemestralCourse = semestralCourse;
            SemestralStream = semestralStream;
            SemestralGroup = semestralGroup;
        }

        public string Name
        { get; set; }

        public string MiddleName
        { get; set; }

        public string LastName
        { get; set; }

        public string Faculty
        { get; set; }
        public string Specialization
        { get; set; }
        public string QualificationDegree
        { get; set; }
        public StudentStatus StudentStatus
        { get; set; }
        public string FacultyNumber
        { get; set; }

        public SemestralCourse SemestralCourse
        { get; set; }
        public string SemestralStream
        { get; set; }
        public string SemestralGroup
        { get; set; }
    }
}