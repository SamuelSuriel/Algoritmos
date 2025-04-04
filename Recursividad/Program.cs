namespace Recursividad
{
    internal class Program
    {
             // Función recursiva para calcular el factorial de un número
        static long Factorial(int n)
        {
                       // Caso base: el factorial de 0 o 1 es 1
            if (n <= 1) 
                return 1;
            else 
                return n * Factorial(n - 1);  // Caso recursivo: n * factorial(n-1) 
        }

        static void Main(string[] args) 
        {
            Console.Write("Ingrese un número para calcular su factorial: ");
            string input = Console.ReadLine();
            int numero;

            // Validar la entrada 
            if (!int.TryParse(input, out numero))
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
            }
            else if (numero < 0)
            { 
                Console.WriteLine("Por favor, ingrese un número entero no negativo.");
            }
            else
            {
                // Calcular y mostrar el factorial
                long resultado = Factorial(numero);
                Console.WriteLine($"El factorial de {numero} es: {resultado}"); 
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
