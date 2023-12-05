using DocumentFormat.OpenXml.Office2010.CustomUI;
using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

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
}


