using Microsoft.EntityFrameworkCore;

namespace DB_Atsiskaitymas
{
    public class LectureRepository
    {
        StudentContext studentContext { get; set; }
        public LectureRepository(StudentContext context)
        {
            studentContext = context;
        }
        public void CreatingALecture(string name)
        {
            Console.Clear();
            var foundLecture = studentContext.Lectures.FirstOrDefault(x => x.Name == name);
            var allDepartments = studentContext.Departments.ToList();
            if (foundLecture == default)
            {
                var newLecture = new Lecture(name);
                studentContext.Lectures.Add(newLecture);
                foreach (var item in allDepartments)
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
                studentContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("This lecture already exists in the database.");
                Console.ReadLine();
            }
        }

        public Lecture FindLectureByName()
        {
            Console.Clear();
            Console.WriteLine("What is the name of the Lecture? : ");
            var input = Console.ReadLine().Trim().ToUpper();
            var lecture = studentContext.Lectures
                .Include(x => x.Department)
                .FirstOrDefault(x => x.Name == input);
            if (lecture == default)
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

        public List<Lecture> GetAllLectures()
        {
            return studentContext.Lectures.ToList();
        }

        public void ShowAllLectures()
        {
            Console.Clear();
            var allLectures = GetAllLectures();
            if (allLectures.Count() == 0)
            {
                Console.WriteLine("There are no lectures in the database.");
            }
            else
            {
                Console.WriteLine("All the lectures in the database: ");
                foreach (var lecture in allLectures)
                {
                    Console.WriteLine(lecture.Name);
                }
            }
        }
    }
}
