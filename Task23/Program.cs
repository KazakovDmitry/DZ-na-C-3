/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumber(string message){
        int result = 0;
    while (true){
            Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result)){
            break;
        }        
        else{    
            Console.WriteLine("Вы ввели некорректное число");
        }
    }
    return result;
}

int number = GetNumber("Введите число: ");
Console.WriteLine($"Таблица кубов чисел от 1 до {number}: ");
for (int i = 1; i <= number; i++)
{
    Console.WriteLine(i * i * i);
}