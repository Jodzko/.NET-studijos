namespace Projektas_Restoranas
{
    public class Table
    {
        public int TableNumber;
        public int NumberOfSeats;
        public bool IsTableAvailable { get; set; }
        public DateTime TimeWhenSatDown { get; set; }
        public DateTime TimeWhenFinished { get; set; }
        public static List<Table> ListOfTables = new List<Table>();


        public Table(int tableNumber, int numberOfSeats)
        {
            TableNumber = tableNumber;
            NumberOfSeats = numberOfSeats;
            IsTableAvailable = true;          
        }

       
    }
}
