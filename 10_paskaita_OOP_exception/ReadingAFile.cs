namespace _10_paskaita_OOP_exception
{
    public class ReadingAFile
    {
        

        public ReadingAFile()
        {
            
        }
        public void TryToRead()
        {
            try
            {
                StreamReader sr = new StreamReader("C:\\Users\\AJodz\\OneDrive\\Desktop");
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("File was not found: " + e.Message);
            }
            catch(FileLoadException e)
            {
                Console.WriteLine("File was found but couldn't be opened: " + e.Message);
            }           
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong while trying to read: " + e.Message);
            }

        }
        
    }
}
