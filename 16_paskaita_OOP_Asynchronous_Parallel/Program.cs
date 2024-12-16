using System.Diagnostics;

namespace _16_paskaita_OOP_Asynchronous_Parallel
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            //var progress = new ProgressBar(0);
            //var adding = AddToProggress(progress);
            //var showing = ShowProgress(progress);
            //var tasks = new List<Task> {adding, showing };
            //while(tasks.Count > 0)
            //{
            //    await Task.WhenAll(tasks);               
            //}
            
            //var path = "C:\\Users\\AJodz\\OneDrive\\Desktop";
            //var task1 = ShowContent(path);
            //var tasks = new List<Task> { task1 };
            //while(tasks.Count > 0)
            //{
            //    await Task.WhenAll(tasks);
            //}

            var path1 = "C:\\Users\\AJodz\\OneDrive\\Documents";
            var fileToFind = "FindMe2.txt";
            FindFile(path1, fileToFind);


        }
        public static async Task<ProgressBar> AddToProggress(ProgressBar progress)
        {
            for (int i = progress.Progress; i < 100; i++)
            {
                Console.WriteLine("Adding one to the progress.");
                progress.Progress++;
                await Task.Delay(1000);
            }
            return progress;

        }
        public static async Task<ProgressBar> ShowProgress(ProgressBar progress)
        {
            while (progress.Progress < 100)
            {
                await Task.Delay(3000);
                Console.WriteLine(progress.Progress);
            }
            return progress;
        }
        public static async Task ShowContent(string path)
        {
            while (true)
            {
                var fileContent = Directory.GetFiles(path);
                foreach (var item in fileContent)
                {
                    Console.WriteLine(item);
                }
                await Task.Delay(5000);
            }
        }
        public static async Task FindFile(string path, string fileToFind)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var tasks = new List<Task>();
            var files = Directory.GetFiles(path);
            tasks.Add(FindFileInDirectory(path, fileToFind));
                var dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
                foreach (var item in dirs)
                {
                tasks.Add(FindFileInDirectory(item, fileToFind));
                }
            Task.WhenAll(tasks);
            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed.ToString());
        }
        public static async Task FindFileInDirectory(string path, string fileToFind)
        {
            var files = Directory.GetFiles(path);
            foreach (var item in files)
            {
                if(Path.GetFileName(item) == fileToFind)
                {
                    Console.WriteLine("Found the file: ");
                    Console.WriteLine(Path.GetFullPath(item));
                    await Task.Delay(0);
                }
            }
            
        }
    }      
}
