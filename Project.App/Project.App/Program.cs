using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Code;

namespace Project.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Stud = new Student();

            StudentIdGenerator SIG = StudentIdGenerator.Instance;
            DedicatedValidation DV = new DedicatedValidation();
                    
            string Ime, Prezime;
            string Unos1;
            double GPA;
            bool ListFlag = true;
            do
            {
                Console.WriteLine("Unesite 'enlist' za stvaranje liste, a 'display' za ispis.");
                Unos1 = Console.ReadLine();
                if (string.Equals(Unos1, Operations.ENLIST, StringComparison.CurrentCultureIgnoreCase))
                {
                    do
                    {
                        Console.WriteLine("Uesite ime:");
                        Ime = Console.ReadLine();
                        DV.checkString(Ime);
                    }
                    while (string.IsNullOrEmpty(Ime) == true);
                    Stud.Name = Ime;

                    do
                    {
                        Console.WriteLine("Uesite prezime:");
                        Prezime = Console.ReadLine();
                        DV.checkString(Prezime);
                    }
                    while (string.IsNullOrEmpty(Prezime) == true);
                    Stud.LastName = Prezime;

                    do
                    {
                        Console.WriteLine("Uesite GPA:");
                        GPA = double.Parse(Console.ReadLine());
                        DV.checkGPA(GPA);
                        Stud.GPA = GPA;

                    } while (GPA > 5 || GPA < 1);
                    Stud.ID = SIG.nextId();

                }
                else if (string.Equals(Unos1, Operations.DISPLAY, StringComparison.CurrentCultureIgnoreCase))
                {
                    for (int i = 0; i < Stud.; i++)
                    {
                        Console.WriteLine(Stud[i].ID + "." + Stud.LastName + ", " + Stud.Name + " - " + Stud.GPA);
                    }
                    ListFlag = false;
                }

                else
                {
                    Console.WriteLine("Nepostojeća opcija.");
                }
            } while (ListFlag == true);
        }
    }
}
