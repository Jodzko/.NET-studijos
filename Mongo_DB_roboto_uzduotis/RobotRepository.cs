using MongoDB.Driver;
using static System.Reflection.Metadata.BlobBuilder;

namespace Mongo_DB_roboto_uzduotis
{
    public class RobotRepository
    {
        public MongoClient client = new MongoClient("mongodb+srv://ajodzko:zQjt7CiMAEAPw1gv@cluster0.7govy.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
        public List<Robot> Robots { get; set; }
        public RobotRepository()
        {
            Robots = new List<Robot>();
        }

        public void AddRobotToRepository(Robot robot)
        {
            var robotCollection = client.GetDatabase("RobotRepository").GetCollection<Robot>("robotRepository");
            robotCollection.InsertOne(robot);
        }

        public void AddRobotListToRepository()
        {
            var robotCollection = client.GetDatabase("RobotRepository").GetCollection<Robot>("robotRepository");
            robotCollection.InsertMany(Robots);
        }
        public Robot FindRobotById(int id)
        {
            var robotCollection = client.GetDatabase("RobotRepository").GetCollection<Robot>("robotRepository");
            var filter = Builders<Robot>.Filter.Eq("_id", id);
            var result = robotCollection.Find(filter).FirstOrDefault();
            return result;
        }

        public void FindRobotsByHeadShape(int headEnum)
        {
            var robotCollection = client.GetDatabase("RobotRepository").GetCollection<Robot>("robotRepository");
            var filter = Builders<Robot>.Filter.Eq("Head", headEnum);
            var result = robotCollection.Find(filter).ToList();
          
        }

        public void DeleteRobotById(int id)
        {
            var robotCollection = client.GetDatabase("RobotRepository").GetCollection<Robot>("robotRepository");
            var filter = Builders<Robot>.Filter.Eq("_id", id);
            robotCollection.DeleteOne(filter);
        }


        public void UpdateRobotRepository(Robot robot)
        {
            var robotCollection = client.GetDatabase("RobotRepository").GetCollection<Robot>("robotRepository");
            var filter = Builders<Robot>.Filter.Eq(x => x.Id, robot.Id);
            var update = Builders<Robot>.Update
                .Set(r => r.Head, robot.Head)
                .Set(r => r.Arms, robot.Arms)
                .Set(r => r.Legs, robot.Legs)
                .Set(r => r.Torso, robot.Torso)
                .Set(r => r.TestProperty, "Testing");
            var result = robotCollection.UpdateOne(filter, update);
            FindRobotById(2);

        }

        public void UpdateRobotRepositoryTest(Robot robot)
        {
            var robotCollection = client.GetDatabase("RobotRepository").GetCollection<Robot>("robotRepository");
            var filter = Builders<Robot>.Filter.Eq(x => x.Id, robot.Id);
            robotCollection.ReplaceOne(filter, robot);

        }
    }
}
