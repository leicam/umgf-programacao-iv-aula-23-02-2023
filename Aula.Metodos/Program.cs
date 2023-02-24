using Aula.Metodos.Entidades;

namespace Aula.Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cachoro = Cachorro.Create();

            Console
                .WriteLine(cachoro.Latir());
            Console
                .WriteLine(cachoro.FicarFeliz());
            Console
                .WriteLine(cachoro.FicarFeliz("PIÃO DO BÁU"));

            Console.WriteLine(cachoro
                .FezAlgumaCoisa("SENTOU", "DEU A PATINHA"));

            Console.WriteLine(cachoro
                .FezAlgumaCoisa(
                    segundaAcao:"SENTOU",
                    primeiraAcao: "DEU A PATINHA"));

            Console.WriteLine(cachoro
                .FezAlgumaCoisa("DEU A PATINHA", segundaAcao: "SENTOU"));

            Console.WriteLine(Cachorro
                .Create()
                .Latir()
                .ToLower());

            Console.ReadKey();

        }
    }
}