using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Metodos : IAulaItem
    {
        public void Executar()
        {
            Retangulo retangulo = new Retangulo(12, 10);
            ///Console.WriteLine($"retangulo.Area: {retangulo.GetArea()}");

            ///< image url="$(ProjectDir)img4.png" />

            ///< image url="$(ProjectDir)img5.png" />



            ///Retangulo outroRetangulo = new Retangulo(10, 10);
            ///Console.WriteLine("Retangulo outroRetangulo = new Retangulo(10, 10);");
            

            ///Console.WriteLine($"retangulo.Semelhante(outroRetangulo.Altura, outroRetangulo.Largura): " +
            ///    $"{retangulo.Semelhante(outroRetangulo.Altura, outroRetangulo.Largura)}");

            ///outroRetangulo = new Retangulo(5, 6);
            ///Console.WriteLine("Retangulo outroRetangulo = new Retangulo(5, 6);");

            ///Console.WriteLine($"retangulo.Semelhante(outroRetangulo.Altura, outroRetangulo.Largura): " +
            ///    $"{retangulo.Semelhante(outroRetangulo.Altura, outroRetangulo.Largura)}");
        }
    }

    ///public, internal, protected, private
    class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;

            ///Console.WriteLine($"altura: {altura}, largura: {largura}");

            ///var area = Altura * Largura;
            ///Console.WriteLine($"area: {area}");
        }

        ///public, internal, protected (+internal), private (+internal)
        bool Semelhante(double outroRetanguloAltura, double outroRetanguloLargura)
        {
            return
                ((Largura / Altura) == /*proporção deste retângulo*/
                (outroRetanguloLargura / outroRetanguloAltura)) /*proporção do outro retângulo*/
                ||
                ((Altura / Largura) == /*compara a proporção inversa*/
                (outroRetanguloLargura / outroRetanguloAltura));
        }

    }
}
