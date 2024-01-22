using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidFileName.FileAccess
{
    public class ValidFileName : IValidFileName
    {
        private readonly char[] _invalidChars = Path.GetInvalidFileNameChars();

        public string MakeValidFileName(string input)
        {

            // コントロール文字を削除する
            input = new string(input.Where(c => !char.IsControl(c)).ToArray());

            // Windowsファイル名に使えない文字を置き換える
            foreach (char invalidChar in _invalidChars)
            {
                input = input.Replace(invalidChar,   (char)(invalidChar + 0xFEE0)); // 全角に変換
            }

            return input;
        }
    }
}
