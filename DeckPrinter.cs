using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using PdfSharp.Pdf;

namespace MTGDeckBuilder.DeckPrinter
{
  class DeckPrinter
  {
    private void CreatePDF(string _sCardImage)
    {
      //297×210 A4
      //88x63 Card
      //264x189 9Cards
      Document document = new Document();
      Section section = document.AddSection();
      section.PageSetup.BottomMargin = "1.0cm";
      section.PageSetup.TopMargin = "1.0cm";
      section.PageSetup.LeftMargin = "0.65cm";
      section.PageSetup.RightMargin = "0.65cm";

      var table = section.AddTable();
      table.Borders.Color = new MigraDoc.DocumentObjectModel.Color(0, 0, 0);
      var ColumnLeft = table.AddColumn("0.5cm");
      var Column0 = table.AddColumn("6.315cm");
      var Column1 = table.AddColumn("6.315cm");
      var Column2 = table.AddColumn("6.315cm");
      var ColumnRight = table.AddColumn("0.5cm");
      var topRow = table.AddRow();
      topRow.Height = "0.5cm";
      //[TODO] Split proxies in 9x9 pages and then add a 9x9 back images
      for (int i = 0; i < 3; ++i)
      {
        var tableRow = table.AddRow();
        //tableRow.Height = "8.8cm";
        for (int j = 1; j < 4; ++j)
        {
          var cell = tableRow.Cells[j];
          var par = cell.AddParagraph();
          par.Format.SpaceAfter = "-0.07cm";
          par.Format.LeftIndent = "-0.12cm";
          cell.Shading.Color = new MigraDoc.DocumentObjectModel.Color(0, 0, 0);
          var card = par.AddImage(_sCardImage);
          card.Width = "6.3cm";
          card.Height = "8.8cm";
        }
      }
      var bottomRow = table.AddRow();
      bottomRow.Height = "0.5cm";
      document.UseCmykColor = true;
      const bool unicode = false;
      const PdfFontEmbedding embedding = PdfFontEmbedding.Always;
      // ========================================================================================
      // Create a renderer for the MigraDoc document.
      PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(unicode, embedding);
      // Associate the MigraDoc document with a renderer
      pdfRenderer.Document = document;
      // Layout and render document to PDF
      pdfRenderer.RenderDocument();
      // Save the document...
      string filename = _sCardImage.Replace(".png", ".pdf");
      pdfRenderer.PdfDocument.Save(filename);
    }
  }
}
