// See https://aka.ms/new-console-template for more information
int num = new Random().Next(1, 100);
int num1 = new Random().Next(1, 10);
Console.WriteLine(num);
Console.WriteLine(num1);
int remainder = num % num1;
if(remainder == 0){
    Console.WriteLine($"Число {num} кратно {num1}");
}
else{
    Console.WriteLine($"Число {num} не кратно {num1}, остаток {remainder}");
}
