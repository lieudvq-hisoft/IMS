using Data.Models;
using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Http;
using IronPdf;
using ConvertApiDotNet;
using ConvertApiDotNet.Model;

namespace Services.Utilities;
public static class DocumentHelper
{
    private const string CHECKED_VALUE = "☒";
    private const string UNCHECKED_VALUE = "☐";

    public static void RenderText(this WordprocessingDocument document, string dest, string text)
    {
        var body = document.MainDocumentPart.Document.Body;

        foreach (var run in body.Descendants<Run>())
        {
            var textElement = run.Descendants<Text>().FirstOrDefault();
            if (textElement != null && textElement.Text.Contains(dest))
            {
                textElement.Text = textElement.Text.Replace(dest, text);
                break;
            }
        }
    }

    public static void TickCheckBoxInDocx(this WordprocessingDocument document, string dest)
    {

        var sdtElements = document.MainDocumentPart.Document.Descendants<SdtElement>();

        foreach (var sdtElement in sdtElements)
        {
            var tag = sdtElement.Descendants<Tag>().FirstOrDefault();

            if (tag != null && tag.Val == dest)
            {
                var checkbox = sdtElement.Descendants<SdtContentCheckBox>().FirstOrDefault();
                var textRun = sdtElement.Descendants<Run>().FirstOrDefault();

                if (checkbox != null)
                {
                    checkbox.Checked.Val = OnOffValues.True;

                    // Find and update the text within the Run
                    var text = textRun?.Descendants<Text>().FirstOrDefault();
                    if (text != null)
                    {
                        text.Text = CHECKED_VALUE;
                    }
                }
            }
        }
    }

    public static IFormFile ConvertToIFormFile(this WordprocessingDocument wordDocument, string fileName)
    {
        MemoryStream stream = new MemoryStream();

        // Copy the Word document content to the MemoryStream
        wordDocument.MainDocumentPart.Document.Save(stream);
        stream.Position = 0;

        // Create an IFormFile from the MemoryStream
        return new FormFile(stream, 0, stream.Length, "document", fileName);
    }

    public static void InsertToSingleTable(this WordprocessingDocument wordDocument, List<ReceiptReportModel> models)
    {
        var tables = wordDocument.MainDocumentPart.Document.Body.Descendants<Table>();
        Table chosenTable = null;
        foreach (var table in tables)
        {
            IEnumerable<TableProperties> tableProperties = table.Descendants<TableProperties>().Where(tp => tp.TableCaption != null);
            foreach (TableProperties tProp in tableProperties)
            {
                if (tProp.TableCaption.Val.Equals("Hardware")) // see comment, this is actually StringValue
                {
                    // do something for table with myCaption
                    chosenTable = (Table)tProp.Parent;
                }
            }
        }

        if (chosenTable != null)
        {
            // Iterate through the list and add a table row for each item
            foreach (ReceiptReportModel item in models)
            {
                TableRow newRow = new TableRow();

                // Add cells for each property
                TableCell cell1 = new TableCell(new Paragraph(new Run(new Text(item.PartNo.ToString()))));
                TableCell cell2 = new TableCell(new Paragraph(new Run(new Text(item.Model))));
                TableCell cell3 = new TableCell(new Paragraph(new Run(new Text(item.Action))));
                TableCell cell4 = new TableCell(new Paragraph(new Run(new Text(item.Quantity.ToString()))));
                TableCell cell5 = new TableCell(new Paragraph(new Run(new Text(item.Unit))));

                newRow.Append(cell1, cell2, cell3, cell4, cell5);

                // Add the new row to the table
                chosenTable.Append(newRow);
            }
        }
    }

    public async static Task ConvertToPDF(string wordFilePath, string pdfFilPath)
    {
        //xbKuA9Nht4nl9pLF
        //377277176
        var convertApi = new ConvertApi("xbKuA9Nht4nl9pLF");
        ConvertApiResponse result = await convertApi.ConvertAsync("docx", "pdf",
   new ConvertApiFileParam(wordFilePath)
);

        // save to file
        var fileInfo = await result.SaveFileAsync(pdfFilPath);
    }
}