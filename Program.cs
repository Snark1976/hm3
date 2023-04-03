bool flag = true;
while  (flag)
{
    Console.Write("Введите номер задачи (19, 21 или 23) для проверки или все, что угодно, для выхода: ");
    switch (Console.ReadLine())
    {
        case "19": 
            Task19(); 
            break;
        case "21":
            Task21();
            break;
        case "23":
            Task23();
            break;
        default: 
            flag = false;
            break;
    };
}

static void Task19()
{
    Console.Write("Введите любое число: ");
    string number = Console.ReadLine()!;
    string answer = number == new string(number.Reverse().ToArray()) ? "Это палиндром" : "Это не палиндром";
    Console.WriteLine(answer);
}

static void Task21()
{
    Console.Write("\nВведите координаты первой точки (разделитель - пробел): ");
    double[] point1 = Console.ReadLine()!.Split(' ').Select( x => Convert.ToDouble(x)).ToArray();
    Console.Write("\nВведите координаты второй точки (разделитель - пробел): ");
    double[] point2 = Console.ReadLine()!.Split(' ').Select( x => Convert.ToDouble(x)).ToArray();
    Console.WriteLine($"D = {Math.Sqrt(point1.Zip(point2, (first, second) => Math.Pow(first - second, 2)).Sum())}");
}

static void Task23()
{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine()!);
    for (int i = 1; i <= num; i++)
        Console.WriteLine($"{i * i * i} ");
}
