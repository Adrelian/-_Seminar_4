//Задача 1. Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.

//7 -> 28
//4 -> 10
//8 -> 36


// int FindSum (int number)
// {
//     int sum = 0;
//     for (int i = 0; i <= number; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }

// Console.WriteLine("Input number ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindSum(number));

//Задача 2.Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.

//456 -> 3
//78 -> 2
//89126 -> 5

// int Count(int number) // решение задачи первым способом
// {
//     int count = 0; // кол-во цифр
//     while (number > 0)
//     {
//         count++;
//         number = number/10;
//     }
//     return count;
// }
// Console.WriteLine("Input number ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Count(number));


// int Digits() // решение задачи вторым методом
// {
//     Console.Write("Введите число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     int count = 0;
//     for (count = 0; a > 0; count++){
//         a = a / 10;
//     }
//     return count;
// }
// Console.Write(Digits());


//Задача 3. Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.

//4  -> 24
//5  -> 120

// int Multy(int number) 
// {
//     int count = 1; // начало c 1 иначе будет всегда 0
//     for (int i = 1; i <= number; i++)
//     {
//         count = count * i;
//     }
//     return count;
// }
// Console.WriteLine("Input number ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Multy(number));

//Задача 4. Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

// void FillArray (int size)
// {
//     int [] array = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0, 2); //заполнение массива случайными числами, 2 обясзательно
//         Console.Write($"{array[i]} ");
//     }
// }

// FillArray(8);

// Другой способ решения задачи 4

int[] CreatRandomArray (int size, int min, int max) //заполнение массива
{
    int [] newArray = new int [size]; // инициализация массива
    for (int i = 0; i < size; i++)
    {
    newArray[i] = new Random().Next(min, max + 1); //Заполняем массив, +1 т.к. последнее число не входит в диапозон

    }
    return newArray; //вернуть массив    
}

void ShowArray (int [] arr)
{
    
    Console.Write("Массив -> ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+" ");
    }
    Console.WriteLine();
}

Console.WriteLine("Input size ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min ");
int min= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreatRandomArray(size, min, max);
ShowArray(myArray);