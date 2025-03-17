using Kartojimas_su_Laimonu.Entities;
using Kartojimas_su_Laimonu.Repositories;
using Microsoft.EntityFrameworkCore;

var dbContext = new GenericDbContext();
var orderRepository = new OrderRepository(dbContext);
var orderItemRepository = new OrderItemRepository(dbContext);
var studentRepository = new StudentRepository(dbContext);

//orderRepository.Save(new Order());
//orderRepository.Find(x => x.DateCreated == new DateTime());
//orderItemRepository.GetAll();
//orderItemRepository.GetById(1);

//var newStudent = new Student("Jonas", "Jonauskas");
//studentRepository.Save(newStudent);
//var allStudents = studentRepository.GetAll();
//foreach (var item in allStudents)
//{
//    Console.WriteLine(item.Name);
//}