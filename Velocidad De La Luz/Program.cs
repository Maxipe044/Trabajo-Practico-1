const double Velocidad_Luz_KM = 299_792.458;
const double KM_Por_Milla_Nautica = 1.852;
Console.WriteLine("Distancia recorrida por la luz");
Console.Write("Ingrese el tiempo en segundos: ");
double segundos = double.Parse(Console.ReadLine());
double distanciaKm = Velocidad_Luz_KM * segundos;
double distanciaMillasNauticas = distanciaKm / KM_Por_Milla_Nautica;
Console.WriteLine($"Distancia en kilómetros:       {distanciaKm:N3} km");
Console.WriteLine($"Distancia en millas náuticas:  {distanciaMillasNauticas:N3} mn");