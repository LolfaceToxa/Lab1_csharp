using System;
using System.Diagnostics;
using lab1_csharp;

namespace lab1_c
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1ый вариант, лаб. работа 1");
            Console.WriteLine("_________________________________________________________________");

            //Создать один объект типа Student,
            //преобразовать данные в текстовый вид с помощью метода ToShortString() и вывести данные
            //Вывести значения индексатора для значений
            //индекса Education.Specialist,  Education.Bachelor и Education.SecondEducation.
            Student student = new Student();
            Console.WriteLine(student.ToShortString());
            Console.WriteLine(student[Education.Specialist]);
            Console.WriteLine(student[Education.SecondEducation]);
            Console.WriteLine(student[Education.Bachelor]);
            Console.WriteLine("_________________________________________________________________");

            //Присвоить значения всем определенным в типе Student свойствам,
            //преобразовать данные в текстовый вид с помощью метода ToString() и вывести данные.
            student.Pers = new Person("Petya", "Nikolayev", new DateTime(2010, 10, 10));
            student.GroupNumber = 111;
            student.Educat = Education.SecondEducation;

            Exam[] ExamArray = new Exam[2];
            ExamArray[0] = new Exam("Geography", 4, new DateTime(2001, 09, 11));
            ExamArray[1] = new Exam("History", 5, new DateTime(2001, 09, 10));
            student.Exams = ExamArray;

            Console.WriteLine(student.ToString());
            Console.WriteLine("_________________________________________________________________");

            //C помощью метода AddExams( params Exam[] ... ) добавить элементы в список экзаменов 
            //и вывести данные объекта Student, используя метод ToString().
            Exam exam1 = new Exam("Math", 3, new DateTime(2001, 09, 12));
            student.AddExams(exam1);

            Console.WriteLine(student.ToString());
            Console.WriteLine("_________________________________________________________________");

            //Сравнить время выполнения операций с элементами одномерного, двумерного прямоугольного
            //и двумерного ступенчатого массивов с одинаковым числом элементов типа Exam.

            Console.WriteLine("Введите число строк и столбцов\n(лучше, чтобы их произведение было не больше миллиона)");
            string[] t = Console.ReadLine().Split(' ', ':', ';', ',', '.', '-');
            Console.WriteLine("_________________________________________________________________");

            int  row = int.Parse(t[0]);
            int column = int.Parse(t[1]);
            //одномерный

            int sizeOfMas = row * column;
            Exam[] Mas1 = new Exam[sizeOfMas];
            for (int i = 0; i < sizeOfMas; i++)
                Mas1[i] = new Exam(); //создание одномерного массива

            Stopwatch sw = new Stopwatch();
            sw.Start();
            
            for (int i = 0; i < sizeOfMas; i++)
            {
                Mas1[i].Name = "Mathematics";
                Mas1[i].Grade = 5;
            } //заполнение! одномерного массива
            sw.Stop();
            Console.WriteLine("Время выполнения операции для одномерного массива: {0} мсек", sw.ElapsedMilliseconds);
            Console.WriteLine("_________________________________________________________________");
            //двумерный

            Exam[,] Mas2 = new Exam[row, column];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                    Mas2[i, j] = new Exam(); //создание двумерного массива

            sw.Start();
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                {
                    Mas2[i, j].Name = "Mathematics";
                    Mas2[i, j].Grade = 5;
                } //заполнение! двумерного массива
            sw.Stop();
            Console.WriteLine("Время выполнения операции для двумерного массива: {0} мсек", sw.ElapsedMilliseconds);
            Console.WriteLine("_________________________________________________________________");


            //ступенчатый
            Exam[][] Mas3 = new Exam[3][];

            int Size1 = sizeOfMas / 10;
            Mas3[0] = new Exam[Size1];

            //Создание объекта для генерации чисел
            Random rnd = new Random();

            //Получить очередное (в данном случае - первое) случайное число 

            int Size2 = Size1 * rnd.Next(1,8);
            Mas3[1] = new Exam[Size2];

            int Size3 = sizeOfMas - Size1 - Size2;
            Mas3[2] = new Exam[Size3];


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < Mas3[i].Length; j++)
                {
                    Mas3[i][j] = new Exam();
                }
            }//создание ступенчатого массива

            sw.Start();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < Mas3[i].Length; j++)
                {

                    Mas3[i][j].Name = "Mathematics";
                    Mas3[i][j].Grade = 5;
                }
            } //заполнение! ступенчатого массива
            sw.Stop();
            Console.WriteLine("Время выполнения операции для ступенчатого массива: {0} мсек",sw.ElapsedMilliseconds);
            Console.WriteLine("_________________________________________________________________");

            Console.WriteLine("Нажмите любую кнопку, чтобы выйти");
            Console.ReadKey();
        }
    }
}
