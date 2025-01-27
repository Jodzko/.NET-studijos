namespace DB_Atsiskaitymas
{
    public class Menu
    {
        public static void OpenMenu()
        {
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
                        var answer = Console.ReadLine().Trim();
                        DepartmentRepository.CreatingADepartment(answer);
                        GoBackToMenu(out menuQuit);
                        break;
                    case 2:
                        Console.Clear();

                        GoBackToMenu(out menuQuit);
                        break;
                    case 3:
                        Console.Clear();

                        GoBackToMenu(out menuQuit);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("What is the name of the lecture you want to create? :");
                        var lecture = Console.ReadLine().Trim();
                        LectureRepository.CreatingALecture(lecture);
                        GoBackToMenu(out menuQuit);
                        break;
                    case 5:
                        Console.Clear();

                        GoBackToMenu(out menuQuit);
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("What is the name of the student? :");
                        var name = Console.ReadLine().Trim();
                        Console.WriteLine("What is the surname of the student? :");
                        var surname = Console.ReadLine().Trim();
                        StudentRepository.CreatingAStudent(name, surname);
                        GoBackToMenu(out menuQuit);
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("What is the name of the department?");
                        var department = Console.ReadLine().Trim();
                        DepartmentRepository.ShowAllLecturesOfADepartment(department);
                        GoBackToMenu(out menuQuit);
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("What is the name of the department?");
                        department = Console.ReadLine().Trim();
                        DepartmentRepository.ShowAllStudentsOfADepartment(department);
                        GoBackToMenu(out menuQuit);
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("What is the name of the student? :");
                        name = Console.ReadLine().Trim();
                        Console.WriteLine("What is the surname of the student? :");
                        surname = Console.ReadLine().Trim();
                        var foundStudent = StudentRepository.FindStudentInDatabase(name, surname);
                        if (foundStudent != default)
                        {
                            StudentRepository.ShowAllLecturesOfStudent(foundStudent);
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
