using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    internal class DisplayInfo
    {
        public static void DisplayStudents(List<Student> students)
        {
            Console.WriteLine("List of Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id} | {student.Name} | {student.DateOfBirth} | {student.Email} | {student.Address} | {student.stdClass}");
            }
        }

        public static void DisplayLecturers(List<Lecturer> lecturers)
        {
            Console.WriteLine("List of Lecturers:");
            foreach (var lecturer in lecturers)
            {
                Console.WriteLine($"{lecturer.Id} | {lecturer.Name} | {lecturer.DateOfBirth} | {lecturer.Email} | {lecturer.Address} | {lecturer.Department}");
            }
        }
    }
}









