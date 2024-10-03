// See https://aka.ms/new-console-template for more information
try
{
Console.WriteLine("Введите значение H");
int H = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение R");
int R = int.Parse(Console.ReadLine());
double V= Math.PI * Math.Pow(R,2)* H;
double V2 = (Math.PI * Math.Pow(R,2) * H)/3;
Console.WriteLine($"Объем конуса V2={V2:F2}");
Console.WriteLine($"Объем цилиндра V={V:F2}");
}
catch
{
    
}