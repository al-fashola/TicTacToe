namespace TicTacToe;

public static class Ui
{

    public class MatrixCoordinates
    {
        public char FirstEntry;
        public char SecondEntry;
    }

    public static string DisplayEntryMessage()
    {
        Console.WriteLine("Hello, Welcome to Tic-Tac-Toe!");
        Console.WriteLine("You will be asked to take turns against the computer after each entry of your symbol ");
        Console.WriteLine("Please enter your name");
        string name = Console.ReadLine();

        return name;
    }
    
    
    public static MatrixCoordinates TurnEntry()
    {
        char a = ' ';
        char b = ' ';

        //This could be represented in the form of internally numbered grid identifiers matching the matrix length for easier user readability instead of grid entires
        Console.WriteLine("Please enter your grid choices below");
        Console.WriteLine("Please enter your first grid choice: \n");
        a = Console.ReadKey().KeyChar;
        Console.WriteLine("Please enter your second grid choice: \n");
        b = Console.ReadKey().KeyChar;
        
        var MatrixCoordinates = new MatrixCoordinates();
        {
            MatrixCoordinates.FirstEntry = a;
            MatrixCoordinates.SecondEntry = b;
        }
        ;
        
        return MatrixCoordinates;
    }
    
}