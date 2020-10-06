using System;
using System.Collections.Generic;
using System.Text;

namespace Aula07_IntroducaoOrientacaoObjetos
{
    public class Cachorro
    {
        // Propriedades da classe
        public int Patas;
        public string Focinho;
        public string Pelo;
        public string Nome;
        public string Raca;


        //Métodos (comportamentos/atividades) da classe

        public void Latir()
        {
            Console.WriteLine("O cachorro {0} da raça {1} está latindo.", Nome, Raca);
        }

        public void Morder()
        {
            Console.WriteLine("O cachorro {0} da raça {1} está mordendo.", Nome, Raca);
        }

        public void Dormir()
        {
            Console.WriteLine("O cachorro {0} da raça {1} está domindo.", Nome, Raca);
        }

        public void Correr()
        {
            Console.WriteLine("O cachorro {0} da raça {1} está correndo.", Nome, Raca);
        }
    }
}
