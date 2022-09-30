int[] setArrSize()
{
    int[] RowsCols = new int[2]; 
    RowsCols[0] = new Random().Next(2, 25);
    RowsCols[1] = new Random().Next(2,50 / RowsCols[0]);
    return RowsCols; 
}

int findValue(int[,] nums)
{
    bool flag = false;
    int elemValue = new Random().Next(0,100);
    while (flag == false)
    {
        elemValue = new Random().Next(0,100);
        flag = true;
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                if (elemValue != nums[i,j]) flag = flag & true;
                if (elemValue == nums[i,j]) flag = flag & false;
            }
        }
    }
    return elemValue;
}

int[,] createArr(int rows, int cols)
{
    int[,] mas = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            mas[i,j] = findValue(mas);
        }
    }
    return mas;
}

void printRandArr(int[,] RandArr)
{
    Console.WriteLine($"Массив размером {RandArr.GetLength(0)}X{RandArr.GetLength(1)}:");
    for(int i = 0; i < RandArr.GetLength(0); i++)
    {
        for(int j = 0; j < RandArr.GetLength(1); j++)
        {
            Console.Write($"{RandArr[i,j]} \t");
        }
        Console.WriteLine();
    }
}

int[] arrSize = setArrSize();
printRandArr(createArr(arrSize[0], arrSize[1]));