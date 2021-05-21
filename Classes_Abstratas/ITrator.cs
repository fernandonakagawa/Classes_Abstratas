using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Abstratas
{
    interface ITrator:IVeiculoTerrestre
    {
        void Guinchar(IVeiculo v);
    }
}
