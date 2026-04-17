Console.WriteLine("Cotización Dólar");
Console.Write("Ingrese la cantidad de Dolares a convertir: ");
decimal dolares = decimal.Parse(Console.ReadLine());
Console.Write("Ingrese el valor del dólar en Pesos Argentinos: ");
decimal valorDolar = decimal.Parse(Console.ReadLine());
decimal total = dolares * valorDolar;
Console.WriteLine($"El valor total en Pesos Argentinos es: {total}");