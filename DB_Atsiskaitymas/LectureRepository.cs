namespace DB_Atsiskaitymas
{
    public static class LectureRepository
    {
        public static void CreatingALecture(string name)
        {
            using var studentContext = new StudentContext();
            var foundLecture = studentContext.Lectures.FirstOrDefault(x => x.Name == name);
            if(foundLecture == default)
            {
                var newLecture = new Lecture(name);
                foreach (var item in studentContext.Departments)
                {

                    if (studentContext.Lectures.Count() > 0)
                    {
                        Console.Clear();
                        Console.WriteLine($"Do you want to add the {name} lecture to the {item.Name} department?      (Y/N)");
                        var answer = Validation.YesOrNo();
                        if (answer == "Y")
                        {
                            item.Lectures.Add(newLecture);
                            newLecture.Departments.Add(item);
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
    }
}
