using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Http;

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
}