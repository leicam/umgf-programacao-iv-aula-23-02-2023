namespace Aula.Estruturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var posicaoUmGPS = new PosicaoGPS();
            var posicaoDoisGPS = new PosicaoGPS(-15, 37);
            var posicaoTresGPS = new PosicaoGPS(37);

            Console.WriteLine(nameof(posicaoUmGPS) + " ESTÁ NO NORTE " 
                + posicaoUmGPS.IsEmisferioNorte());
            
            Console.WriteLine(nameof(posicaoDoisGPS) + " ESTÁ NO NORTE " 
                + posicaoDoisGPS.IsEmisferioNorte());
            
            Console.WriteLine(nameof(posicaoTresGPS) + " ESTÁ NO NORTE " 
                + posicaoTresGPS.IsEmisferioNorte());

        }
    }
}