// See https://aka.ms/new-console-template for more information
int num = new Random().Next(100, 1000);
//int num2 = (num % 100) / 10;
Console.WriteLine(num);
int num1 = num / 100;
int num3 = num % 10;
int ans = num1 * 10 + num3;
Console.WriteLine(ans);

