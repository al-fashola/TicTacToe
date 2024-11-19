using System.Dynamic;
using TicTacToe;


namespace TicTacToe;

class Program
{
    static void Main(string[] args)
    {
        const int MATRIX_GRID_SIZE = 3;
        string name; 
       
        name = Ui.DisplayEntryMessage();
        
        int [,] grid = new int[MATRIX_GRID_SIZE, MATRIX_GRID_SIZE];


        bool firstEntrySuccessful = false;
        bool secondEntrySuccessful = false;
        int matrixRow = 0, matrixCol = 0;


       var MatrixCoordinates =  Ui.TurnEntry();
       firstEntrySuccessful = int.TryParse(MatrixCoordinates.FirstEntry.ToString(), out matrixRow);
       secondEntrySuccessful = int.TryParse(MatrixCoordinates.SecondEntry.ToString(), out matrixCol);

       while (!firstEntrySuccessful && !secondEntrySuccessful)
       {
           Console.WriteLine("Please enter a only valid integers as entry");
           MatrixCoordinates =  Ui.TurnEntry();
           firstEntrySuccessful = int.TryParse(MatrixCoordinates.FirstEntry.ToString(), out matrixRow);
           secondEntrySuccessful = int.TryParse(MatrixCoordinates.SecondEntry.ToString(), out matrixCol);
       }

        
        
        
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