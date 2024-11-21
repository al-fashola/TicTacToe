namespace TicTacToe;

public static class Logic
{

    //Not necessary to create an array in the logic seperately
    public static Array CreateArray(int sizeA, int sizeB)
    {
        int [,] grid = new int[sizeA, sizeB];
        return grid;
    }
    
    
     
    public static void GridInitialPopulation(char[,] grid, int sizeA, int sizeB)
    {
        for (int x = 0; x < sizeA; x++)
        {
            for (int y = 0; y < sizeB; y++)
            {
                 grid[x, y] = ' ';
            }
        }
    }
    
    
   public static bool GridNotPopulatedCheck(char [,] grid, int row, int column)
   {

       if (grid[row, column] == ' ')
       {
           return true;
       }
       else return false;
   }
   
   public static bool GridPopulation(char [,] grid, int row, int column, char player)
   {
       if (grid[row, column] == ' ')
       {
           grid[row, column] = player;
           return true;
       }
       else return false;
   }


   public static bool AiPopulation(char[,] grid,  int matrixSize)
   {
       int availableFieldsCounter = 0;
       
       List<int> rows = new List<int>();
       List<int> columns = new List<int>();
       
       for (int x = 0; x < matrixSize; x++)
       {
           for (int y = 0; y < matrixSize; y++)
           {
               if (grid[x, y] == ' ')
               {
                   rows.Add(x);
                   columns.Add(y);
                   availableFieldsCounter++;
               }
           }
       }

       if (availableFieldsCounter < 1)
       {
           Console.WriteLine("All available fields have been populated (AI)");
           return false;
       }
       
       Random rnd = new Random();
       int populationVal = rnd.Next(0, rows.Count); 
       grid[rows[populationVal], columns[populationVal]] = 'O';
       return true;
   }


   public static bool GameOverCheck(char[,] grid, int matrixSize)
   {
       bool gameOver = false;
       
       
       
       

       return gameOver;
   }
   
   public static bool DiagonolValidation(char[,] grid, int matrixSize)
   {
       // Need to return who won! 
       // could try returning '-' for draw, or the characters of the winner e.g. 'x','o'
       // but will need to be considerate of This will need to check who is the first person to win and run multiple times
       // should i break this down into multiple separate functions? that will encorporate a bigger function GameOverCheck
       // that is run after each turn (2 players going) 
       
       bool gameOver = false;
       
       //((grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2]) 
       // || (grid[2, 0] == grid[1, 1] && grid[1, 0] == grid[0, 2]))
       int matchCounter = 0;
       int matchCounterAlt = 0;

       int centerValueInt = matrixSize / 2;
       int matchValue = grid[centerValueInt, centerValueInt];

       for (int h = 0, i = 0, j = matrixSize - 1; h < matrixSize; h++, i++, j--)
       {
           if (matchValue == grid[h, i]) matchCounter++;
           if (matchValue == grid[j, i]) matchCounterAlt++;
       }

       if (matchCounter == matrixSize || matchCounterAlt == matrixSize)
       {
           gameOver = true;
       }
       
       return gameOver;
   }
   
   
   

}