using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management
{
    internal class Program
    {
        static List<Student> students = new List<Student>();
        static List<Lecturer> lecturers = new List<Lecturer>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("===========================================================");
                Console.WriteLine("1. Manage Students");
                Console.WriteLine("2. Manage Lecturers");
                Console.WriteLine("3. Exit");
                Console.WriteLine("===========================================================");
                Console.WriteLine("Please choose:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ManageStudents();
                        break;
                    case 2:
                        ManageLecturers();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void ManageStudents()
        {
            while (true)
            {
                Console.WriteLine("===========================================================");
                Console.WriteLine("Student Management Menu:");
                Console.WriteLine("1. Add new student");
                Console.WriteLine("2. View all students");
                Console.WriteLine("3. Search students");
                Console.WriteLine("4. Delete student");
                Console.WriteLine("5. Update student");
                Console.WriteLine("6. Back to the main menu");
                Console.WriteLine("===========================================================");
                Console.WriteLine("Please choose:");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        View.DisplayStudents(students);
                        break;
                    case 3:
                        SearchStudents();
                        break;
                    case 4:
                        DeleteStudent();
                        break;
                    case 5:
                        UpdateStudent();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Console.WriteLine("Enter student ID: ");
            string Id = Console.ReadLine();
            Console.WriteLine("Enter student name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter student date of birth: ");
            string DateOfBirth = Console.ReadLine();
            Console.WriteLine("Enter student email: ");
            string Email = Console.ReadLine();
            Console.WriteLine("Enter student address: ");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter student class: ");
            string stdClass = Console.ReadLine();

            Student student = new Student(Id, Name, DateOfBirth, Email, Address, stdClass);
            students.Add(student);
            Console.WriteLine("Student added successfully.");
        }

        static void SearchStudents()
        {
            Console.WriteLine("Enter student ID to search: ");
            string searchId = Console.ReadLine();

            Student foundStudent = students.Find(student => student.Id == searchId);

            if (foundStudent != null)
            {
                Console.WriteLine("Search Results:");
                Console.WriteLine($"{foundStudent.Id} | {foundStudent.Name} | {foundStudent.DateOfBirth} | {foundStudent.Email} | {foundStudent.Address} | {foundStudent.stdClass}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        static void DeleteStudent()
        {
            Console.WriteLine("Enter student ID to delete: ");
            string Id = Console.ReadLine();
            Student studentToDelete = students.Find(s => s.Id == Id);

            if (studentToDelete != null)
            {
                students.Remove(studentToDelete);
                Console.WriteLine("Student deleted successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        static void UpdateStudent()
        {
            Console.WriteLine("Enter student ID to update: ");
            string Id = Console.ReadLine();
            Student studentToUpdate = students.Find(s => s.Id == Id);

            if (studentToUpdate != null)
            {
                Console.WriteLine("===========================================================");
                Console.WriteLine("Current student data:");
                Console.WriteLine($"Student ID: {studentToUpdate.Id}");
                Console.WriteLine($"Name: {studentToUpdate.Name}");
                Console.WriteLine($"Date of Birth: {studentToUpdate.DateOfBirth}");
                Console.WriteLine($"Email: {studentToUpdate.Email}");
                Console.WriteLine($"Address: {studentToUpdate.Address}");
                Console.WriteLine($"Class: {studentToUpdate.stdClass}");
                Console.WriteLine("===========================================================");

                Console.WriteLine("Enter new data (or press Enter to keep current data):");
                Console.WriteLine("Enter student name: ");
                string Name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Name))
                    studentToUpdate.Name = Name;

                Console.WriteLine("Enter student date of birth: ");
                string DateOfBirth = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(DateOfBirth))
                    studentToUpdate.DateOfBirth = DateOfBirth;

                Console.WriteLine("Enter student email: ");
                string Email = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Email))
                    studentToUpdate.Email = Email;

                Console.WriteLine("Enter student address: ");
                string Address = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Address))
                    studentToUpdate.Address = Address;

                Console.WriteLine("Enter student class: ");
                string stdClass = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(stdClass))
                    studentToUpdate.stdClass = stdClass;

                Console.WriteLine("Student updated successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        static void ManageLecturers()
        {
            while (true)
            {
                Console.WriteLine("===========================================================");
                Console.WriteLine("Lecturer Management Menu:");
                Console.WriteLine("1. Add new lecturer");
                Console.WriteLine("2. View all lecturers");
                Console.WriteLine("3. Search lecturers");
                Console.WriteLine("4. Delete lecturer");
                Console.WriteLine("5. Update lecturer");
                Console.WriteLine("6. Back to the main menu");
                Console.WriteLine("===========================================================");
                Console.WriteLine("Please choose:");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddLecturer();
                        break;
                    case 2:
                        View.DisplayLecturers(lecturers);
                        break;
                    case 3:
                        SearchLecturers();
                        break;
                    case 4:
                        DeleteLecturer();
                        break;
                    case 5:
                        UpdateLecturer();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddLecturer()
        {
            Console.WriteLine("Enter lecturer ID: ");
            string Id = Console.ReadLine();
            Console.WriteLine("Enter lecturer name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter lecturer date of birth: ");
            string DateOfBirth = Console.ReadLine();
            Console.WriteLine("Enter lecturer email: ");
            string Email = Console.ReadLine();
            Console.WriteLine("Enter lecturer address: ");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter lecturer department: ");
            string lecDept = Console.ReadLine();

            Lecturer lecturer = new Lecturer(Id, Name, DateOfBirth, Email, Address, lecDept);
            lecturers.Add(lecturer);
            Console.WriteLine("Lecturer added successfully.");
        }

        static void SearchLecturers()
        {
            Console.WriteLine("Enter lecturer ID to search: ");
            string searchId = Console.ReadLine();

            Lecturer foundLecturer = lecturers.Find(lecturer => lecturer.Id == searchId);

            if (foundLecturer != null)
            {
                Console.WriteLine("Search Results:");
                Console.WriteLine($"{foundLecturer.Id} | {foundLecturer.Name} | {foundLecturer.DateOfBirth} | {foundLecturer.Email} | {foundLecturer.Address} | {foundLecturer.Department}");
            }
            else
            {
                Console.WriteLine("Lecturer not found.");
            }
        }

        static void DeleteLecturer()
        {
            Console.WriteLine("Enter lecturer ID to delete: ");
            string Id = Console.ReadLine();
            Lecturer lecturerToDelete = lecturers.Find(l => l.Id == Id);

            if (lecturerToDelete != null)
            {
                lecturers.Remove(lecturerToDelete);
                Console.WriteLine("Lecturer deleted successfully.");
            }
            else
            {
                Console.WriteLine("Lecturer not found.");
            }
        }

        static void UpdateLecturer()
        {
            Console.WriteLine("Enter lecturer ID to update: ");
            string Id = Console.ReadLine();
            Lecturer lecturerToUpdate = lecturers.Find(l => l.Id == Id);

            if (lecturerToUpdate != null)
            {
                Console.WriteLine("===========================================================");
                Console.WriteLine("Current lecturer data:");
                Console.WriteLine($"Lecturer ID: {lecturerToUpdate.Id}");
                Console.WriteLine($"Name: {lecturerToUpdate.Name}");
                Console.WriteLine($"Date of Birth: {lecturerToUpdate.DateOfBirth}");
                Console.WriteLine($"Email: {lecturerToUpdate.Email}");
                Console.WriteLine($"Address: {lecturerToUpdate.Address}");
                Console.WriteLine($"Department: {lecturerToUpdate.Department}");
                Console.WriteLine("===========================================================");

                Console.WriteLine("Enter new data (or press Enter to keep current data):");
                Console.WriteLine("Enter lecturer name: ");
                string Name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Name))
                    lecturerToUpdate.Name = Name;

                Console.WriteLine("Enter lecturer date of birth: ");
                string DateOfBirth = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(DateOfBirth))
                    lecturerToUpdate.DateOfBirth = DateOfBirth;

                Console.WriteLine("Enter lecturer email: ");
                string Email = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Email))
                    lecturerToUpdate.Email = Email;

                Console.WriteLine("Enter lecturer address: ");
                string Address = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Address))
                    lecturerToUpdate.Address = Address;

                Console.WriteLine("Enter lecturer department: ");
                string lecDept = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(lecDept))
                    lecturerToUpdate.Department = lecDept;

                Console.WriteLine("Lecturer updated successfully.");
            }
            else
            {
                Console.WriteLine("Lecturer not found.");
            }
        }
    }
}
