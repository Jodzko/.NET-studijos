// Is failu skaitom ir i failus irasome Byte duomenu tipu
using System.Linq.Expressions;

string path = "C:\\Users\\AJodz\\OneDrive\\Documents\\GitHub\\.NET-studijos\\6_paskaita_OOP_Streams\\file.txt";
string newPath = "C:\\Users\\AJodz\\OneDrive\\Documents\\GitHub\\.NET-studijos\\6_paskaita_OOP_Streams\\NewFile.txt";
//string fileContent = File.ReadAllText("C:\\Users\\AJodz\\OneDrive\\Documents\\GitHub\\.NET-studijos\\6_paskaita_OOP_Streams\\file.txt");//ReadAllText grazina string


//string[] fileContentLine = File.ReadAllLines("C:\\Users\\AJodz\\OneDrive\\Documents\\GitHub\\.NET-studijos\\6_paskaita_OOP_Streams\\file.txt");//ReadAllLines Grazina string array

//var fileContentLinesFast = File.ReadLines(path);
////foreach (var line in fileContentLinesFast)
////{
////    Console.WriteLine(line);
////}


//var dir = new DirectoryInfo(path);
//Console.WriteLine();
//DirectoryInfo[] dirs = new DirectoryInfo(path).GetDirectories();
//using (var writer = new StreamWriter(path))
//{
//	foreach (var dire in dirs)
//	{
//		writer.WriteLine(dir.Name);
//	}
//}

//string line = "";
//using (var reader = new StreamReader(path))
//{
//	while((line = reader.ReadLine()) != null)
//	{
//        Console.WriteLine(line);
//	}
//}

//var fileStream = new FileStream(path, FileMode.Open, FileAccess.Write, FileShare.None, 10);
//using (var filestream2 = new FileStream(path, FileMode.Open, FileAccess.Write, FileShare.None, 10))
//{

//}


var information = new List<string>
{
    "Johnson",
    "Peterson",
    "Davidson"
};
//File.WriteAllLines(path, information);
//string fileContent = File.ReadAllText(path);
//Console.WriteLine(fileContent);

//File.Copy(path, newPath, true);
//string newFile = File.ReadAllText(newPath);
//Console.WriteLine(newFile);

//var newInfo = File.ReadLines(path);
//foreach (var line in newInfo)
//{
//    Console.WriteLine(line + "    This line has " + line.Length + "symbols");
    
//}


//using (var writer = new StreamWriter(newPath))
//{
//    writer.WriteLine("01001000 01000101 01001100 01001100 01001111");    
//}
//var newFile2 = File.ReadAllLines(newPath);
//foreach (var item in newFile2)
//{
//    Console.WriteLine(item);
//}


using (var binary = new BinaryWriter(File.Open(newPath, FileMode.Open)))
    {
        binary.Write("Hello");        
    }


using(var reader = new BinaryReader(File.Open(newPath, FileMode.Open)))
{
    string text = reader.ReadString();
    int number = reader.ReadInt32();
    Console.WriteLine(text);
    Console.WriteLine(number);
}







