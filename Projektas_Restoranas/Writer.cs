namespace Projektas_Restoranas
{
    public static class Writer
    {
        public static void AppendToFile(string path, string whatToAppend)
        {
            File.AppendAllText(path, whatToAppend);            
        }

        public static void ChangeUniqueSerialNumber(string path, int whatToWrite)
        {
            File.WriteAllText(path, whatToWrite.ToString());
        }
    }
}
