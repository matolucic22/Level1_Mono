using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Code
{
    public class DedicatedValidation
    {
        
        public double result;
        public void checkString(string str)
        {
            
            if(String.IsNullOrEmpty(str))
            {
                Console.WriteLine("Ne možete unijeti prznu vrijednost");
                
                
            }
            
        }
        public void checkGPA(double gpa)
        {
            if(gpa>5||gpa<1)
            {
                Console.WriteLine("Unesite vrijednost broja između 1 i 5");
                
            }
        }
        
    }
}
