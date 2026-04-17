Console.WriteLine("División Entera");
Console.Write("Ingrese el primer número entero: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo número entero: ");
int num2 = int.Parse(Console.ReadLine());
if (num2 == 0)
{
   Console.WriteLine("Error: no se puede dividir por cero.");
    return;
}
int cociente = num1 / num2;
int resto = num1 % num2;
double divisionReal = (double)num1 / num2;
Console.WriteLine("Resultados de division:");
Console.WriteLine($"Cociente: {cociente}");
Console.WriteLine($"Resto: {resto}");
Console.WriteLine($"División real: {divisionReal}");