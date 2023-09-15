
namespace Util
{
    public class CellUtility
    {
        public static string GetExcelColumnLetter(int columnNumber)
        {
            string columnLetter = "";
            while (columnNumber > 0)
            {
                int remainder = (columnNumber - 1) % 26;
                columnLetter = (char)('A' + remainder) + columnLetter;
                columnNumber = (columnNumber - 1) / 26;
            }
            return columnLetter;
        }
        public static int GetExcelColumnNumber(string columnLetter)
        {
            int columnNumber = 0;
            for (int i = 0; i < columnLetter.Length; i++)
            {
                columnNumber *= 26;
                columnNumber += columnLetter[i] - 'A' + 1;
            }
            return columnNumber;
        }
    }
}
