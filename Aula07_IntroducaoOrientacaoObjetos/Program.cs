using System;
using System.Net.Http.Headers;

namespace Aula07_IntroducaoOrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um novo objeto a partir da classe Cachorro
            // O novo objeto "está dentro" da variável rex.
            Cachorro rex = new Cachorro();
            rex.Nome = "Rex da Silva";
            rex.Raca = "Pinscher";
            rex.Latir();
            rex.Correr();
            rex.Morder();


            Cachorro milu = new Cachorro();
            milu.Nome = "Milu do Tintin";
            milu.Raca = "Fox Terrier";
            milu.Correr();
        }
    }
}
