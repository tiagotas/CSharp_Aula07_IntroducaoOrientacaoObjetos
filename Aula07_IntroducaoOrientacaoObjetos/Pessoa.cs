using System;
using System.Collections.Generic;
using System.Text;

namespace Aula07_IntroducaoOrientacaoObjetos
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public double Peso;
        public double Altura;

        public void Estudar()
        {
            Console.WriteLine("{0} Está estudando.", Nome);
        }
        public void Dormir()
        {
            Console.WriteLine("{0} Está dormindo.", Nome);
        }

        public void Andar()
        {
            Console.WriteLine("{0} Está andando.", Nome);
        }
    }
}
