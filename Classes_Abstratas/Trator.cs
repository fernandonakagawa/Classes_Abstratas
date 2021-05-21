using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Abstratas
{
    class Trator : VeiculoTerrestre, IVeiculoTerrestre, ITrator
    {
        public Trator(string nome, float velocidade) : base(nome, velocidade)
        {
        }

        public override void Ligar()
        {
            Console.WriteLine($"{this.Nome}: VROOOOM");
        }

        public virtual void Guinchar(IVeiculo v)
        {
            Console.WriteLine($"Trator {this.Nome}, guinchando {v.Nome}");
        }
    }
}
