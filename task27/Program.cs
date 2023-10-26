//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. (Без использования преобразований числа в строку)
int inputnumber(string letter)
{
    bool isNumber = false;
    Console.WriteLine($"Введите {letter}: ");
    int finalNumber=0;
    while (isNumber == false)
        {
        string input = Console.ReadLine();
        isNumber = int.TryParse(input, out finalNumber);
        if (isNumber==false)
        Console.WriteLine($" Неверный формат, введите {letter}");
        }
    return finalNumber;
}

void summ (int yourNumber)
{
int number = yourNumber; 
if (number < 0) number = -number;
int SummNumber = 0;
while (number !=0)
    {
        SummNumber = SummNumber + (number % 10);
        number = number/10;
    }
Console.WriteLine($"Сумма цифр в числе: {SummNumber}");
}

int number = inputnumber("любое целое число");
summ(number);