Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 0) num = -num;


if(num > 9999 && num < 100000)
{
    int firstNum = num / 10000;
    int secondNum = num / 1000 % 10;
    
    int lastNum = num % 10;
    int penultNum = num % 100 / 10;

    if(firstNum == lastNum && secondNum == penultNum)
    {
        Console.Write("Введенное число является палиндромом");
    }
    else
    {
        Console.Write("Введенное число не является палиндромом");
    }
}
else
{
    Console.Write("Упс, Вы ввели неверное число :( ");
}

