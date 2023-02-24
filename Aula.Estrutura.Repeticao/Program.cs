
namespace Aula.Estrutura.Repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<string>()
            {
                "Enzo",
                "Jacomelo",
                "Pedro",
            };

            Console.WriteLine("FOR");

            for (var i = 0; i < lista.Count;i++)
                Console.WriteLine(lista[i]);

            Console.WriteLine("\nFOREACH");

            foreach (var item in lista)
                Console.WriteLine(item);

            Console.WriteLine("\nFOREACH LINQ");
            lista.ForEach(x => { Console.WriteLine(x); });

            Console.WriteLine("\nWHILE");

            var contador = 0;
            while(contador < lista.Count)
            {
                Console.WriteLine(lista[contador]);
                contador++;
            }

            Console.WriteLine("\nDO WHILE");

            contador = 0;
            do
            {
                Console.WriteLine(lista[contador]);
                contador++;
            } while (contador < lista.Count);

            Console.ReadKey();
        }
    }
}