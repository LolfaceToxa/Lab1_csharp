using System;
using lab1_c;

namespace lab1_csharp
{
    class Student
    {
        Person pers;
        Education educat;
        int groupNumber;
        Exam[] exams = null;

        public Student(Person persValue, Education educatValue, int groupNumberValue, Exam[] examsValue)
        {
            pers = persValue;
            educat = educatValue;
            groupNumber = groupNumberValue;
        }
        public Student()
        {
            pers = new Person();
            educat = Education.Specialist;
            groupNumber = 23;
        }
        public bool this[Education e]
        {
            get
            {
                return educat == e;
            }
        }
        public Person Pers
        {
            get
            {
                return pers;
            }
            set
            {
                pers = value;
            }
        }
        public Education Educat
        {
            get
            {
                return educat;
            }
            set
            {
                educat = value;
            }
        }
        public int GroupNumber
        {
            get
            {
                return groupNumber;
            }
            set
            {
                groupNumber = value;
            }
        }
        public Exam[] Exams
        {
            get
            {
                return exams;
            }
            set
            {
                exams = value;
            }
        }
        public double Average
        {
            get
            {
                if (Exams == null)
                {
                    return 0;
                }
                int sum = 0;
                foreach (Exam value in Exams)
                {
                    sum += value.Grade;
                }
                return sum / Exams.Length;
            }
        }
        public override string ToString()
        {
            string lineOne = Pers + " " + Educat + " " + GroupNumber;
            for(int i = 0; i < Exams.Length; i++)
            {
                lineOne += "\n" + Exams[i].ToString();
            }
            return lineOne;
        }
        public virtual string ToShortString()
        {
            return Pers + " " + Educat + " " + GroupNumber + " " + Average;
        }
        public void AddExams(params Exam[] newEx)
        {
            int num = exams.Length;
            Array.Resize<Exam>(ref exams, num + newEx.Length);
            for (int i = 0; i < newEx.Length; i++)
            {
                exams[num + i] = newEx[i];
            }
        }
    }
}
