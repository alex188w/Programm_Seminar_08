void Zadacha53()
// Задайте двумерный массив. Напишите программу, которая поменяет местами 
// первую и последнюю строку массива
{
    Random random = new Random();
    int rows = random.Next(4, 10);
    int columns = random.Next(4, 10);
    int[,] array = new int[rows, columns];
    FillArray(array, 0, 100);
    Console.WriteLine("Заданный массив ");
    PrintArray(array);
    int i = rows - 1;
    int k = 0;

    for (int j = 0; j < columns; j++)
    {
        int temp = array[k, j];
        array[k, j] = array[i, j];
        array[i, j] = temp;
    }
    Console.WriteLine("Полученный массив ");
    PrintArray(array);
}

void Zadacha55()
// Задайте двумерный массив. Напишите программу, которая заменяет 
// строки на столбцы. В случае, если это невозможно, программа должна
// вывести сообщение для пользователя
{
    Random random = new Random();
    int rows = random.Next(4, 5);
    int columns = random.Next(4, 5);
    int[,] array = new int[rows, columns];
    FillArray(array, 0, 100);
    Console.WriteLine("Заданный массив ");
    PrintArray(array);
    if (rows == columns)
    {
        for (int i = 0; i < rows; i++) 
        {
            for (int j = i; j < columns; j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;   
            }
        }
        Console.WriteLine("Полученный массив ");
        PrintArray(array);
    }        
    else Console.WriteLine("Замерить строки столбцами в данном массиве невозможно ");
    
}

void Zadacha57()
// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается 
// элемент входных данных (словарь - одномерный массив)
{
    Random random = new Random();
    int rows = random.Next(4, 7);
    int columns = random.Next(4, 7);
    int[,] array = new int[rows, columns];
    int n = -10;                        // массив заполняется числами от -10 до 15
    int k = 15;
    int[] booking = new int[k-n + 1];
    FillArray(array, n, k);
    Console.WriteLine("Заданный массив ");
    PrintArray(array);    
    Console.WriteLine();
    for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < columns; j++)
            {
                booking[array[i, j] - n] = booking[array[i, j] - n] + 1; // увеличение элемента массива boocing на единицу
            }
        }
    for (int i = 0; i < booking.Length; i ++)
    {
        if (booking[i] > 0) Console.WriteLine($"Число {i + n} встречается в данном массиве {booking[i]} раз (-а)");
    }
    Console.WriteLine();
}

void Zadacha59()
// Задайтедвумерный массив из целых чисел. Напишите программу, которая
// удалит строку и столбец, на пересечении которых расположен наименьший элемент массива
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    int[,] array = new int[rows, columns];
    FillArray(array, 0, 30);
    Console.WriteLine("Заданный массив ");
    PrintArray(array);
    int min = array[0, 0];
    int min_i = 0;
    int min_j = 0;
    for (int i = 0; i < rows; i++) 
        {
            for (int j = i; j < columns; j++)
            {
                if (array[i, j] < min) 
                {
                    min = array[i, j]; 
                    min_i = i;
                    min_j = j;
                }
            }
        }
    Console.WriteLine($"Минимальный элемент a[{min_i}, {min_j}] равен {min} ");
    Console.WriteLine();

    int rowsResult = rows-1;
    int columnsResult = columns-1;
    int [,] result = new int[rowsResult, columnsResult];
    int bias_i = 0; //смещение по i
    int bias_j = 0; //смещение по j
    for (int i = 0; i < rowsResult; i++) 
        {
            if (i == min_i) bias_i++;
            bias_j = 0;
            for (int j = 0; j < columnsResult; j++)
            {
                if (j == min_j) bias_j++;
                {
                    result[i, j] = array[i +  bias_i, j + bias_j];
                }                     
            }
        }
    Console.WriteLine("Полученный массив ");
    PrintArray(result);
}

void FillArray(int[,] array, int startNumber, int finishNumder)
{
    Random random = new Random();
    finishNumder++;
    int rows =  array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(startNumber, finishNumder);   
        }
    }
}
void PrintArray(int[,] array)
{
    int rows =  array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
              Console.Write(array[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

//Zadacha53();
//Zadacha55();
//Zadacha57();
Zadacha59();

