// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine() ?? "");
int b = int.Parse(Console.ReadLine() ?? "");
int c = int.Parse(Console.ReadLine() ?? "");
if(a>b && a>c){
    Console.WriteLine($"Максимальное число {a}");
}
else if (b>a && b>c){
    Console.WriteLine($"Максимальное число {b}");
}
else if (c>a && c>b){
    Console.WriteLine($"Максимальное число {c}");
}