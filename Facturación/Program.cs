Console.WriteLine("Facturación");
Console.Write("Ingrese el valor de su producto: ");
double producto = double.Parse(Console.ReadLine());
Console.Write("Ingrese el porcentaje de utilidad que deseado: ");
double utilidad = double.Parse(Console.ReadLine());
utilidad = utilidad / 100;
double Iva = 0.21;
double precioVenta = producto + (producto * utilidad) + (producto * Iva);
Console.WriteLine($"El precio de venta del producto es: {precioVenta}");