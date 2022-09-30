int[,] createArr(int size)
{
    int[,] newArr = new int[size, size];
    for(int iRow = 0; iRow < size; iRow++)
    {
        for(int jCol = 0; jCol < size; jCol++)
        {
            newArr[iRow,jCol] = new Random().Next(1, 10);
        }
    }
    return newArr;
}

void printArrAB(int[,] arrA, int[,] arrB, int sizeAB)
{
    Console.WriteLine("Дано матрицы A и B:");
    for(int iAB = 0; iAB < sizeAB; iAB++)
    {
        for(int jA = 0; jA < sizeAB; jA++)
        {
            Console.Write($"{arrA[iAB,jA]} \t");
        }
        Console.Write("| \t");
        for(int jB = 0; jB < sizeAB; jB++)
        {
            Console.Write($"{arrB[iAB,jB]} \t");
        }
        Console.WriteLine();
    }
}

int[,] calcMasC(int[,] masA, int[,] masB, int sizeABC)
{
    int[,] C = new int[sizeABC, sizeABC];
    for (int iC = 0; iC < sizeABC; iC++)
    {
        for (int jC = 0; jC < sizeABC; jC++)
        {
            int sum = 0;
            for (int ijAB = 0; ijAB < sizeABC; ijAB++)
            {
                sum += masA[iC, ijAB] * masB[ijAB, jC];
            }
            C[iC,jC] = sum;
        }
    }
    return C;
    
}

void printArrC(int[,] arrC)
{
    Console.WriteLine("\nРезультирующая матрица C:");
    for(int i = 0; i < arrC.GetLength(0); i++)
    {
        for(int j = 0; j < arrC.GetLength(1); j++)
        {
            Console.Write($"{arrC[i,j]} \t");
        }
        Console.WriteLine();
    }
}



int masSize = new Random().Next(2, 5);
int[,] A = createArr(masSize);
int[,] B = createArr(masSize);
printArrAB(A, B, masSize);
printArrC(calcMasC(A, B, masSize));