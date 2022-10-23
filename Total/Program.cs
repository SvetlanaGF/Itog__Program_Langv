//Задача: написать программу, которая из имеющегося массива строк 
//формирует массив из строк,
//длина которых меньше или равна трем символам.

Console.Clear();
Console.WriteLine("Задача: Сформировать из имеющегося массива строк");
Console.WriteLine("массив из элементов не больше трех символов.\n");

Console.Write("Введите количество элементов массива:  ");
int countElement = int.Parse(Console.ReadLine());

string [] arrayStringInitial = new String [countElement];
int k = 0;
int countThreeSymbol = 0;

void InputArray (string [] arr)
{
    for (int i=0; i < countElement; i++)
    {
        Console.Write($"Введите {i+1} элемент массива:\t"); 
        arr [i] = Console.ReadLine();
    }
}

void OutPutArray (string [] arr)
{
    countElement = arr.Length;
    for (int i = 0; i < countElement; i++)
    {
        Console.Write($"\t'" + arr[i] + "'");
    }
    Console.WriteLine();
}

InputArray (arrayStringInitial);

Console.WriteLine("\nИсходный массив:"); 
OutPutArray (arrayStringInitial);

    for (int i = 1; i < countElement; i++)
    {
        if (arrayStringInitial[i].Length <= 3)
        {
            countThreeSymbol++;
        }
    }

string [] arrayStringThreeSymbol = new String [countThreeSymbol];
   
   for (int i = 0; i < countElement; i++)
    {
        if (arrayStringInitial[i].Length <= 3)
        {
            arrayStringThreeSymbol[k] = arrayStringInitial[i];
            k++;
        }
    }
Console.WriteLine($"\nВ нем элементов не больше 3 символов: {countThreeSymbol}"); 
OutPutArray(arrayStringThreeSymbol);
Console.WriteLine(); 