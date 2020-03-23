using System.Collections.Generic;
using System.IO;
using BlazingPizza.Shared.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace BlazingPizza.Client.Report
{
    public class RptPerson
    {
        //#region Declararion

        //private int _maxColumn = 3;
        //private Document _document;
        //private PdfPTable _pdfTable = new PdfPTable(3);
        //private PdfPCell _PdfPCell;
        //private Font _fontStyle;
        //private MemoryStream _memoryStream = new MemoryStream();
        //private List<Person> _oPeople = new List<Person>();

        //#endregion Declararion

        //public byte[] Report(List<Person> oPeople)
        //{
        //    _oPeople = oPeople;
        //    _document = new Document(PageSize.A4, 10f, 10f, 20f, 30f);
        //    _pdfTable.WidthPercentage = 100;
        //    _pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
        //    _fontStyle = FontFactory.GetFont("Tahoma", 8f, 1);
        //    PdfWriter.GetInstance(_document, _memoryStream);
        //    _document.Open();

        //    float[] sizes = new float[_, _maxColumn];
        //    for (var i = 0; i < _maxColumn; i++)
        //    {
        //        if (i == 0) sizes[i] = 50;
        //        else sizes[i] = 100;
        //    }

        //    _pdfTable.SetWidths(sizes);

        //    this.ReportHeader();
        //    this.ReportBody();

        //    _pdfTable.HeaderRows = 2;
        //    _document.Add(_pdfTable);
        //    _document.Close();
        //    return _memoryStream.ToArray();
        //}

        //private void ReportHeader()
        //{
        //    _fontStyle = FontFactory.GetFont("Tahoma", 18f, 1);
        //    _PdfPCell = new PdfPCell(new Phrase("Id", _fontStyle));
        //    _PdfPCell.Colspan = _maxColumn;
        //    _PdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
        //    _PdfPCell.Border = 0;
        //    _PdfPCell.ExtraParagraphSpace = 0;
        //    _pdfTable.AddCell(_PdfPCell);
        //    _pdfTable.CompleteRow();

        //    _PdfPCell = new PdfPCell(new Phrase("Name", _fontStyle));
        //    _PdfPCell.Colspan = _maxColumn;
        //    _PdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
        //    _PdfPCell.Border = 0;
        //    _PdfPCell.ExtraParagraphSpace = 0;
        //    _pdfTable.AddCell(_PdfPCell);
        //    _pdfTable.CompleteRow();
        //}

        //private void ReportBody()
        //{
        //    _fontStyle = FontFactory.GetFont("Tahoma", 9f, 1);
        //    var fontStyle = FontFactory.GetFont("Tahoma", 9f, 0);

        //    #region Table Header
        //    _PdfPCell = new PdfPCell(new Phrase("Id", _fontStyle));
        //    _PdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
        //    _PdfPCell.VerticalAlignment = Element.ALIGN_CENTER;
        //    _PdfPCell.BackgroundColor = BaseColor.Gray;
        //    _pdfTable.AddCell(_PdfPCell);

        //    _PdfPCell = new PdfPCell(new Phrase("Name", _fontStyle));
        //    _PdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
        //    _PdfPCell.VerticalAlignment = Element.ALIGN_CENTER;
        //    _PdfPCell.BackgroundColor = BaseColor.Gray;
        //    _pdfTable.AddCell(_PdfPCell);

        //    _PdfPCell = new PdfPCell(new Phrase("StateId", _fontStyle));
        //    _PdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
        //    _PdfPCell.VerticalAlignment = Element.ALIGN_CENTER;
        //    _PdfPCell.BackgroundColor = BaseColor.Gray;
        //    _pdfTable.AddCell(_PdfPCell);


        //    _pdfTable.CompleteRow();
        //    #endregion

        //    #region Table Body
        //    int nSL = 1;
        //    foreach (var oPerson in _oPeople)
        //    {
        //        _PdfPCell = new PdfPCell(new Phrase(nSL++.ToString(), fontStyle));
        //        _PdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
        //        _PdfPCell.VerticalAlignment = Element.ALIGN_CENTER;
        //        _PdfPCell.BackgroundColor = BaseColor.White;
        //        _pdfTable.AddCell(_PdfPCell);

        //        _PdfPCell = new PdfPCell(new Phrase(oPerson.Id.ToString(), fontStyle));
        //        _PdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
        //        _PdfPCell.VerticalAlignment = Element.ALIGN_CENTER;
        //        _PdfPCell.BackgroundColor = BaseColor.White;
        //        _pdfTable.AddCell(_PdfPCell);

        //        _PdfPCell = new PdfPCell(new Phrase(oPerson.Name, fontStyle));
        //        _PdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
        //        _PdfPCell.VerticalAlignment = Element.ALIGN_CENTER;
        //        _PdfPCell.BackgroundColor = BaseColor.White;
        //        _pdfTable.AddCell(_PdfPCell);

        //        _pdfTable.CompleteRow();

        //    }

        //    #endregion
        //}

    }
}