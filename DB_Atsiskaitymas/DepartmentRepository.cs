using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace DB_Atsiskaitymas
{
    public static class DepartmentRepository
    {       
        public static void CreatingADepartment(string name)
        {
            var departmentFound = false;
            using var studentContext = new StudentContext();
            var allStudents = studentContext.Students.ToList();
            var allDepartments = studentContext.Departments.ToList();
            var allLectures = studentContext.Lectures.ToList();
            foreach (var department in allDepartments)
            {
                if(department.Name == name)
                {
                    Console.WriteLine("That department already exists in the database.");
                    Console.ReadLine();
                    departmentFound = true;
                    break;
                }                 
            }
            if (!departmentFound)
            {
                var newDepartment = new Department(name);
                if (allLectures.Count() > 0)
                {
                    foreach (var item in allLectures)
                    {
                        Console.Clear();
                        Console.WriteLine($"Do you want to add the lecture {item.Name} to this department?       (Y/N)");
                        var answer = Validation.YesOrNo();
                        if (answer == "Y")
                        {
                            newDepartment.Lectures.Add(item);
                            item.Department.Add(newDepartment);
                            continue;
                        }
                    }
                }
                if (allStudents.Count() > 0) 
                { 
                foreach (var student in allStudents)
                {
                    Console.Clear();
                    if (student.Department == default)
                    {
                        Console.WriteLine($"Do you want to add {student.Name} {student.Surname} to this department?     (Y/N)");
                        var answer = Validation.YesOrNo();
                        if (answer == "Y")
                        {
                            ChangeStudentDepartment(newDepartment, student);
                            continue;
                        }
                    }
                }
            }
                studentContext.Departments.Add(newDepartment);
                studentContext.SaveChanges();
                Console.WriteLine("Department succesfully added.");
                Console.ReadLine();
            }
        }
        public static void ChangeStudentDepartment(Department department, Student student)
        {
            if (department != default && student != default)
            {
                if (student.DepartmentId != department.Id)
                {
                    using var studentContext = new StudentContext();
                    student.Lectures.Clear();
                    student.Lectures.AddRange(department.Lectures);
                    student.DepartmentId = department.Id;
                    student.Department = department;
                    Console.WriteLine($"{student.Name} succesfully added to {department.Name}");
                    studentContext.SaveChanges();
                }
                else
                {
                    Console.WriteLine("This student is already in this department.");
                }
            }
            else if(department == default)
            {
                Console.WriteLine("There is no department with that name.");
            }
            else
            {
                Console.WriteLine("There is no such student in the database.");
            }
        }
        public static void ShowAllStudentsOfADepartment(string name)
        {
            using var studentContext = new StudentContext();
            var department = studentContext.Departments
                .Include(x => x.Students)
                .FirstOrDefault(x => x.Name == name);
            var studentsOfDepartment = department.Students.ToList();
            Console.Clear();
            if (department != default && studentsOfDepartment.Count() > 0) 
            {
                Console.WriteLine("Students in this department: ");
                foreach (var student in studentsOfDepartment)
                {
                    Console.WriteLine($"{student.Name}");
                }
                Console.ReadLine();
            }
            else if(department == default)
            {
                Console.WriteLine("There is no department with that name.");
                Console.ReadLine();
            }
            else if(department.Students.Count() < 1)
            {
                Console.WriteLine("There are no students in this department.");
                Console.ReadLine();
            }
        }

        public static void ShowAllLecturesOfADepartment(string name)
        {
            using var studentContext = new StudentContext();
            var department = studentContext.Departments
                .Include(x => x.Lectures)
                .FirstOrDefault(x => x.Name == name);
            var lecturesOfDepartment = department.Lectures.ToList();
            Console.Clear();
            if (department != default && lecturesOfDepartment.Count() > 0)
            {
                Console.WriteLine("Lectures in this department: ");
                foreach (var lectures in lecturesOfDepartment)
                {
                    Console.WriteLine($"{lectures.Name}");
                }
                Console.ReadLine();
            }
            else if(department == default)
            {
                Console.WriteLine("There is no department with that name.");
                Console.ReadLine();
            }
            else if(department.Lectures.Count() < 1)
            {
                Console.WriteLine("There are no lectures in this department");
                Console.ReadLine();
            }
        }

        public static Department FindDepartmentByName()
        {
            Console.Clear();
            using var studentContext = new StudentContext();
            Console.WriteLine("What is the department name? :");
            var department = Console.ReadLine().Trim().ToUpper();
            var foundDepartment = studentContext.Departments
                .Include(x => x.Lectures)
                .Include(x => x.Students)
                .FirstOrDefault(x => x.Name.ToUpper() == department);
            if (foundDepartment != default)
            {
                return foundDepartment;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("There is no department with that name.");
                Console.ReadLine();
            }
            return default;
        }

        public static void AddLectureToDepartment()
        {
            using var studentContext = new StudentContext();
            var department = FindDepartmentByName();
            if(department != default)
            {
                var lecture = LectureRepository.FindLectureByName();
                if(lecture != default)
                {
                    department.Lectures.Add(lecture);
                    studentContext.SaveChanges();
                }
            }
            
        }

        public static void AddStudentWithNoDepartmentToDepartment()
        {
            using var studentContext = new StudentContext();
            var allStudentsWithNoDepartment = studentContext.Students.Where(x => x.DepartmentId == null)
                .ToList();
            if (allStudentsWithNoDepartment.Count() > 0)
            {
                Console.WriteLine("What is the department you wish to add students into?");
                var choice = Console.ReadLine().Trim().ToUpper();
                var department = studentContext.Departments
                    .Include(x => x.Lectures)
                    .FirstOrDefault(x => x.Name.ToUpper() == choice); 
                if(department != default) 
                {
                    foreach (var student in allStudentsWithNoDepartment)
                    {
                        Console.WriteLine($"Do you want to add {student.Name} to the {department.Name}?     (Y/N)");
                        var answer = Validation.YesOrNo();
                        if (answer == "Y")
                        {
                            student.DepartmentId = department.Id;
                            student.Lectures = department.Lectures;
                        }
                        else if (answer == "N")
                        {
                            continue;
                        }
                        else if (answer == "0")
                        {
                            break;
                        }
                    }
                    studentContext.SaveChanges();
                }
                else
                {
                    Console.WriteLine("There is no department with that name.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("There are no students without a department. Try changing the department of existing students.");
            }
        }
        }
    }

