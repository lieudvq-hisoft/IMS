using DocumentFormat.OpenXml.Office2010.Word;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using NPOI.XWPF.UserModel;

namespace Services.Utilities;
public static class DocumentHelper
{
    public static void RenderText(this WordprocessingDocument document, string dest, string text)
    {
        var body = document.MainDocumentPart.Document.Body;

        foreach (var textElement in body.Descendants<Text>())
        {
            if (textElement.Text.Contains(dest))
            {
                // Replace the old text with the new text
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

                if (checkbox != null)
                {
                    checkbox.Checked.Val = OnOffValues.True;
                    document.MainDocumentPart.Document.Save();
                    break;
                }
            }
        }
    }
}

