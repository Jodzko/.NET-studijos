namespace Projektas_Restoranas
{
    public static class Reader
    {
        public static string[] FileReader(string path)
        {
            var read = File.ReadAllLines(path);
            return read;
        }

        public static int SerialNumberGetter(string path)
        {
            var read = Reader.FileReader(path);
            var newSerialNumber = int.Parse(read[0]);
            return newSerialNumber;
        }
    }
}
