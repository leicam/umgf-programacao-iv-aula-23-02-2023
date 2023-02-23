using Aula.Classes.Entidades;
using System;
using System.Linq;

namespace Aula.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var fiatMob = new FiatMob();
                var volkswagenUp = new VolkswagenUp();

                Console.WriteLine(fiatMob.ToString());
                Console.WriteLine(volkswagenUp.ToString());
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}