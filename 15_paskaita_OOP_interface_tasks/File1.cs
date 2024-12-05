namespace _15_paskaita_OOP_interface_tasks
{
    public class File1 : IWriteableToFile
    {
        public string WhatsInside { get; set; }
        public int HowManyLines { get; set; }

        public File1(string whatsInside, int howManyLines)
        {
            WhatsInside = whatsInside;
            HowManyLines = howManyLines;
        }

        public void WriteToFile(string fileName)
        {
            File.AppendAllText(fileName, ToString());            
        }

        public override string ToString()
        {
            return $"\n Whats inside: {WhatsInside} and this many lines: {HowManyLines} \n";
        }
    }
}
