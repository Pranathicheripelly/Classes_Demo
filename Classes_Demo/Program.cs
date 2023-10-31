using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes_Demo
{
    
        class Program
        {
            static void Main(string[] args)
            {
                runApp();
            }

            static void runApp()
            {
                CClass cClass = new CClass
                {
                    ClassName = "Class-A",
                    Year = 2023
                };

                // Create arrays for subjects, teachers, and students
                Subject[] subjects = new Subject[]
                {
        new Subject { Name = "Mathematics", Credits = 3 },
        new Subject { Name = "Physics", Credits = 4 }
                };

                Teacher[] teachers = new Teacher[]
                {
        new Teacher { Name = "Mr. Smith", Department = "Math Department" },
        new Teacher { Name = "Ms. John", Department = "Physics Department" }
                };

                Student[] students = new Student[]
                {
        new Student { Name = "Nani", Age = 24, RollNumber = "18Q91A0", DateOfBirth = new DateTime(1999, 5, 10) },
        new Student { Name = "Babu", Age = 26, RollNumber = "18Q91a5", DateOfBirth = new DateTime(1996, 8, 15) }
                };

                // Assign arrays to the class
                cClass.Subjects.AddRange(subjects);
                cClass.Teachers.AddRange(teachers);
                cClass.Students.AddRange(students);

                Console.WriteLine("Class Details:");
                Console.WriteLine($"Class Name: {cClass.ClassName}");
                Console.WriteLine($"Year: {cClass.Year}");
                Console.WriteLine("\nSubject Details:");

                foreach (var subject in subjects)
                {
                    Console.WriteLine($"Name: {subject.Name}");
                    Console.WriteLine($"Credits: {subject.Credits}");
                    Console.WriteLine();
                }

                Console.WriteLine("Teacher Details:");

                foreach (var teacher in teachers)
                {
                    Console.WriteLine($"Name: {teacher.Name}");
                    Console.WriteLine($"Department: {teacher.Department}");
                    Console.WriteLine();
                }

                Console.WriteLine("Student Details:");

                foreach (var student in students)
                {
                    Console.WriteLine($"Name: {student.Name}");
                    Console.WriteLine($"Age: {student.Age}");
                    Console.WriteLine($"Roll Number: {student.RollNumber}");
                    Console.WriteLine($"Date of Birth: {student.DateOfBirth.ToShortDateString()}");
                    Console.WriteLine();
                Console.ReadLine();
                }
            }

        }
    }




