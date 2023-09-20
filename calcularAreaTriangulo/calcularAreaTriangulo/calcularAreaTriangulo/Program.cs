// See https://aka.ms/new-console-template for more information

double baseT, altura, area;
string nombre;

Console.WriteLine("-- Calcular el área de un triángulo --");
Console.Write("Ingresa el nombre: ");
nombre = Console.ReadLine();
Console.Write("Ingresa la base: ");
baseT = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingresa la altura: ");
altura = Convert.ToDouble(Console.ReadLine());

area = (baseT * altura) / 2;

Console.Clear();
Console.WriteLine("El área del triángulo " + nombre + " es de: " + area);
Console.ReadKey();

