using System.Dynamic;
using TicTacToe;


namespace TicTacToe;

class Program
{
    static void Main(string[] args)
    {
        const int MATRIX_GRID_SIZE = 3;
        string name; 
       
        name = Ui.UserEntryMessage();
        
        char [,] grid = new char[MATRIX_GRID_SIZE, MATRIX_GRID_SIZE];
        
        Ui.DisplayGridCoordinates(MATRIX_GRID_SIZE, MATRIX_GRID_SIZE);
        
        bool firstEntrySuccessful = false;
        bool secondEntrySuccessful = false;
        int matrixRow = 0, matrixCol = 0;


       var MatrixCoordinates =  Ui.UserCoordinatesEntry();
       firstEntrySuccessful = int.TryParse(MatrixCoordinates.FirstEntry.ToString(), out matrixRow);
       secondEntrySuccessful = int.TryParse(MatrixCoordinates.SecondEntry.ToString(), out matrixCol);

       while ((!firstEntrySuccessful && !secondEntrySuccessful) || matrixRow >= MATRIX_GRID_SIZE || matrixCol >= MATRIX_GRID_SIZE)
       {
           Console.WriteLine("\nPlease enter only valid integers from the presented positions as entry");
           MatrixCoordinates =  Ui.UserCoordinatesEntry();
           firstEntrySuccessful = int.TryParse(MatrixCoordinates.FirstEntry.ToString(), out matrixRow);
           secondEntrySuccessful = int.TryParse(MatrixCoordinates.SecondEntry.ToString(), out matrixCol);
       }
       
       
       //Populate the array initially
       for (int x = 0; x < MATRIX_GRID_SIZE; x++)
       {
           for (int y = 0; y < MATRIX_GRID_SIZE; y++)
           {
               grid[x, y] = ' ';
           }
       }
       
       //Use game over bool to check if there is a match consistently in any direction or if there are no spaces left ot enter
       
       // Check if location is already populated
           if (grid[matrixRow, matrixCol] == ' ')
           {
               grid[matrixRow, matrixCol] = 'X';
           }
           else
           {
               Ui.DisplayLocationPopulatedMessage();
               
           }
           
           
           //Method in UI class for display current grid once issue is resolved
           for (int x = 0; x < MATRIX_GRID_SIZE; x++)
           {
               for (int y = 0; y < MATRIX_GRID_SIZE; y++)
               {
                   Console.Write($"|{grid[x,y]}|");
               }
               Console.WriteLine("");
           }
       
       
       
       
       
       
       
       
       //function call to logic which checks if matrix is already populated 
       // pre populate array fully with "" or length count and if count <> expected value - throw already populated and ask for new coordinates
        
        
        
       // grid = Logic.CreateArray(MATRIX_GRID_SIZE, MATRIX_GRID_SIZE);
        
        
        
        
        // Please ignore all below - this was a test exercise
        /*
        Console.WriteLine("Hello, World!");

        int a = 0;
        int b = 0;
        
       // bool firstEntrySuccessful = false;
        //bool secondEntrySuccessful = false;
        
        
            
        Console.WriteLine("Press enter 2 numbers to proceed...");
        Console.WriteLine("Enter the first number");
        string firstEntry = Console.ReadLine();
        firstEntrySuccessful = int.TryParse(firstEntry, out a);

        while (!firstEntrySuccessful)
        {
            Console.WriteLine("enter only integers numbers:");
            firstEntry = Console.ReadLine();
            firstEntrySuccessful = int.TryParse(firstEntry, out a);
        }
        
        Console.WriteLine("Enter the second number");
        string secondEntry = Console.ReadLine();
        secondEntrySuccessful = int.TryParse(secondEntry, out b);
        
        while (!secondEntrySuccessful)
        {
            Console.WriteLine("enter only integers numbers:");
            secondEntry = Console.ReadLine();
            secondEntrySuccessful = int.TryParse(secondEntry, out b);
        }

        int final = addtwonumbers(a, b);
        
        Console.WriteLine( final);
        
*/
    }
/*
    /// <summary>
    /// Adding of two numbers together
    /// </summary>
    /// <param name="a"></param> first param
    /// <param name="b"></param> second param for addition 
    /// <returns></returns>
    static int addtwonumbers(int a, int b)
    {
        Console.WriteLine($"You have asked to add the following two integers together a: {a}, b: {b}");
        int result = a + b;
        return result;
    }
    
    */



}