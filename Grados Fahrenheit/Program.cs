Console.WriteLine("Grados Fahrenheit");
Console.Write("Ingrese temperatura en grados Celsius: ");
sbyte Celsius = Convert.ToSByte(Console.ReadLine());
short Fahrenheit = (short)(Celsius * 9 / 5 + 32);
Console.WriteLine("La temperatura en grados Fahrenheit es: " + Fahrenheit);