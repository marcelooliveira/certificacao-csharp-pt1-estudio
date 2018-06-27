using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ConversoesImplicitas : IAulaItem
    {
        public void Executar()
        {
            ///2_147_483_647;

            ///< image url="$(ProjectDir)img12.png" />
           
        }
    }
}
//TABELA DE CONVERSÕES NUMÉRICAS IMPLÍCITAS
//=========================================

//De        Para
//=============================================================
//sbyte     short, int, long, float, double ou decimal
//byte      short, ushort, int, uint, long, ulong, float, double ou decimal
//short     int, long, float, double ou decimal
//ushort    int, uint, long, ulong, float, double ou decimal
//int       long, float, double ou decimal
//uint      long, ulong, float, double ou decimal
//long      float, double ou decimal
//char      ushort, int, uint, long, ulong, float, double ou decimal
//float     double
//ulong     float, double ou decimal
//double    (nenhum)
//decimal   (nenhum)
