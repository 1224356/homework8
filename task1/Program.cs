void printRandArr(int[,] RandArr)
{
    Console.WriteLine("Массив:");
    for(int i = 0; i < RandArr.GetLength(0); i++)
    {
        for(int j = 0; j < RandArr.GetLength(1); j++)
        {
            Console.Write($"{RandArr[i,j]} \t");
        }
        Console.WriteLine();
    }
}

int[,] createArr()
{
    int rows = new Random().Next(2, 10), cols = new Random().Next(2, 10);
    int[,] newArr = new int[rows, cols];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        {
            newArr[i,j] = new Random().Next(1, 10);
        }
    }
    printRandArr(newArr);
    return newArr;
}

void findMinSumRaw(int[] masSumRaw)
{
    int min = masSumRaw[0];
    int iMin = 0;
    for (int iElem = 1; iElem < masSumRaw.Length; iElem++)
    {
        if (min > masSumRaw[iElem])
        {
            min = masSumRaw[iElem];
            iMin = iElem;
        }
    }
    Console.WriteLine($"\nНомер строки с наименьшей суммой элементов: {iMin+1} строка"); 

}

int[] createArrRawSum(int[,] mas)
{
    int sum = 0;
    int[] masRowSum = new int[mas.GetLength(0)];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            sum += mas[i,j];
        }
        masRowSum[i] = sum;
    }
    return masRowSum;
}

findMinSumRaw(createArrRawSum(createArr()));