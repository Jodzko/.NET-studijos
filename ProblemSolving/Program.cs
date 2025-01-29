
using DB_Atsiskaitymas;
using Microsoft.EntityFrameworkCore;

var studentContext = new StudentContext();
//studentContext.Departments.Add(new Department("NewDepartment"));
//studentContext.Departments.Add(new Department("AnotherDepartment"));
//studentContext.Students.Add(new Student("Tomas", "Tomaitis"));
//studentContext.Lectures.Add(new Lecture("Biology"));
//studentContext.Lectures.Add(new Lecture("Physics"));
//studentContext.Lectures.Add(new Lecture("Math"));
var Tomas = studentContext.Students
    .Include(x => x.Lectures)
    .FirstOrDefault(x => x.Name == "Tomas");
var department = studentContext.Departments
    .Include(x => x.Lectures)
    .FirstOrDefault(x => x.Name == "NewDepartment");
var otherDepartment = studentContext.Departments
    .Include(x => x.Lectures)
    .FirstOrDefault(x => x.Name == "AnotherDepartment");

//otherDepartment.Lectures.Add(studentContext.Lectures.FirstOrDefault(x => x.Name == "Biology"));
//otherDepartment.Lectures.Add(studentContext.Lectures.FirstOrDefault(x => x.Name == "Physics"));
//otherDepartment.Lectures.Add(studentContext.Lectures.FirstOrDefault(x => x.Name == "Math"));

Tomas.Department = department;
//Tomas.Department = otherDepartment;
//Tomas.Lectures.RemoveAll(x => x.Id != null);
//Tomas.Lectures = otherDepartment.Lectures;
Tomas.Lectures = department.Lectures;


//department.Lectures.Add(studentContext.Lectures.FirstOrDefault(x => x.Name == "Biology"));
//Tomas.Lectures = department.Lectures;
studentContext.SaveChanges();

