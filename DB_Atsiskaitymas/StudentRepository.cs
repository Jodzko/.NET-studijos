namespace DB_Atsiskaitymas
{
    public static class StudentRepository
    {
        public static void CreatingAStudent(string name, string surname)
        {
            Console.Clear();
            var newStudent = new Student(name, surname);
            using var studentContext = new StudentContext();
            var foundStudent = studentContext.Students.FirstOrDefault(x => x.Name == name && x.Surname == surname);
            if(foundStudent == default)
            {
                foreach (var item in studentContext.Departments)
                {
                        Console.Clear();  
                        Console.WriteLine($"Do you want to add {newStudent.Name} to the {item.Name} department?");
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
                        foreach (var item in studentContext.Departments)
                        {
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
                var studentInDatabase = studentContext.Students.FirstOrDefault(x => student.Id == x.Id);
                Console.WriteLine("The lectures that this student is attending: ");
                foreach (var item in studentInDatabase.Lectures)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                Console.WriteLine("That student is not in the database.");
            }
        }

        public static Student FindStudentInDatabase(string name, string surname)
        {
            using var studentContext = new StudentContext();
            var student = studentContext.Students.FirstOrDefault(x => x.Name == name && x.Surname == surname);
            if(student == default)
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
}
