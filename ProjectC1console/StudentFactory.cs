using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectC1console
{
    class StudentFactory
    {
        public List<Student> CreateStudents(int studentsQuantity)
    {
        List<Student> students = new List<Student>();
        Dictionary<String, int> marks;
        string surname;
        Random r = new Random();
        for (int i = 0; i < studentsQuantity; i++)
        {
                marks = new Dictionary<string, int>
                {
                    { "History", r.Next(60, 100) },
                    { "Philosophy", r.Next(60, 100) },
                    { "C++", r.Next(60, 100) },
                    { "C#", r.Next(60, 100) },
                    { "Haskell", r.Next(60, 100) },
                    { "Machine Learning", r.Next(60, 100) }
                };
                surname = RandomChar() + RandomString(r.Next(6, 10));
                students.Add(new Student(surname, marks));
        }
            return students;
    }

    public static string RandomChar()
    {            
        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char c = chars[random.Next(0, chars.Length)];
        return c.ToString();
    }

    public static string RandomString(int length)
    {
        Random random = new Random();
        const string chars = "abcdefghijkmnopqrstuvwxyz";
        return new string(Enumerable.Repeat(chars, length)
          .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}
}
