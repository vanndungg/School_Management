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
                Console.WriteLine("Please choose:");
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
                Console.WriteLine("6. Back to main menu");
                Console.WriteLine("===========================================================");
                Console.WriteLine("Please choose:");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        ViewStudents();
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
            string stdId = Console.ReadLine();
            Console.WriteLine("Enter student name: ");
            string stdName = Console.ReadLine();
            Console.WriteLine("Enter student date of birth: ");
            string stdDoB = Console.ReadLine();
            Console.WriteLine("Enter student email: ");
            string stdEmail = Console.ReadLine();
            Console.WriteLine("Enter student address: ");
            string stdAddress = Console.ReadLine();
            Console.WriteLine("Enter student class: ");
            string stdClass = Console.ReadLine();

            Student student = new Student(stdId, stdName, stdDoB, stdEmail, stdAddress, stdClass);
            students.Add(student);
            Console.WriteLine("Student added successfully.");
        }

        static void ViewStudents()
        {
            Console.WriteLine("List of Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.stdId} | {student.stdName} | {student.stdDoB} | {student.stdEmail} | {student.stdAddress} | {student.stdClass}");
            }
        }

        static void SearchStudents()
        {
            Console.WriteLine("Enter student ID to search: ");
            string searchId = Console.ReadLine();

            Student foundStudent = students.Find(student => student.stdId == searchId);

            if (foundStudent != null)
            {
                Console.WriteLine("Search Results:");
                Console.WriteLine($"{foundStudent.stdId} | {foundStudent.stdName} | {foundStudent.stdDoB} | {foundStudent.stdEmail} | {foundStudent.stdAddress} | {foundStudent.stdClass}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        static void DeleteStudent()
        {
            Console.WriteLine("Enter student ID to delete: ");
            string stdId = Console.ReadLine();
            Student studentToDelete = students.Find(s => s.stdId == stdId);

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
            string stdId = Console.ReadLine();
            Student studentToUpdate = students.Find(s => s.stdId == stdId);

            if (studentToUpdate != null)
            {
                Console.WriteLine("Current student data:");
                Console.WriteLine($"Student ID: {studentToUpdate.stdId}");
                Console.WriteLine($"Name: {studentToUpdate.stdName}");
                Console.WriteLine($"Date of Birth: {studentToUpdate.stdDoB}");
                Console.WriteLine($"Email: {studentToUpdate.stdEmail}");
                Console.WriteLine($"Address: {studentToUpdate.stdAddress}");
                Console.WriteLine($"Class: {studentToUpdate.stdClass}");

                Console.WriteLine("Enter new data (or press Enter to keep current data):");
                Console.WriteLine("Enter student name: ");
                string stdName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(stdName))
                    studentToUpdate.stdName = stdName;

                Console.WriteLine("Enter student date of birth: ");
                string stdDoB = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(stdDoB))
                    studentToUpdate.stdDoB = stdDoB;

                Console.WriteLine("Enter student email: ");
                string stdEmail = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(stdEmail))
                    studentToUpdate.stdEmail = stdEmail;

                Console.WriteLine("Enter student address: ");
                string stdAddress = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(stdAddress))
                    studentToUpdate.stdAddress = stdAddress;

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
                Console.WriteLine("6. Back to main menu");
                Console.WriteLine("===========================================================");
                Console.WriteLine("Please choose:");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddLecturer();
                        break;
                    case 2:
                        ViewLecturers();
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
            string lecId = Console.ReadLine();
            Console.WriteLine("Enter lecturer name: ");
            string lecName = Console.ReadLine();
            Console.WriteLine("Enter lecturer date of birth: ");
            string lecDoB = Console.ReadLine();
            Console.WriteLine("Enter lecturer email: ");
            string lecEmail = Console.ReadLine();
            Console.WriteLine("Enter lecturer address: ");
            string lecAddress = Console.ReadLine();
            Console.WriteLine("Enter lecturer department: ");
            string lecDept = Console.ReadLine();

            Lecturer lecturer = new Lecturer(lecId, lecName, lecDoB, lecEmail, lecAddress, lecDept);
            lecturers.Add(lecturer);
            Console.WriteLine("Lecturer added successfully.");
        }

        static void ViewLecturers()
        {
            Console.WriteLine("List of Lecturers:");
            foreach (var lecturer in lecturers)
            {
                Console.WriteLine($"{lecturer.lecId} | {lecturer.lecName} | {lecturer.lecDoB} | {lecturer.lecEmail} | {lecturer.lecAddress} | {lecturer.lecDept}");
            }
        }

        static void SearchLecturers()
        {
            Console.WriteLine("Enter lecturer ID to search: ");
            string searchId = Console.ReadLine();

            Lecturer foundLecturer = lecturers.Find(lecturer => lecturer.lecId == searchId);

            if (foundLecturer != null)
            {
                Console.WriteLine("Search Results:");
                Console.WriteLine($"{foundLecturer.lecId} | {foundLecturer.lecName} | {foundLecturer.lecDoB} | {foundLecturer.lecEmail} | {foundLecturer.lecAddress} | {foundLecturer.lecDept}");
            }
            else
            {
                Console.WriteLine("Lecturer not found.");
            }
        }

        static void DeleteLecturer()
        {
            Console.WriteLine("Enter lecturer ID to delete: ");
            string lecId = Console.ReadLine();
            Lecturer lecturerToDelete = lecturers.Find(l => l.lecId == lecId);

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
            string lecId = Console.ReadLine();
            Lecturer lecturerToUpdate = lecturers.Find(l => l.lecId == lecId);

            if (lecturerToUpdate != null)
            {
                Console.WriteLine("Current lecturer data:");
                Console.WriteLine($"Lecturer ID: {lecturerToUpdate.lecId}");
                Console.WriteLine($"Name: {lecturerToUpdate.lecName}");
                Console.WriteLine($"Date of Birth: {lecturerToUpdate.lecDoB}");
                Console.WriteLine($"Email: {lecturerToUpdate.lecEmail}");
                Console.WriteLine($"Address: {lecturerToUpdate.lecAddress}");
                Console.WriteLine($"Department: {lecturerToUpdate.lecDept}");

                Console.WriteLine("Enter new data (or press Enter to keep current data):");
                Console.WriteLine("Enter lecturer name: ");
                string lecName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(lecName))
                    lecturerToUpdate.lecName = lecName;

                Console.WriteLine("Enter lecturer date of birth: ");
                string lecDoB = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(lecDoB))
                    lecturerToUpdate.lecDoB = lecDoB;

                Console.WriteLine("Enter lecturer email: ");
                string lecEmail = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(lecEmail))
                    lecturerToUpdate.lecEmail = lecEmail;

                Console.WriteLine("Enter lecturer address: ");
                string lecAddress = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(lecAddress))
                    lecturerToUpdate.lecAddress = lecAddress;

                Console.WriteLine("Enter lecturer department: ");
                string lecDept = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(lecDept))
                    lecturerToUpdate.lecDept = lecDept;

                Console.WriteLine("Lecturer updated successfully.");
            }
            else
            {
                Console.WriteLine("Lecturer not found.");
            }
        }
    }
}
