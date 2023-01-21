/*Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

//Функция конвертации числа в массив
int [] ConvertToArray (string a)
{
    int [] array = new int [a.Length];
    for (int i = 0; i < a.Length; i++)
    {
        array[i] = int.Parse(a[i].ToString());
    }
    return array;
}

//Функция разворота массива
int[] ReverseArray (int[] arrayA)
{
    int[] arrayB = new int [arrayA.Length];
    for (int i = 0; i < arrayA.Length; i++)
    {
        arrayB [i] = arrayA [arrayA.Length - i - 1];
    }
    return arrayB;
}

Console.WriteLine("Введите пятизначное число: ");
int[] arrayA = ConvertToArray(Console.ReadLine());
int[] arrayB = ReverseArray(arrayA);
//проверка на полиндром
int z = 0;
for (int i = 0; i < arrayA.Length; i++)
{
    if (arrayA [i] == arrayB [i])    
        z = z + 1;
}

if ( z == 5)
    Console.WriteLine("Число является полиндромом");
else Console.WriteLine("Число НЕ является полиндромом или не пятизначное");
