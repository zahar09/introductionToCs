// 16 Напишите программу, которая принимает на вход два числа и проверяет,
    // является ли одно число квадратом другого.

    // 5, 25  ->  да
    // -4, 16  ->  да
    // 25, 5  ->  да
    // 8,9  ->  нет
Console.Clear();
Console.Write("Введите первое число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num1 = int.Parse(Console.ReadLine());

if(num * num == num1 || num1 * num1 == num){
    Console.WriteLine("Да, одно число является квадратом другого");
}
else{
    Console.WriteLine("Нет, одно число не является квадратом другого");
}