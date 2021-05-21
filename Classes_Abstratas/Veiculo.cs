using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Abstratas
{
    abstract class Veiculo : IVeiculo
    {
        public string _nome;
        public float _velocidade;
        public string Nome { get => _nome; private set => _nome = value; }

        public float Velocidade { get => _velocidade; set => _velocidade = value; }
        public abstract void Ligar();
        public virtual float Locomover(float tempo)
        {
            return tempo * Velocidade;
        }

        protected Veiculo(string nome, float velocidade)
        {
            Nome = nome;
            Velocidade = velocidade;
        }
    }
}
