﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Interfaces : IAulaItem
    {
        public void Executar()
        {
            ///<image url="$(ProjectDir)img3.png" />

        }
    }
    
    class Televisao
    {
        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Abajur
    {
        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Lanterna
    {
        public double PotenciaDaLampada { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Radio
    {
        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }
}
