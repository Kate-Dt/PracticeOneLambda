using System;
using System.Collections.Generic;

namespace ProjectC1console
{
    class Program
    {
        static void Main(string[] args)
        { 
            StudentFactory sf = new StudentFactory();
            List<Student> students = sf.CreateStudents(4);
            StudentLogic sl = new StudentLogic();
            Dictionary<Student, float> avMark = sl.AddAverageMark(students);
            sl.SortByAvgMark(avMark);
            sl.PrintStudentWithMarks(avMark);           

            Console.ReadLine();
        }
    }
}
