using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Abstratas
{
    class Carro : Veiculo
    {

        public Carro(string nome, float velocidade) : base(nome, velocidade)
        {
        }

        public override void Ligar()
        {
            Console.WriteLine($"{this.Nome}: VRUM");
        }
    }
}
