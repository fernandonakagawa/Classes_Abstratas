using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Abstratas
{
    interface IVeiculo
    {
        string Nome { get; }
        float Velocidade{get;}
        void Ligar();
        float Locomover(float tempo);
    }
}
