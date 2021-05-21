using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Abstratas
{
    class Retroescavadeira : Trator, IRetroescavadeira
    {
        public Retroescavadeira(string nome, float velocidade) : base(nome, velocidade)
        {
        }

        public void Escavar()
        {
            Console.WriteLine($"Retroescavadeira {this.Nome}, escavando...");
        }

        public override void Guinchar(IVeiculo v)
        {
            Console.WriteLine($"Retroescavadeira {this.Nome}, guinchando {v.Nome}");
        }

        public override void Ligar()
        {
            Console.WriteLine($"{this.Nome}: VRAAM");
        }
    }
}
