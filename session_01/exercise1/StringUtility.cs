using System.Text;

class StringUtility
{
    public static string SummarizeText(string text)
    {
        var textSum = "";
        if (text.Length > 20)
        {
            textSum = text.Substring(0, 20);

            textSum += "...";
        }
        return textSum;
    }


}