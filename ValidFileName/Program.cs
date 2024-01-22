using ValidFileName.FileAccess;

namespace ValidFileName
{
    internal class Program
    {
        /*
/ (スラッシュ)
           \ (バックスラッシュ)
           : (コロン)
           * (アスタリスク)
           ? (クエスチョンマーク)
           " (ダブルクォーテーション)
           < (小なり記号)
           > (大なり記号)
           | (パイプ)
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IValidFileName validFileName = new FileAccess.ValidFileName();

            string input = @"\:*?""<>|";

            Console.WriteLine(validFileName.MakeValidFileName(input));

            // Windowsファイル名に使えない文字のリストを表示する
            //  
            char[] invalid = Path.GetInvalidFileNameChars();
            Console.WriteLine(new string(invalid));

            Console.WriteLine($"'{validFileName.MakeValidFileName(new string(invalid))}'");

        }
    }
}
