using Mongo_DB_roboto_uzduotis;

var Robot1 = new Robot(1);
var parts = FileReader.ReadAllFileLines("Robot1");
var allRobots = new RobotRepository();
//if (parts[0] == "Robot1")
//{
//    Robot1.Arms.Add(new Arm(parts[1], int.Parse(parts[2]), int.Parse(parts[3])));
//    Robot1.Arms.Add(new Arm(parts[4], int.Parse(parts[5]), int.Parse(parts[6])));
//    Robot1.Legs.Add(new Leg(parts[7], int.Parse(parts[8]), int.Parse(parts[9])));
//    Robot1.Legs.Add(new Leg(parts[10], int.Parse(parts[11]), int.Parse(parts[12])));
//    Robot1.Torso = new Torso(int.Parse(parts[13]), int.Parse(parts[14]));
//    Robot1.Head = (Head)int.Parse(parts[15]);
//    allRobots.Robots.Add(Robot1);
//}

//var Robot2 = new Robot(2);
//parts = FileReader.ReadAllFileLines("Robot2");
//if (parts[0] == "Robot2")
//{
//    Robot2.Arms.Add(new Arm(parts[1], int.Parse(parts[2]), int.Parse(parts[3])));
//    Robot2.Arms.Add(new Arm(parts[4], int.Parse(parts[5]), int.Parse(parts[6])));
//    Robot2.Legs.Add(new Leg(parts[7], int.Parse(parts[8]), int.Parse(parts[9])));
//    Robot2.Legs.Add(new Leg(parts[10], int.Parse(parts[11]), int.Parse(parts[12])));
//    Robot2.Torso = new Torso(int.Parse(parts[13]), int.Parse(parts[14]));
//    Robot2.Head = (Head)int.Parse(parts[15]);
//    allRobots.Robots.Add(Robot2);
//}

//var ChangingRobot = new Robot(2);
//ChangingRobot = Robot2;
//ChangingRobot.Arms.Add(new Arm("Wood", 12, 12));

//allRobots.AddRobotListToRepository();
//allRobots.DeleteRobotById(1);
//allRobots.DeleteRobotById(2);
//allRobots.AddRobotToRepository(Robot1);
//allRobots.UpdateRobotRepository(ChangingRobot);
//allRobots.UpdateRobotRepositoryTest(ChangingRobot);
//allRobots.FindRobotsByHeadShape(1);
var robotToSave = allRobots.FindRobotById(1);

FileWriter.WritingToFile(robotToSave);
Console.WriteLine();