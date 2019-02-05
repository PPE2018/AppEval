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
        public static void EditerBrochure(string nomCandidat, string prenomCandidat, List<Evaluation> lesEvaluations)
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(nomCandidat + "-" + prenomCandidat +".pdf", FileMode.Create));
            document.Open();

            PdfContentByte cb = writer.DirectContent;
            cb.BeginText();
            BaseFont bf = BaseFont.CreateFont("C:\\WINDOWS\\FONTS\\ARIAL.TTF", BaseFont.CP1252, true);
            
            //on instancie une police Arial avec BaseFont 
            cb.SetFontAndSize(bf, 20f);
            cb.SetTextMatrix(100, 750);
            cb.ShowText("FICHE INDIVIDUELLE DE CANDIDATURE");
            cb.EndText();

            cb.BeginText();
            cb.SetFontAndSize(bf, 17f);
            cb.SetTextMatrix(100, 650);
            cb.ShowText("Candidat");
            cb.EndText();

            cb.BeginText();
            cb.SetFontAndSize(bf, 15f);
            cb.SetTextMatrix(100, 600);
            cb.ShowText("Nom :");
            cb.EndText();

            cb.BeginText();
            cb.SetFontAndSize(bf, 12f);
            cb.SetTextMatrix(100, 575);
            cb.ShowText(nomCandidat);
            cb.EndText();

            cb.BeginText();
            cb.SetFontAndSize(bf, 15f);
            cb.SetTextMatrix(200, 600);
            cb.ShowText("Prenom :");
            cb.EndText();

            cb.BeginText();
            cb.SetFontAndSize(bf, 12f);
            cb.SetTextMatrix(200, 575);
            cb.ShowText(prenomCandidat);
            cb.EndText();

            PdfPTable table = new PdfPTable(3);
            float[] widths = new float[] { 1.5f, 1f, 3f};
            table.SetWidths(widths);
            PdfPCell cell = new PdfPCell(new Phrase("Evaluateurs"));
            cell.Colspan = 3;
            table.SpacingBefore = 100;
            cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right

            table.AddCell(cell);
            table.AddCell("Evaluations");
            table.AddCell("Note");
            table.AddCell("Commentaire");
            foreach (Evaluation e in lesEvaluations)
            {
                table.AddCell(e.GetNomPrenomRH());
                table.AddCell(e.NoteTotal().ToString());
                table.AddCell(e.GetCommentaire());
            }
            Paragraph monParaph1 = new Paragraph();
            monParaph1.Add(table);
            document.Add(monParaph1);
            document.Close();
        }
    }
}
