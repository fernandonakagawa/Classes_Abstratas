using System;
using System.Collections.Generic;

namespace Classes_Abstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Fusca", 90);
            //Veiculo v1 = new Veiculo();
            //IVeiculo iv1 = new IVeiculo();
            IVeiculo iv2 = new Carro("Ferrari", 290);
            Veiculo v2 = new Carro("Gol", 140);

            c1.Ligar();
            iv2.Ligar();
            v2.Ligar();

            Trator t1 = new Trator("John Deere", 20);
            t1.Ligar();
            t1.Locomover(10);
            t1.Guinchar(c1);

            Retroescavadeira r1 = new Retroescavadeira("Hyundai", 10);
            r1.Ligar();
            r1.Locomover(100);
            r1.Escavar();
            r1.Guinchar(iv2);

            List<IVeiculo> lista = new List<IVeiculo>();
            lista.Add(c1);
            lista.Add(r1);
        }
    }
}
