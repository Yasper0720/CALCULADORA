Console.WriteLine("¡Bienvenido a la calculadora!");

// Pedimos al usuario que ingrese el primer número
Console.Write("Ingrese el primer número: ");
double numero1;
while (!double.TryParse(Console.ReadLine(), out numero1))
{
    Console.Write("No ha ingresado un número válido. Por favor, inténtelo de nuevo: ");
}

// Pedimos al usuario que ingrese el segundo número
Console.Write("Ingrese el segundo número: ");
double numero2;
while (!double.TryParse(Console.ReadLine(), out numero2))
{
    Console.Write("No ha ingresado un número válido. Por favor, inténtelo de nuevo: ");
}

// Mostramos el menú de opciones
Console.WriteLine("Seleccione una operación:");
Console.WriteLine("1. Suma");
Console.WriteLine("2. Resta");
Console.WriteLine("3. División");
Console.WriteLine("4. Multiplicación");
Console.Write("Opción: ");
int opcion;
while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
{
    Console.Write("No ha ingresado una opción válida. Por favor, inténtelo de nuevo: ");
}
// Realizamos la operación correspondiente y mostramos el resultado
double resultado = 0;
switch (opcion)
{
    case 1:
        resultado = numero1 + numero2;
        break;


