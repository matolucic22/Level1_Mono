using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    class StudentContainer
    {
        public List<Student> students = new List<Student>();
        public void Add(Student stud)
        {
            students.Add(stud);
        }
        public void DisplaySTD()
        {
            while (students != null)
            {
                Console.WriteLine(students);
            }
        }
    }
}
