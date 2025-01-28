using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace DB_Atsiskaitymas
{
    public static class StudentRepository
    {
        public static void CreatingAStudent(string name, string surname)
        {
            Console.Clear();
            var newStudent = new Student(name, surname);
            using var studentContext = new StudentContext();
            var foundStudent = studentContext.Students
                .FirstOrDefault(x => x.Name == name && x.Surname == surname);
            var allStudents = studentContext.Students
                .ToList();
            var allDepartments = studentContext.Departments
                .Include(x => x.Lectures)
                .ToList();
            if(foundStudent == default)
            {
                foreach (var item in allDepartments)
                {
                        Console.Clear();  
                        Console.WriteLine($"Do you want to add {newStudent.Name} to the {item.Name} department?     (Y/N)");
                        var answer = Validation.YesOrNo();
                        if(answer == "Y")
                        {
                            newStudent.Department = item;
                            newStudent.DepartmentId = item.Id;
                            newStudent.Lectures = item.Lectures;
                            break;
                        }
                        else if(answer == "N")
                        {
                            newStudent.Department = null;
                            newStudent.DepartmentId = null;
                            newStudent.Lectures = null;
                            continue;
                        }
                }
            }
            else
            {
                    Console.Clear();
                    Console.WriteLine("There is a student with the same credentials in the system, are you sure you want to add a new student?      (Y/N)");
                    var answer = Validation.YesOrNo();                    
                if (answer == "Y")
                    {
                        foreach (var item in allDepartments)
                        {
                                Console.Clear();
                                Console.WriteLine($"Do you want to add {newStudent.Name} to the {item.Name} department?");
                                answer = Validation.YesOrNo();
                                if (answer == "Y")
                                {
                                    newStudent.Department = item;
                                    newStudent.DepartmentId = item.Id;
                                    newStudent.Lectures = item.Lectures;
                                    break;
                                }
                        }
                    }
            }
            studentContext.Students.Add(newStudent);
            studentContext.SaveChanges();
        }
        public static void ShowAllLecturesOfStudent(Student student)
        {
            if (student != default)
            {
                var studentContext = new StudentContext();
                var studentInDatabase = studentContext.Students
                    .Include(x => x.Lectures)
                    .FirstOrDefault(x => student.Id == x.Id);
                Console.WriteLine("The lectures that this student is attending: ");
                var allLecturesOfStudent = studentInDatabase.Lectures.ToList();
                foreach (var item in allLecturesOfStudent)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else if(student == default)
            {
                Console.WriteLine("That student is not in the database.");
            }
            else if(student.Lectures.Count() < 1)
            {
                Console.WriteLine("That student is not attending any lectures.");
            }
        }

        public static Student FindStudentInDatabaseByName(string name, string surname)
        {
            using var studentContext = new StudentContext();
            if (name == "0" || surname == "0")
            {
                return default;
            }
            else
            {
                var student = studentContext.Students
                    .Include(x => x.Lectures)
                    .Include(x => x.Department)
                    .Include(x => x.DepartmentId)
                    .FirstOrDefault(x => x.Name == name && x.Surname == surname);
                if (student == default)
                {
                    Console.WriteLine("This student is not in the database.");
                    return default;
                }
                else
                {
                    return student;
                }
            }
        }

        public static Student FindStudentInDatabaseByID(string studentId)
        {
            using var studentContext = new StudentContext();
            try
            {
                var student = studentContext.Students
                    .Include(x => x.Lectures)
                    .Include(x => x.Department)
                    .Include(x => x.DepartmentId)
                    .FirstOrDefault(x => x.Id.ToString() == studentId);
                if (student == default)
                {
                    Console.WriteLine("This student is not in the database.");
                    return default;
                }
                else
                {
                    return student;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return default;
        }

        public static Student FindStudentByNameOrId()
        {
            var choosing = false;
            while (!choosing)
            {
                Console.Clear();
                Console.WriteLine("Do you want to search the student by name or id?     (name/id)");
                var choice = Console.ReadLine().Trim().ToUpper();
                if (choice == "NAME")
                {
                    Console.WriteLine("What is the students name? :");
                    var name = Console.ReadLine().Trim();
                    Console.WriteLine("What is the surname of the student? :");
                    var surname = Console.ReadLine().Trim();
                    var nameInput = false;
                    return FindStudentInDatabaseByName(name, surname);
                }
                else if (choice == "ID")
                {
                    Console.WriteLine("What is the ID of the student? :");
                    var id = Console.ReadLine().Trim();
                    return FindStudentInDatabaseByID(id);
                }
                else if (choice == "0")
                {
                    choosing = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect input, try again.");
                    Console.ReadLine();
                }
            }
            return default;
        }
    }
}
