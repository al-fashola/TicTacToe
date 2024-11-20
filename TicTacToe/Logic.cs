namespace TicTacToe;

public static class Logic
{

    //Not necessary to create an array in the logic seperately
    public static Array CreateArray(int sizeA, int sizeB)
    {
        int [,] grid = new int[sizeA, sizeB];
        return grid;
    }
    
    public static Array GridUpdate(Array grid)
    {
        
        return grid;
    }
    
    /*
     //unsure why this doesn't work on the multidimensional array grid[x,y]
     
    public static void GridInitialPopulation(Array grid, int sizeA, int sizeB)
    {
        for (int x = 0; x < sizeA; x++)
        {
            for (int y = 0; y < sizeB; y++)
            {
                grid[x, y] = ' ';
            }
        }
    }
    
    public static bool GridPopulationCheck(Array grid, int row, int column, Char player)
    {
        
        if (grid[row, column] == ' ')
        {
            return true;
        }
        else return false;
    }
    */
    
    
}