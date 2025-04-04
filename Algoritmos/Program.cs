using System;

namespace Algoritmos
{
    public class Program
    {
        static void Main()
        {
            int[] data = { 12, 17, 16, 8, 67, 1, 4 };
            Console.WriteLine("Arreglo original: " + string.Join(", ", data));

            MergeSort.Sort(data);

            Console.WriteLine("Arreglo ordenado: " + string.Join(", ", data));
        }
    }

    public class MergeSort
    {
        // Método principal para iniciar el ordenamiento
        public static void Sort(int[] array)
        {
            if (array.Length <= 1) return;
            MergeSortAlg(array, 0, array.Length - 1);
        }

        // Método recursivo de división
        private static void MergeSortAlg(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2; // Punto medio del subarreglo
                MergeSortAlg(array, left, mid);   // Ordenar mitad izquierda
                MergeSortAlg(array, mid + 1, right); // Ordenar mitad derecha
                Merge(array, left, mid, right);   // Combinar mitades ordenadas
            }
        }

        // Método de fusión de subarreglos
        private static void Merge(int[] array, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1];
            int i = left, j = mid + 1, k = 0;

            // Comparar elementos de ambas mitades
            while (i <= mid && j <= right)
            {
                if (array[i] <= array[j])
                    temp[k++] = array[i++];
                else
                    temp[k++] = array[j++];
            }

            // Copiar elementos restantes de la izquierda
            while (i <= mid)
                temp[k++] = array[i++];

            // Copiar elementos restantes de la derecha
            while (j <= right)
                temp[k++] = array[j++];

            // Transferir elementos al array original
            Array.Copy(temp, 0, array, left, temp.Length);
        }
    }
}
