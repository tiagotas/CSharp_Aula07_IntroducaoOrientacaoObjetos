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

            Console.WriteLine("__________________________________");

            Cachorro milu = new Cachorro();
            milu.Nome = "Milu do Tintin";
            milu.Raca = "Fox Terrier";
            milu.Correr();

            Console.WriteLine("__________________________________");


            /**
             * Faça uma classe e dessa classe crie 3 objetos para mapear características e
             * comportamentos de uma pessoa.
             */
            Pessoa p1 = new Pessoa();
            p1.Nome = "Henrique";
            p1.Estudar();
            p1.Andar();

            Pessoa p2 = new Pessoa();
            p2.Nome = "Styven";
            p2.Estudar();

            Pessoa p3 = new Pessoa();
            p3.Nome = "Ygor";
            p3.Estudar();

            /**
             * Faça uma classe e dessa classe crie 3 objetos para mapear características e
             * comportamentos de um gato. A clase deverá ter 4 métodos e 4 Propriedades.
             */
        }
    }
}
