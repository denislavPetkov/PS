using System;

namespace UserLogin
{
    public class Student : User
    {
        public int CurrentSemester
        { get; set; }
        public String StudySpecialty
        { get; set; }

        public Student(string userName, string password, string facNumber, UserRoles role, DateTime creationData, int currentSemester, string studySpecialty) : base(userName, password, facNumber, role, creationData)
        {
            CurrentSemester = currentSemester;
            StudySpecialty = studySpecialty;
        }

        public override string ToString()
        {
            return "\nStudent: " + Username +
                    "\nFaculty number: " + FacNumber +
                    "\nSemester: " + CurrentSemester +
                    "\nSpecialty: " + StudySpecialty;
        }
    }
}