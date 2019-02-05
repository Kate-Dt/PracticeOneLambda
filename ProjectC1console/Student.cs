using System;
using System.Collections.Generic;

namespace ProjectC1console
{
    class Student
    {
        string Surname;
        Dictionary<String, int> marks;

        public Dictionary<string, int> Marks { get => marks; set => marks = value; }
        public string Surname1 { get => Surname; set => Surname = value; }

        public Student(string Surname, Dictionary<string, int> marks)
        {
            this.Surname = Surname;
            this.marks = marks;
        }

        public String toString()
        {
            string marksStr = "";
            foreach (KeyValuePair<string, int> kvp in marks) {
                marksStr += "\nKey = " + kvp.Key + "Value = " + kvp.Value;
            }
            return $"{Surname} \nMarks:\n {marksStr}";
        }
    }
}
