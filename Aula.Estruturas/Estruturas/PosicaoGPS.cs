using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula.Estruturas
{
    /// <summary>
    /// Ter mais de um construtor declarado em uma estrutura
    /// .NET 6 ou acima
    /// as variaveis devem estar instanciadas
    /// as variaveis devem receber valor no construtor
    /// </summary>
    internal struct PosicaoGPS
    {
        private int _latitude = int.MinValue;
        private int _longitude = int.MaxValue;

        public PosicaoGPS() { }

        internal PosicaoGPS(int latitude, int longitude)
        {
            _latitude = latitude;
            _longitude = longitude;
        }

        internal PosicaoGPS(int latitude)
        {
            _latitude = latitude;
        }

        internal bool IsEmisferioNorte()
            => _latitude > 0;
    }
}