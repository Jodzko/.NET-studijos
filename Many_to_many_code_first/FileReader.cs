namespace Many_to_many_code_first
{
    public static class FileReader
    {


        public static void GetDirectoriesFromPath(string path)
        {
            var fileContext = new FileContext();
            var counter = 0;
            if (counter < 1)
                {
                var directory = new DirectoryInfo(path).Name;
                var firstFolder = new Folder(directory);
                fileContext.Folders.Add(firstFolder);
                FileInfo[] firstFiles = new DirectoryInfo(path).GetFiles();
                foreach (var item in firstFiles)
                {
                    var firstLayerFiles = new File(item.Name, item.Length, item.DirectoryName, firstFolder.Id);
                    fileContext.Files.Add(firstLayerFiles);
                }               
                }
                DirectoryInfo[] dirs = new DirectoryInfo(path).GetDirectories();
                foreach (var item in dirs)
                {
                    var newFolder = new Folder(item.Name);
                    FileInfo[] files = new DirectoryInfo(path).GetFiles();                   
                    foreach (var file in files)
                    {
                        var newFile = new File(file.Name, file.Length, file.DirectoryName, newFolder.Id);
                        fileContext.Files.Add(newFile);
                    }
                    fileContext.Folders.Add(newFolder);
                GetDirectoriesFromPath(item.FullName);
            }
                fileContext.SaveChanges();
        }
            //public static void GetFilesFromDirectory(string path)
            //{
            //    var fileContext = new FileContext();
            //    FileInfo[] files = new DirectoryInfo(path).GetFiles();
            //    foreach (var item in files)
            //    {
            //        var newFile = new File(item.Name, item.Length, item.DirectoryName);
            //        fileContext.Files.Add(newFile);
            //    }
            //    fileContext.SaveChanges();
            //}
        }
    }

