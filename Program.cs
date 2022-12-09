//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] CreatNewArray (int size)
{
    int[] isArray = new int [size];
    
    for ( int i = 0; i < size; i++)
    isArray [i] = new Random().Next(99, 1000);       
    {
    return (isArray);  
    }
}

void PositivNumbers(int[] NewArray)
{
    int count = 0;
    
    for (int i = 0; i < NewArray.Length; i++)
    { 
    if (NewArray[i] % 2 == 0)
    count++;
    }
    Console.WriteLine($"Kоличество чётных чисел в массиве: {count}");
}

Console.WriteLine("Введите положительное трехзначное число: ");
int positiv_num = Convert.ToInt32(Console.ReadLine());

int [] ShowArray = CreatNewArray(positiv_num);
PositivNumbers (ShowArray);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreatNewArray (int size)
{
    int[] isArray = new int [size];
    
    for ( int i = 0; i < size; i++)
    isArray [i] = new Random().Next(9, 100);       
    {
    return (isArray);  
    }
}
void Summ(int[] Array)
{
    int SumNegativ = 0;

    for (int i = 0; i < Array.Length; i++)
        if (Array[i] % 2 == 0)
        SumNegativ += Array[i];
    
    Console.WriteLine($"Сумма нечётных чисел в массиве: {SumNegativ}"); 
}


Console.WriteLine("Введите число: ");
int user_num = Convert.ToInt32(Console.ReadLine());

int [] ShowArray = CreatNewArray(user_num);
Summ (ShowArray);
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreatNewArray(int size, int maxVal, int minVal)
{
    double [] isArray = new double [size]; 
    {
    for (int i = 0; i < size; i++)
    
        isArray[i] = new Random(). Next(minVal, maxVal + 1) / 100; 
    }
    return isArray;
}

void Difference(double[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        double max = 0;
        double min = 0;

        if (Array[i] > max)
        {
        max = Array[i];
        }
        if (Array[i] < min)
        {
        min = Array[i];
        }
        Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
    }
}
Console.WriteLine("Введите размер массива : ");
int user_num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] ShowArray = CreatNewArray(user_num, max, min);
Difference (ShowArray);
*/
