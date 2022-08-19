Console.WriteLine("Задача 19");
Console.Write("Введите число: ");
string number = Console.ReadLine();

if (number.Length == 5)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}
else
{
    Console.WriteLine($"Введи правильное число");
}




