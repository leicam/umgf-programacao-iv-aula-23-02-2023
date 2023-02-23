using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula.Classes.Entidades
{
    internal abstract class AbstractCarro
    {
        private const string C_MENSAGEM = "MARCA: {0} \nMODELO: {1} \n\n";
        private readonly string _marca = string.Empty;
        private readonly string _nome = string.Empty;

        protected AbstractCarro(string marca, string nome)
        {
            _marca = marca ?? throw new ArgumentNullException(nameof(marca));
            _nome = nome ?? throw new ArgumentNullException(nameof(nome));
        }

        /// <summary>
        /// Exemplos de manipulação string
        /// return _marca + " " + _nome;
        /// return $"{_marca} {_nome}";
        /// return string.Concat(_marca, " ", _nome);
        /// return string.Format(C_MENSAGEM, _marca, _nome);
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            => string.Format(C_MENSAGEM, _marca, _nome);
    }
}