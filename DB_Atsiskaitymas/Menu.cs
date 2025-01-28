namespace DB_Atsiskaitymas
{
    public class Menu
    {
        public static void OpenMenu()
        {
            using var studentContext = new StudentContext();
            var allStudents = studentContext.Students.ToList();
            var allDepartments = studentContext.Departments.ToList();
            var allLectures = studentContext.Lectures.ToList();
            var menuQuit = false;
            while (!menuQuit)
            {
                Console.Clear();
                Console.WriteLine("Choose what you would like to do: ");
                Console.WriteLine("1. Create a department.");
                Console.WriteLine("2. Add a student to a department");
                Console.WriteLine("3. Change the department of a student.");
                Console.WriteLine("4. Create a lecture.");
                Console.WriteLine("5. Add a lecture to a department.");
                Console.WriteLine("6. Create a student");
                Console.WriteLine("7. Show all lectures of a department.");
                Console.WriteLine("8. Show all students of a department.");
                Console.WriteLine("9. Show all lectures of a student.");
                Console.WriteLine("10. Exit menu");
                var choice = Validation.MenuInput();
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("What is the department name? : ");
                        var department = Console.ReadLine().Trim();
                        if (department != "0")
                        {
                            DepartmentRepository.CreatingADepartment(department);
                        }
                        else
                        {
                            break;
                        }
                        GoBackToMenu(out menuQuit);
                        break;
                    case 2:
                        Console.Clear();
                        if (allStudents.Count() > 0 && allDepartments.Count() > 0)
                        {
                            DepartmentRepository.AddStudentWithNoDepartmentToDepartment();
                        }
                        else
                        {
                            Console.WriteLine("There is no student or department.");
                            Console.ReadLine();
                        }
                        GoBackToMenu(out menuQuit);
                        break;
                    case 3:
                        Console.Clear();
                        if (allStudents.Count() > 0 && allDepartments.Count() > 0)
                        {
                            var student = StudentRepository.FindStudentByNameOrId();
                            if(student == null)
                            {
                                break;
                            }
                            else if(student != default)
                            {
                                var foundDepartment = DepartmentRepository.FindDepartmentByName();
                                if(foundDepartment == null)
                                {
                                    break;
                                }
                                else if(foundDepartment != default)
                                {
                                    DepartmentRepository.ChangeStudentDepartment(foundDepartment, student);
                                    studentContext.SaveChanges();
                                }
                            }                                                     
                        }
                        else
                        {
                            Console.WriteLine("There is no student or department.");
                            Console.ReadLine();
                        }
                        GoBackToMenu(out menuQuit);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("What is the name of the lecture you want to create? :");
                        var lecture = Console.ReadLine().Trim();
                        if (lecture != "0")
                        {
                            LectureRepository.CreatingALecture(lecture);
                        }
                        else
                        {
                            break;
                        }
                        GoBackToMenu(out menuQuit);
                        break;
                    case 5:
                        Console.Clear();
                        if (allLectures.Count() > 0 && allDepartments.Count() > 0)
                        {
                            DepartmentRepository.AddLectureToDepartment();
                        }
                        else if (allLectures.Count() < 1)
                        {
                            Console.WriteLine("There are no lectures in the database.");
                        }
                        else if (allDepartments.Count() < 1)
                        {
                            Console.WriteLine("There are no departments in the database.");
                        }
                        GoBackToMenu(out menuQuit);
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("What is the name of the student? :");
                        var name = Console.ReadLine().Trim();
                        Console.WriteLine("What is the surname of the student? :");
                        var surname = Console.ReadLine().Trim();
                        if (name != "0" && surname != "0")
                        {
                            StudentRepository.CreatingAStudent(name, surname);
                        }
                        else
                        {
                            break;
                        }
                        GoBackToMenu(out menuQuit);
                        break;
                    case 7:
                        Console.Clear();                       
                        if (allDepartments.Count() > 0)
                        {
                            Console.WriteLine("What is the name of the department?");
                            department = Console.ReadLine().Trim();
                            if (department != "0")
                            {
                                DepartmentRepository.ShowAllLecturesOfADepartment(department);
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("There are no departments in the database.");
                            Console.ReadLine();
                        }
                        GoBackToMenu(out menuQuit);
                        break;
                    case 8:
                        Console.Clear();
                        if (allDepartments.Count() > 0)
                        {
                            Console.WriteLine("What is the name of the department?");
                            department = Console.ReadLine().Trim();
                            if (department != "0")
                            {
                                DepartmentRepository.ShowAllStudentsOfADepartment(department);
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("There are no departments in the database.");
                            Console.ReadLine();
                        }
                        GoBackToMenu(out menuQuit);
                        break;
                    case 9:
                        Console.Clear();
                        if (allStudents.Count() > 0)
                        {
                            var student = StudentRepository.FindStudentByNameOrId();
                            if (student != default)
                            {
                                StudentRepository.ShowAllLecturesOfStudent(student);
                            }
                        }
                        else
                        {
                            Console.WriteLine("There are no students in the database.");
                            Console.ReadLine();
                        }
                        GoBackToMenu(out menuQuit);
                        break;
                    case 10:
                        menuQuit = true;
                        break;
                }
            }
        }

        public static void GoBackToMenu(out bool menuQuit)
        {
            Console.WriteLine("Do you want to go back to the menu?      (Y/N)");
            var answer = Validation.YesOrNo();
            if(answer == "Y")
            {
                menuQuit = false;
            }
            else
            {
                menuQuit = true;
            }
        }
    }

}
