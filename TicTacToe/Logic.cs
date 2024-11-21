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
    
}