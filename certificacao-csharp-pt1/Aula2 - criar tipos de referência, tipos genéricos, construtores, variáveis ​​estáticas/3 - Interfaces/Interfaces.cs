using System;
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
            //Televisao eletro1 = new Televisao();
            //eletro1 = new Abajur();

            IEletrodomestico eletro1 = new Televisao();
            eletro1.Ligou += Eletro1_Ligou;
            eletro1.Desligou += Eletro1_Desligou;
            eletro1.Ligar();
            eletro1.Desligar();
        }

        private void Eletro1_Desligou(object sender, EventArgs e)
        {
            Console.WriteLine("eletrodoméstico desligou");
        }

        private void Eletro1_Ligou(object sender, EventArgs e)
        {
            Console.WriteLine("eletrodoméstico ligou");
        }
    }

    interface IEletrodomestico
    {
        void Ligar();
        void Desligar();
        event EventHandler Ligou;
        event EventHandler Desligou;
    }

    interface IPotenciaLampada
    {
        int Potencia { get; set; }
    }

    interface IRadio
    {
        double FrequenciaSintonizada { get; set; }
    }

    class Televisao : IEletrodomestico, IRadio
    {
        public double FrequenciaSintonizada { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
            Desligou(this, new EventArgs());
        }

        public void Ligar()
        {
            Ligou(this, new EventArgs());
        }
    }

    class Abajur : IEletrodomestico, IPotenciaLampada
    {
        public int Potencia { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
            throw new NotImplementedException();
        }

        public void Ligar()
        {
            throw new NotImplementedException();
        }
    }

    class Lanterna : IEletrodomestico, IPotenciaLampada
    {
        public int Potencia { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
            throw new NotImplementedException();
        }

        public void Ligar()
        {
            throw new NotImplementedException();
        }
    }

    class Radio : IEletrodomestico, IRadio
    {
        public double FrequenciaSintonizada { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
            throw new NotImplementedException();
        }

        public void Ligar()
        {
            throw new NotImplementedException();
        }
    }
}
