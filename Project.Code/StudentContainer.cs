using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentContainer
    {
        private static StudentContainer instance;
        private List<Student> students = new List<Student>();
       
        public static StudentContainer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentContainer();
                }
                return instance;
            }
        }
        public List<Student> GetSortedList()
        {
            return Sort(students);
        }

        public void AddToList(Student stud)
        {
            students.Add(stud);
        }

        public List<Student> Sort(List<Student> stud)
        {
            return stud.OrderBy(x => x.LastName).ToList();
        }
        
    }
}
