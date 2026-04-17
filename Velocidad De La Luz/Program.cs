const double Velocidad_Luz_KM = 299_792.458;
const double km_milla_nautica = 1.852;
Console.WriteLine("Distancia recorrida por la luz");
Console.Write("Ingrese el tiempo en segundos: ");
double segundos = double.Parse(Console.ReadLine());
double distanciaKm = Velocidad_Luz_KM * segundos;
double distanciaMillasNauticas = distanciaKm / km_milla_nautica;
Console.WriteLine($"Distancia en kilómetros:       {distanciaKm:N3} km");
Console.WriteLine($"Distancia en millas náuticas:  {distanciaMillasNauticas:N3} mn");