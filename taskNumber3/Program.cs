// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if(num % 7 == 0 && num % 23 == 0){
    Console.WriteLine($"Число {num} кратоно 7 и 23");
}
else{
    Console.WriteLine($"Число {num} некратоно 7 и 23");
}
