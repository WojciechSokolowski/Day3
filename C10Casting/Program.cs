using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C10Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit casting

            Programmer programmer = new Programmer();

            //programmer.TestingAccessor(); internal wisible in this project

            Person person = new Person();

            Person person1 = programmer; // implicit casting form programmer to person

            //explicit casting:
            Person person2 = new Person();
            //Programmer programmer2 = (Programmer)person2;
            //it throws exeption

            //Person person3 = new Person();
            //Person person3 = new Programmer();
            Person person3 = new Doctor();


            if (person3 is Programmer)
            {
                Programmer programmer3 = (Programmer)person3;
            }
            else
            {
                Console.WriteLine("the person object cannot be cast to a programmer");
            }

            Person[] people = new Person[4];

            people[0] = new Programmer { Name="Alice",Age=30, ProgrammingLanguage="C#"};
            people[1] = new Doctor { Name = "Bob", Age = 45, Specialization= "Cardiology" };
            people[2] = new Programmer { Name = "Charlie", Age = 30, ProgrammingLanguage="Python" };
            people[3] = new Doctor { Name = "David", Age = 45, Specialization = "Neurology" };

            foreach(var personx in people)
            {
                Console.WriteLine($"Name: {personx.Name}, Age: {personx.Age}");
            
            if (personx is Programmer)
                {
                    Programmer p = (Programmer)personx;
                    Console.WriteLine($"Programming language: {p.ProgrammingLanguage}");
                }
            else if (personx is Doctor) 
                {
                    Doctor p = (Doctor)personx;
                    Console.WriteLine($"Specializatione: {p.Specialization}");

                }

            }
            Console.ReadKey();
        }
    }
}
