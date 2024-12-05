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
        
        //Initial char array population
        Logic.GridInitialPopulation(grid, Constants.MATRIX_GRID_SIZE, Constants.MATRIX_GRID_SIZE);
        
        bool gameWinX = false, gameWinO = false;
        int availableLocationsCount = (Constants.MATRIX_GRID_SIZE * Constants.MATRIX_GRID_SIZE); 
        
        //while loop here for game over 
        while (!gameWinX && !gameWinO && availableLocationsCount > 0)
        {
            
            bool firstEntrySuccessful = false;
            bool secondEntrySuccessful = false;
            int matrixRow = 0, matrixCol = 0;


           var MatrixCoordinates =  Ui.UserCoordinatesEntry();
           firstEntrySuccessful = int.TryParse(MatrixCoordinates.FirstEntry.ToString(), out matrixRow);
           secondEntrySuccessful = int.TryParse(MatrixCoordinates.SecondEntry.ToString(), out matrixCol);
           
           bool gridPopulationSuccessful = false;
           bool aiPopulationSuccessful = false;
           

           while (!gridPopulationSuccessful)
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
                   //populate the grid with Player X, coordinates and then have the Ai auto populate O
                   gridPopulationSuccessful = Logic.GridPopulation(grid, matrixRow, matrixCol, Constants.USER_PLAYER_CHARACTER);
                   gameWinX = Logic.GameOverCheck(grid, Constants.MATRIX_GRID_SIZE, Constants.USER_PLAYER_CHARACTER);
                   if (gameWinX)
                   {
                       Ui.DisplayWinnerMessage(name, Constants.USER_PLAYER_CHARACTER);
                       break; 
                   }
                   var Aipopulation = Logic.AiPopulation(grid, Constants.MATRIX_GRID_SIZE);
                   
                   aiPopulationSuccessful = Aipopulation.SuccessfullPopulation;
                   availableLocationsCount = Aipopulation.AvailableMatrixLocations;
                   
                   gameWinO = Logic.GameOverCheck(grid, Constants.MATRIX_GRID_SIZE, Constants.AI_PLAYER_CHARACTER);
                   if (!gameWinO && !gameWinX && !aiPopulationSuccessful)
                   {
                       Ui.DisplayGameDrawMessage();
                   }
                   if (gameWinO)
                   {
                       Ui.DisplayWinnerMessage("Computer", Constants.AI_PLAYER_CHARACTER);
                   }
                   break;
               }
               // Only repeats the steps here when else above is not true 
               MatrixCoordinates =  Ui.UserCoordinatesEntry();
               firstEntrySuccessful = int.TryParse(MatrixCoordinates.FirstEntry.ToString(), out matrixRow);
               secondEntrySuccessful = int.TryParse(MatrixCoordinates.SecondEntry.ToString(), out matrixCol);
           }
           gridPopulationSuccessful = false;
           Ui.DisplayGrid(grid, Constants.MATRIX_GRID_SIZE, Constants.MATRIX_GRID_SIZE);
        }
       
    }
    
}