using System;

namespace Prova3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] medicamentos = {"omelprazol", "paracetamol", "dipirona", "amoxicilina", "doril", "buscopan" };
            
            
            

            Console.WriteLine("Qual remedio quer pesquisar: ");
           string pesquisa =Console.ReadLine().ToLower();
            int index = Array.IndexOf(medicamentos, pesquisa);
            Console.WriteLine($"O remédio pesquisado foi: {pesquisa}, e está na posição: {index}");

            Console.WriteLine("Total de elementos no Array: "+medicamentos.Length);
            Console.WriteLine(" ");
            Array.Sort(medicamentos);

            Console.WriteLine("Em ordem alfabetica os remédio são: ");
            foreach(string medicamento in medicamentos)
            {
                Console.WriteLine(medicamento);
            }
               
        }
    }
}
