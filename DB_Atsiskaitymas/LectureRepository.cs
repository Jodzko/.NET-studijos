namespace DB_Atsiskaitymas
{
    public static class LectureRepository
    {
        public static void CreatingALecture(string name)
        {
            Console.Clear();
            using var studentContext = new StudentContext();
            var foundLecture = studentContext.Lectures.FirstOrDefault(x => x.Name == name);
            var allDepartments = studentContext.Departments.ToList();
            var allLectures = studentContext.Lectures.ToList();
            if(foundLecture == default)
            {
                var newLecture = new Lecture(name);
                foreach (var item in allDepartments)
                {

                    if (allLectures.Count() > 0)
                    {
                        Console.Clear();
                        Console.WriteLine($"Do you want to add the {name} lecture to the {item.Name} department?      (Y/N)");
                        var answer = Validation.YesOrNo();
                        if (answer == "Y")
                        {
                            item.Lectures.Add(newLecture);
                            newLecture.Department.Add(item);
                            Console.WriteLine("Lecture added succesfully.");
                            continue;
                        }
                    }
                }
                studentContext.Lectures.Add(newLecture);
                studentContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("This lecture already exists in the database.");
                Console.ReadLine();
            }
        }

        public static Lecture FindLectureByName()
        {
            Console.Clear();
            using var studentContext = new StudentContext();
            Console.WriteLine("What is the name of the Lecture? : ");
            var input = Console.ReadLine().Trim().ToUpper();
            var lecture = studentContext.Lectures.FirstOrDefault(x => x.Name == input);
            if(lecture == default)
            {
                Console.WriteLine("There is no lecture with that name.");
                Console.WriteLine();
                return default;
            }
            else
            {
                return lecture;
            }
        }
    }
}
