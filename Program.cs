using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasPE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =============================================
            // CREACIÓN
            // =============================================
            List<int> lista = new List<int>();                          // Lista vacía
            List<int> desdeArray = new List<int>(new[] { 1, 2, 3 });   // Desde un array
            List<int> inicializada = new List<int> { 10, 20, 30, 40 }; // Inicializador de colección

            // =============================================
            // AGREGAR ELEMENTOS
            // =============================================
            lista.Add(1);                          // Agrega al final
            lista.AddRange(new[] { 2, 3, 4 });     // Agrega múltiples
            lista.Insert(0, 99);                   // Inserta en índice específico
            lista.InsertRange(1, new[] { 7, 8 });  // Inserta colección en índice

            // =============================================
            // ACCESO
            // =============================================
            int primero = inicializada[0];                  // Por índice
            int ultimo = inicializada[inicializada.Count - 1];
            int encontrado = inicializada.Find(x => x > 15); // Primer elemento que cumple condición
            List<int> varios = inicializada.FindAll(x => x > 15); // Todos los que cumplen condición

            // =============================================
            // BÚSQUEDA
            // =============================================
            bool existe = inicializada.Contains(20);
            int indice = inicializada.IndexOf(30);         // Primera ocurrencia (-1 si no existe)
            int ultimoIndice = inicializada.LastIndexOf(30);     // Última ocurrencia
            int indiceFind = inicializada.FindIndex(x => x > 15);
            int indiceLastF = inicializada.FindLastIndex(x => x < 40);
            bool alguno = inicializada.Exists(x => x > 35);

            // =============================================
            // ELIMINAR ELEMENTOS
            // =============================================
            List<int> copia = new List<int>(inicializada);
            copia.Remove(20);              // Elimina primera ocurrencia del valor
            copia.RemoveAt(0);             // Elimina por índice
            copia.RemoveRange(0, 2);       // Elimina rango (índice, cantidad)
            copia.RemoveAll(x => x > 25); // Elimina todos los que cumplen condición
            // copia.Clear();             // Elimina todos

            // =============================================
            // ORDENAMIENTO
            // =============================================
            List<int> nums = new List<int> { 5, 3, 8, 1, 9, 2 };
            nums.Sort();                                           // Orden ascendente (in-place)
            nums.Sort((a, b) => b.CompareTo(a));                  // Orden descendente
            nums.Reverse();                                        // Invierte el orden

            List<string> palabras = new List<string> { "banana", "apple", "cherry" };
            palabras.Sort(StringComparer.OrdinalIgnoreCase);       // Ignorar mayúsculas

            // =============================================
            // CONVERSIÓN Y PROYECCIÓN (LINQ)
            // =============================================
            int[] array = inicializada.ToArray();
            List<string> strs = inicializada.Select(x => x.ToString()).ToList();
            List<int> filtrada = inicializada.Where(x => x > 15).ToList();
            List<int> ordenada = inicializada.OrderByDescending(x => x).ToList();

            // =============================================
            // AGREGACIÓN (LINQ)
            // =============================================
            int suma = inicializada.Sum();
            int max = inicializada.Max();
            int min = inicializada.Min();
         
            // =============================================
            // PROPIEDADES ÚTILES
            // =============================================
            int total = inicializada.Count;    // Número de elementos
           
            // =============================================
            // ITERAR
            // =============================================
            // for clásico
            for (int i = 0; i < inicializada.Count; i++)
                Console.WriteLine(inicializada[i]);

            // foreach
            foreach (int item in inicializada)
                Console.WriteLine(item);

            // ForEach con lambda
            inicializada.ForEach(x => Console.WriteLine(x));

            // =============================================
            // VERIFICACIÓN
            // =============================================
            bool todosPositivos = inicializada.All(x => x > 0);   // Todos cumplen condición
            bool algunoGrande = inicializada.Any(x => x > 35);  // Al menos uno cumple

        }
    }
}
