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
    int rows = random.Next(4, 10);
    int columns = random.Next(4, 10);
    int[,] array = new int[rows, columns];
    FillArray(array, 0, 9);
    Console.WriteLine("Заданный массив ");
    PrintArray(array);
    int[] booking = new int[10];
    Console.WriteLine();

    for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < columns; j++)
            {
                booking[array[i, j]] = booking[array[i, j]] + 1; // увеличение элемента массива boocing на единицу
            }
        }
    for (int i = 0; i < booking.Length; i ++)
    {
        if (booking[i] > 0) Console.WriteLine($"Число {i} встречается в данном массиве {booking[i]} раз (-а)");
    }
    Console.WriteLine();
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
Zadacha57();

