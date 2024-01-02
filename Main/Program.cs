internal class Program
{
    static void ConsoleOutPut(string str, int number)
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        Console.WriteLine($"{str} {number}");
    }
    static void ConsoleException(string str)
    {
        Console.WriteLine(str);
    }
    static void MatrxAdd(int[,] matrx)
    {
        Random rnd = new Random();
        for (int i = 0; i < matrx.GetLength(0); i++)
        {
            for (int j = 0; j < matrx.GetLength(1); j++)
            {
                matrx[i, j] = rnd.Next(21) - 5;
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
    static void PositiveNumbers(int[,] matrx)
    {
        int positiveNumber = 0;
        for (int i = 0; i < matrx.GetLength(0); i++)
        {
            for (int j = 0; j < matrx.GetLength(1); j++)
            {
                if (matrx[i, j] > 0)
                    positiveNumber++;
            }
        }
        ConsoleOutPut("Кількість додатніх елементів", positiveNumber);
    }
    static int FindMax(int[,] matrx)
    {
        int maxEl = matrx[0, 0];
        for (int i = 0; i < matrx.GetLength(0); i++)
        {
            for (int j = 0; j < matrx.GetLength(1); j++)
            {
                if (matrx[i, j] > maxEl)
                    maxEl = matrx[i, j];
            }
        }
        return maxEl;
    }
    static void MaxNumberMoreThanOnce(int[,] matrx, int maxEl)
    {
        int maxNumber = 0;
        for (int i = 0; i < matrx.GetLength(0); i++)
        {
            for (int j = 0; j < matrx.GetLength(1); j++)
            {
                if (maxEl == matrx[i, j])
                    maxNumber++;
            }
        }
        if (maxNumber > 1)
            ConsoleOutPut("Максимальне із чисел, що зустрічається в заданій матриці більше одного разу", maxEl);
        else
            MaxNumberMoreThanOnce(matrx, maxEl - 1);
    }
    static void NumberRowsHaveNtZero(int[,] matrx)
    {
        int number = 0;
        for (int i = 0; i < matrx.GetLength(0); i++)
        {
            int check = 0;
            for (int j = 0; j < matrx.GetLength(1); j++)
            {
                if (matrx[i, j] == 0)
                {
                    check = 1;
                    continue;
                }
            }
            if (check != 1)
                number++;
        }
        ConsoleOutPut("Кількість рядків, які не містять жодного нульового елемента", number);
    }
    static void NumberColumnHaveZero(int[,] matrx)
    {
        int number = 0;
        for (int i = 0; i < matrx.GetLength(1); i++)
        {
            int check = 0;
            for (int j = 0; j < matrx.GetLength(0); j++)
            {
                if (matrx[j, i] == 0)
                {
                    check = 1;
                    continue;
                }
            }
            if (check == 1)
                number++;
        }
        ConsoleOutPut("Кількість стовпців, які містять хоча б один нульовий елемент", number);
    }
    static void RowNumberOfLongestSeriesOfIdenticalNumber(int[,] matrx)
    {
        int number = 0, longest = 0;
        for (int i = 0; i < matrx.GetLength(0); i++)
        {
            int check = matrx[i, 0];
            int checkLongest = 0;
            for (int j = 0; j < matrx.GetLength(1) - 1; j++)
            {
                if (matrx[i, j + 1] == check)
                {
                    checkLongest++;
                    continue;
                }
                else
                    check = matrx[i, j + 1];
            }
            if (checkLongest > longest)
            {
                number = i;
                longest = checkLongest;
            }
        }
        if (longest != 0)
            ConsoleOutPut("Номер рядка, в якому знаходиться найдовша серія однакових елементів", number + 1);
        else
            ConsoleException("Немає рядку з найдовшою серією однакових елементів");
    }
    static void ProductOfElInRowWhichDontHaveNegEl(int[,] matrx)
    {
        for(int i = 0;i < matrx.GetLength(0); i++)
        {
            int dob = 1;
            for( int j = 0;j < matrx.GetLength(1); j++)
            {
                if (matrx[i,j] < 0)
                    dob = 0;
                dob *= matrx[i, j];
            }
            if (dob != 0)
                ConsoleOutPut($"Добуток елементів в {i+1} рядку = ", dob);
        }
    }
    private static void Main()
    {
        int[,] matrx = new int[5, 7];
        MatrxAdd(matrx);
        ConsoleMatrxOutPut(matrx);
        PositiveNumbers(matrx);
        int max = FindMax(matrx);
        MaxNumberMoreThanOnce(matrx, max);
        NumberRowsHaveNtZero(matrx);
        NumberColumnHaveZero(matrx);
        RowNumberOfLongestSeriesOfIdenticalNumber(matrx);
        ProductOfElInRowWhichDontHaveNegEl(matrx);
    }
}