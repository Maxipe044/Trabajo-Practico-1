Console.WriteLine("Grados Fahrenheit");
Console.Write("Ingrese temperatura en grados Celsius: ");
sbyte celsius = Convert.ToSByte(Console.ReadLine());
short fahrenheit = (short)(celsius * 9 / 5 + 32);
Console.WriteLine("La temperatura en grados Fahrenheit es: " + fahrenheit);