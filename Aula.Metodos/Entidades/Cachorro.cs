using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula.Metodos.Entidades
{
    internal sealed class Cachorro
    {
        private Cachorro() { }

        internal static Cachorro Create() 
            => new Cachorro();

        internal string Latir()
            => "AU AU";

        internal string Latir(string mensagem)
            => mensagem + " AU AU";

        internal string FicarFeliz(
            string mensagem = "ABANOU O RABO")
            => "AU AU " + mensagem;

        internal string FezAlgumaCoisa(string primeiraAcao,
            string segundaAcao)
        {
            var mensagem = string.Empty;

            if (!string.IsNullOrWhiteSpace(primeiraAcao))
                mensagem = $"AU AU {primeiraAcao} \n";
            
            if (!string.IsNullOrWhiteSpace(segundaAcao))
                mensagem += $"AU AU {segundaAcao}";

            return mensagem;
        }
    }
}