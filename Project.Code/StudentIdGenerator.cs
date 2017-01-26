using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class StudentIdGenerator
    {
        private int Id;
        private static StudentIdGenerator instance;

        private StudentIdGenerator() { Id = 1; }

        public static StudentIdGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentIdGenerator();
                }
                return instance;
            }
        }
        public int nextId()
        {
            return Id++;
        }
    }
}
