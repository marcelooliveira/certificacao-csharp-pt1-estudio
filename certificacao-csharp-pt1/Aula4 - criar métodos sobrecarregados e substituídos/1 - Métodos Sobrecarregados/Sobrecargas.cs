using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Sobrecargas : IAulaItem
    {
        public void Executar()
        {
            ///<image url="$(ProjectDir)img7.png" />
            //VOLUME DO CUBO = lado ^ 3;
            int lado = 3;

            

            ///<image url="$(ProjectDir)img8.png" />
            //VOLUME DO CILINDRO = altura * PI * raio ^ 2;
            double raio = 2;
            int altura = 10;


            

            ///<image url="$(ProjectDir)img9.png" />
            //VOLUME DO PRISMA = largura * profundidade * altura
            long largura = 10;
            altura = 6;
            int profundidade = 4;
        }
    }
}
