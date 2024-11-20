namespace TicTacToe;



public static class Ui
{



    public static string UserEntryMessage()
    {
        Console.WriteLine("Hello, Welcome to Tic-Tac-Toe!");
        Console.WriteLine("You will be asked to take turns against the computer after each symbol entry ");
        Console.WriteLine("You will begin first. Please enter your name:");
        string name = Console.ReadLine();

        return name;
    }
    
    public static void DisplayGridCoordinates(int matrixA, int matrixB)
    {
        Console.WriteLine("Below is the coordinates of each location for your entry symbol");
        for (int x = 0; x < matrixA; x++)
        {
            for (int y = 0; y < matrixB; y++)
            {
                Console.Write($"|{x},{y}|");
            }
            Console.WriteLine("");
        }
    }
    
    /*
    public static void DisplayGrid(Array grid, int matrixA, int matrixB)
    {
        
        for (int x = 0; x < matrixA; x++)
        {
            for (int y = 0; y < matrixB; y++)
            {
                Console.Write($"|{grid[x,y]}|");
            }
            Console.WriteLine("");
        }
    }
    */
    
    public static CustomClasses.MatrixCoordinates UserCoordinatesEntry()
    {

        //This could be represented in the form of internally numbered grid identifiers matching the matrix length for easier user readability instead of grid entires
        Console.WriteLine("\nPlease enter your grid choices below");
        Console.WriteLine("Please enter the row of your grid choice:");
        char row = Console.ReadKey().KeyChar;
        Console.WriteLine("\nPlease enter the column grid choice:");
        char col = Console.ReadKey().KeyChar;
        Console.WriteLine("\n");
        
        var MatrixCoordinates = new CustomClasses.MatrixCoordinates();
        {
            MatrixCoordinates.FirstEntry = row;
            MatrixCoordinates.SecondEntry = col;
        }
        ;
        
        return MatrixCoordinates;
    }
    
    
    public static void DisplayLocationPopulatedMessage()
    {
        Console.WriteLine("This Location is already populated, please enter in new coordinates");
    }
    
    public static void DisplayValidCoordinatesEntryMessage()
    {
        Console.WriteLine("\nPlease enter only valid integers from the presented positions as entry");
    }
    
    
}









