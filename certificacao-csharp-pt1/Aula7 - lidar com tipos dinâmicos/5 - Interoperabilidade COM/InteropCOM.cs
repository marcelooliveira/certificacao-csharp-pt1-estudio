using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class InteropCOM : IAulaItem
    {
        public void Executar()
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Visible = true;
            excel.Workbooks.Add();

            Microsoft.Office.Interop.Excel._Worksheet planilha
                = (Microsoft.Office.Interop.Excel.Worksheet)excel.ActiveSheet;

            planilha.Cells[1, "A"] = "Alura";
            planilha.Cells[1, "B"] = "Cursos";
            planilha.Cells[2, "A"] = "Certificação";
            planilha.Cells[2, "B"] = "C#";
            planilha.Columns[1].AutoFit();
            planilha.Columns[2].AutoFit();
        }
    }
}
