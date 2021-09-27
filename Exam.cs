using System;

namespace lab1_csharp
{
    enum Education { Specialist, Bachelor, SecondEducation }
    class Exam
    {
        string name;
        int grade;
        DateTime dateOfExam;

        public Exam(string nameValue, int gradeValue, DateTime dateOfExamValue)
        {
            name = nameValue;
            grade = gradeValue;
            dateOfExam = dateOfExamValue;
        }
        public Exam():this("Petya", 5, new DateTime(2000, 1, 1))
        {
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                grade = value;
            }
        }
        public DateTime DateOfExam
        {
            get
            {
                return dateOfExam;
            }
            set
            {
                dateOfExam = value;
            }
        }
        public override string ToString()
        {
            return Name + " " + Grade + " " + DateOfExam;
        }

    }
}
