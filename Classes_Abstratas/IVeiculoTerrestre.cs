using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Abstratas
{
    interface IVeiculoTerrestre: IVeiculo
    {
        int Rodas { get; }

    }
}
