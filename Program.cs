void Task2()
{
    //Напишите программу, которая на вход принимает два числа и выдает 
    //какое число большее, а какое меньшее

    Console.WriteLine("Введите первое число: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int numberB = Convert.ToInt32(Console.ReadLine());

    if(numberA > numberB)
    {
        Console.WriteLine($"{numberA} > {numberB}");  
    }
    else 
    {
        Console.WriteLine($"{numberB} > {numberA}");
    }
}

void Task4()
{
    //Напишите программу, которая принимает на вход три числа
    //и выдает максимальное из этих чисел

    Console.WriteLine("Введите первое число: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число: ");
    int numberC = Convert.ToInt32(Console.ReadLine());
    int Max = numberA;
    if(numberB > Max)
    {
        Max = numberB;
    }
    if(numberC > Max) 
    {
        Max = numberC;
    }
    Console.WriteLine(Max); 
    }

void Task6()
{
    //Напишите программу, которая на вход принимает число и выдает, 
    //является ли число четным (делится ли оно на два без остатка)

    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number % 2 == 0)
    {
        Console.WriteLine($"Число {number} является четным");
    }
    else
    {
        Console.WriteLine($"Число {number} является не четным");
    }
}

void Task8()
{
    // Напишите программу, которая на вход принимает число (N > 0), а на выходе 
    // показывает все четные числа в промежутке от 1 до N

    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int counter = 2;
    while (counter <= number)
    {
        if (counter % 2 == 0)
        {
            Console.Write($"{counter} ");
        }
        counter++;
    }
    Console.WriteLine();
}




