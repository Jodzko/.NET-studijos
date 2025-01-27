using System.Xml.Linq;

namespace DB_Atsiskaitymas
{
    public static class DepartmentRepository
    {       
        public static void CreatingADepartment(string name)
        {
            var departmentFound = false;
            using var studentContext = new StudentContext();
            foreach (var department in studentContext.Departments)
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
                foreach (var item in studentContext.Lectures)
                {
                        Console.Clear();
                        Console.WriteLine($"Do you want to add the lecture {item.Name} to this department?       (Y/N)");
                        var answer = Validation.YesOrNo();
                        if (answer == "Y")
                        {
                            newDepartment.Lectures.Add(item);
                            item.Departments.Add(newDepartment);
                            continue;
                        }                  
                }
                foreach (var student in studentContext.Students)
                {
                    Console.Clear();
                    if (student.Department == default)
                    {
                        Console.WriteLine($"Do you want to add {student.Name} {student.Surname} to this department?     (Y/N)");
                        var answer = Validation.YesOrNo();
                        if(answer == "Y")
                        {
                            ChangeStudentDepartment(newDepartment, student);
                            continue;
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
            using var studentContext = new StudentContext();
            student.Department = department;
            student.DepartmentId = department.Id;
            studentContext.Update(student);
            studentContext.SaveChanges();
        }
        public static void ShowAllStudentsOfADepartment(string name)
        {
            using var studentContext = new StudentContext();
            var department = studentContext.Departments.FirstOrDefault(x => x.Name == name);
            Console.Clear();
            if (department != default) 
            {
                Console.WriteLine("Students in this department: ");
                foreach (var student in department.Students)
                {
                    Console.WriteLine($"{student.Name}");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("There is no department with that name.");
                Console.ReadLine();
            }
        }

        public static void ShowAllLecturesOfADepartment(string name)
        {
            using var studentContext = new StudentContext();
            var department = studentContext.Departments.FirstOrDefault(x => x.Name == name);
            Console.Clear();
            if (department != default)
            {
                Console.WriteLine("Lectures in this department: ");
                foreach (var lectures in department.Lectures)
                {
                    Console.WriteLine($"{lectures.Name}");
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("There is no department with that name.");
            }
        }
    }
}
