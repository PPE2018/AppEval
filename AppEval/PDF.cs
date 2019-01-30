using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEval
{
    public static class PDF
    {
        public static void EditerBrochure(string nomCandidat)
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(nomCandidat + ".pdf", FileMode.Create));
            document.Open();
            PdfContentByte cb = writer.DirectContent;
            cb.BeginText();
            BaseFont bf = BaseFont.CreateFont("C:\\WINDOWS\\FONTS\\ARIAL.TTF", BaseFont.CP1252, true);
            
            //on instancie une police Arial avec BaseFont 
            cb.SetFontAndSize(bf, 20f);
            cb.SetTextMatrix(125, 750);
            cb.ShowText("FICHE INDIVIDUELLE DE CANDIDATURE");
            cb.EndText();
            document.Close();
        }
    }
}
