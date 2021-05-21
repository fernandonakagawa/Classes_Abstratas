using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Abstratas
{
    abstract class VeiculoTerrestre : Veiculo, IVeiculoTerrestre
    {
        private int _rodas;
        public int Rodas { get => _rodas; private set => _rodas = value; }
        protected VeiculoTerrestre(string nome, float velocidade) : base(nome, velocidade)
        {
        }

        

    }
}
