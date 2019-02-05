using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectC1console
{
    class StudentLogic
    {
        public Dictionary<Student, float> AddAverageMark(List<Student> students)
        {
            Dictionary<Student, float> avgStudent = new Dictionary<Student, float>();
            students.ForEach(x => avgStudent.Add(x, (x.Marks.Sum(v => v.Value))/x.Marks.Count));
            return avgStudent;
        }

        public void SortByAvgMark(Dictionary<Student, float> students)
        {
            students.OrderBy(x => x.Value);
        }

        public void PrintStudentWithMarks(Dictionary<Student, float> students)
        {
            foreach (KeyValuePair<Student, float> kvp in students)
            {
                Console.Write("\nSurname: ");
                Console.WriteLine(kvp.Key.toString());
                Console.WriteLine("Average mark: " + kvp.Value);
            }
        }
    }
}
