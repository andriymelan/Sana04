internal class Program
{
    static void ConsoleOutPut(string str, int number)
    {
        Console.WriteLine($"{str} {number}");
    }
    static void MatrxAdd(int[,] matrx)
    {
        Random rnd = new Random();
        for (int i = 0; i < matrx.GetLength(0); i++)
        {
            for (int j = 0; j < matrx.GetLength(1); j++)
            {
                matrx[i, j] = rnd.Next(20) - 10;
            }
        }
    }
    static void ConsoleMatrxOutPut(int[,] matrx)
    {
        Console.WriteLine("Matrix:");
        for (int i = 0; i < matrx.GetLength(0); i++)
        {
            for (int j = 0; j < matrx.GetLength(1); j++)
            {
                Console.Write($"{matrx[i, j]} \t");
            }
            Console.WriteLine();
        }
    }
    private static void Main()
    { 
        int [,]matrx = new int[10,10];
        MatrxAdd(matrx);  
        ConsoleMatrxOutPut(matrx);
    }
}