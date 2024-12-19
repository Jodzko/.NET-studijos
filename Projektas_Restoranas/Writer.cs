namespace Projektas_Restoranas
{
    public static class Writer
    {
        public static void FileWriter(string path, string[] whatToAppend)
        {
            File.AppendAllLines(path, whatToAppend);            
        }
    }
}
