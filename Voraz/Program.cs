namespace Voraz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var elementos = new List<MochilaArticulo>
        {
            new MochilaArticulo { Valor = 60, Peso = 10 },
            new MochilaArticulo { Valor = 100, Peso = 20 },
            new MochilaArticulo { Valor = 120, Peso = 30 }
        };

            int capacidad = 50;

            var (solution, total) = MochilaCodiciosa.Solve(elementos, capacidad);

            Console.WriteLine("Elementos seleccionados:");
            foreach (var item in solution)
            {
                Console.WriteLine($"Valor: {item.Valor}, Peso: {item.Peso}");
            }
            Console.WriteLine($"Valor total: {total}");
        }

        public class MochilaArticulo
        {
            public int Valor { get; set; }
            public int Peso { get; set; }
            public double Relacion => (double)Valor / Peso;
        }

        public class MochilaCodiciosa
        {
            public static (List<MochilaArticulo>, int) Solve(List<MochilaArticulo> elementos, int capacidad)
            {
                // Ordenar elementos por relación valor/peso descendente
                var elementosOrdenados = elementos.OrderByDescending(i => i.Relacion).ToList();

                List<MochilaArticulo> elementosSeleccionados = new List<MochilaArticulo>();
                int totalValor = 0;
                int capacidadRestante = capacidad;

                foreach (var item in elementosOrdenados)
                {
                    if (item.Peso <= capacidadRestante)
                    {
                        elementosSeleccionados.Add(item);
                        totalValor += item.Valor;
                        capacidadRestante -= item.Peso;
                    }
                }

                return (elementosSeleccionados, totalValor);
            }
        }
    }
}
