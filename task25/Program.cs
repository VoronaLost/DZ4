// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

double inputnumber(string letter)
{
    bool isNumber = false;
    Console.WriteLine($"Введите {letter}: ");
    double finalNumber=0;
    while (isNumber == false)
        {
        string input = Console.ReadLine();
        isNumber = double.TryParse(input, out finalNumber);
        if (isNumber==false)
        Console.WriteLine($" Неверный формат, введите {letter}");
        }
    return finalNumber;
}

double degree(double numberA, int numberB)
{   double a = numberA;
    for (int i=1; i < numberB; i++) a = a*a;
    return a;
}

void result(double A, int B, double C)
{
    Console.WriteLine($"({A})^{B} = {C}");
}

double A = inputnumber("число");
double B = inputnumber("натуральную степень числа");

while (B <1 || B % 1 != 0)
    {
    Console.WriteLine($"Ошибка, введенная степень не является натуральным числом");
    B = inputnumber("натуральную степень числа");
    }
double finalRes = degree(A,(int)B);
result(A, (int)B, finalRes);