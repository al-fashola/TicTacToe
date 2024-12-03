using System.Dynamic;
using TicTacToe;


namespace TicTacToe;


class Program
{
    static void Main(string[] args)
    {
        
        string name; 
       
        name = Ui.UserEntryMessage();
        
        char [,] grid = new char[Constants.MATRIX_GRID_SIZE, Constants.MATRIX_GRID_SIZE];
        
        Ui.DisplayGridCoordinates(Constants.MATRIX_GRID_SIZE, Constants.MATRIX_GRID_SIZE);
        
        //Populate the array initially
        Logic.GridInitialPopulation(grid, Constants.MATRIX_GRID_SIZE, Constants.MATRIX_GRID_SIZE);
        
        bool firstEntrySuccessful = false;
        bool secondEntrySuccessful = false;
        int matrixRow = 0, matrixCol = 0;


       var MatrixCoordinates =  Ui.UserCoordinatesEntry();
       firstEntrySuccessful = int.TryParse(MatrixCoordinates.FirstEntry.ToString(), out matrixRow);
       secondEntrySuccessful = int.TryParse(MatrixCoordinates.SecondEntry.ToString(), out matrixCol);
       
       bool gridPopulationSuccessful = false;
       bool aiPopulationSuccessful = false;

       while (!gridPopulationSuccessful /*|| gameOverCheck*/)
       {
           if ((!firstEntrySuccessful && !secondEntrySuccessful)
               || matrixRow >= Constants.MATRIX_GRID_SIZE
               || matrixCol >= Constants.MATRIX_GRID_SIZE)
           {
               Ui.DisplayValidCoordinatesEntryMessage();
           }
           else if (!Logic.CheckGridIsNotPopulated(grid, matrixRow, matrixCol))
           {
               Ui.DisplayLocationPopulatedMessage(); 
           }
           else
           {
               bool gameWinX = false, gameWinO = false;
               //var winner = CustomClasses.GameWinner();
               
               
               //populate the grid with Player X, coordinates and then have the Ai auto populate O
               gridPopulationSuccessful = Logic.GridPopulation(grid, matrixRow, matrixCol, Constants.USER_PLAYER_CHARACTER);
               gameWinX = Logic.GameOverCheck(grid, Constants.MATRIX_GRID_SIZE, Constants.USER_PLAYER_CHARACTER);
               if (gameWinX)
               {
                   //print winning messsage
                   // display grid
                   break; //double break or exit
               }
               // if player true win then break and display grid function and double break-break exit
               aiPopulationSuccessful = Logic.AiPopulation(grid, Constants.MATRIX_GRID_SIZE);
               gameWinO = Logic.GameOverCheck(grid, Constants.MATRIX_GRID_SIZE, Constants.AI_PLAYER_CHARACTER);  
               if (gameWinO)
               {
                   //print winning messsage
                   // display grid
                   break; //double break or exit
               }
               
               //There needs to be a draw check utilizing when theres no spaces left for entry and bool of both false
               // is there a way to use out parameter to release availableFieldsCounter when 1 or 0 fields available and no win = draw
               
               break;
           }
           // Only repeats the steps here when else above is not true 
           MatrixCoordinates =  Ui.UserCoordinatesEntry();
           firstEntrySuccessful = int.TryParse(MatrixCoordinates.FirstEntry.ToString(), out matrixRow);
           secondEntrySuccessful = int.TryParse(MatrixCoordinates.SecondEntry.ToString(), out matrixCol);
       }
       
       gridPopulationSuccessful = false;
       // consider this placement for looping in each entry and possibly second while. should this go here?
       
       
       // need a function that has a list of available coordinates where ' ' is present, picks one in the list
       // at random then uses the vairables of that position  to populate 'O' using poplation function 
       //Scetion to check if the game is over if not repeat the above steps with go to 
           
           
           //Method in UI class for display current grid once issue is resolved
           Ui.DisplayGrid(grid, Constants.MATRIX_GRID_SIZE, Constants.MATRIX_GRID_SIZE);
           
       
       
       
       
       
       
       
       
       //function call to logic which checks if matrix is already populated 
       // pre populate array fully with "" or length count and if count <> expected value - throw already populated and ask for new coordinates
        
        
        
       // grid = Logic.CreateArray(Constants.MATRIX_GRID_SIZE, Constants.MATRIX_GRID_SIZE);
        
        
        
        
       
       
       
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