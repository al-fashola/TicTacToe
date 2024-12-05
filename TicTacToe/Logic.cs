namespace TicTacToe;

public static class Logic
{

    public static Random rnd = new Random();
     
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
    
    
   public static bool CheckGridIsNotPopulated(char [,] grid, int row, int column)
   {

       if (grid[row, column] == Constants.EMPTY_SPACE)
       {
           return true;
       }
       else return false;
   }
   
   public static bool GridPopulation(char [,] grid, int row, int column, char player)
   {
       if (grid[row, column] == Constants.EMPTY_SPACE)
       {
           grid[row, column] = player;
           return true;
       }
       return false;
   }


   public static CustomClasses.Aipopulation AiPopulation(char[,] grid,  int matrixSize)
   {
       int availableFieldsCounter = 0;
       bool successfullyPopulated;
       
       List<int> rows = new List<int>();
       List<int> columns = new List<int>();
       
       for (int x = 0; x < matrixSize; x++)
       {
           for (int y = 0; y < matrixSize; y++)
           {
               if (grid[x, y] == Constants.EMPTY_SPACE)
               {
                   rows.Add(x);
                   columns.Add(y);
                   availableFieldsCounter++;
               }
           }
       }

       if (availableFieldsCounter < 1)
       {
           successfullyPopulated = false;
       }
       else
       {
           int populationVal = rnd.Next(0, rows.Count); 
           grid[rows[populationVal], columns[populationVal]] = Constants.AI_PLAYER_CHARACTER;
           successfullyPopulated = true;
       }
       
       var MatrixPopulation = new CustomClasses.Aipopulation();
       {
           MatrixPopulation.SuccessfullPopulation = successfullyPopulated;
           MatrixPopulation.AvailableMatrixLocations = availableFieldsCounter;
       }
           
       return MatrixPopulation;
       
   }


   public static bool GameOverCheck(char[,] grid, int matrixSize, char player)
   {
       bool gameOver = false;

       if (DiagonalWinValidation(grid, matrixSize, player))
       {
           gameOver = true;
       }
       else if (HorizontalWinValidation(grid, matrixSize, player))
       {
           gameOver = true;
       }
       else if (VerticalWinValidation(grid, matrixSize, player))
       {
           gameOver = true;
       }
       return gameOver;
   }
   
   public static bool DiagonalWinValidation(char[,] grid, int matrixSize, char player)
   {
       // could try returning '-' for draw, or the characters of the winner e.g. 'x','o'
       
       bool gameOver = false;
       
       int matchCounter = 0;
       int matchCounterAlt = 0;

       int centerValueInt = matrixSize / 2;
       int matchValue = grid[centerValueInt, centerValueInt];

       for (int h = 0, i = 0, j = matrixSize - 1; h < matrixSize; h++, i++, j--)
       {
           if (matchValue == grid[h, i] && matchValue == player) matchCounter++;
           if (matchValue == grid[j, i] && matchValue == player) matchCounterAlt++;
       }

       if (matchCounter == matrixSize || matchCounterAlt == matrixSize)
       {
           gameOver = true;
       }
       
       return gameOver;
   }
   
   public static bool HorizontalWinValidation(char[,] grid, int matrixSize, char player)
   {
       bool gameOver = false;
       
       for (int i = 0; i < matrixSize; i++)
       {
           int matchCounter = 0;
           int firstValue = grid[i, 0];
           for (int j = 0; j < matrixSize; j++)
           {
               if (firstValue == grid[i, j] && firstValue== player) matchCounter++;
           }
           if (matchCounter == matrixSize)
           {
               gameOver = true;
               break;
           }
       }
      
       return gameOver;
   }
   
   public static bool VerticalWinValidation(char[,] grid, int matrixSize, char player)
   {
       bool gameOver = false;
       
       for (int i = 0; i < matrixSize; i++)
       {
           int matchCounter = 0;
           int firstValue = grid[0, i];
           for (int j = 0; j < matrixSize; j++)
           {
               if (firstValue == grid[j, i] && firstValue == player) matchCounter++;
           }

           if (matchCounter == matrixSize)
           {
               gameOver = true;
               break;
           }
       }
      
       return gameOver;
   }
   
   
   

}