using Microsoft.International.Converters.PinYinConverter;

namespace System
{
    public static class StringExtension
    {
        /// <summary>
        /// 获取汉字全拼
        /// </summary>
        /// <param name="chineseWords">中文汉字</param>
        /// <returns>汉字全拼</returns>
        public static string ToPinYin(this string chineseWords)
        {
            string pinyin = string.Empty;

            foreach (char word in chineseWords)
            {
                try
                {
                    var chineseChar = new ChineseChar(word);
                    var wordPinYin = chineseChar.Pinyins[0].ToString();
                    pinyin += wordPinYin.Substring(0, wordPinYin.Length - 1);
                }
                catch
                {
                    pinyin += word.ToString();
                }
            }

            return pinyin;
        }

        /// <summary>
        /// 获取汉字全拼的第一个字母。
        /// </summary>
        /// <param name="chineseWords">中文汉字</param>
        /// <returns>拼音首字母</returns>
        public static string ToPinYinAbbr(this string chineseWords)
        {
            string pinYinAbbr = string.Empty;

            foreach (char word in chineseWords)
            {
                try
                {
                    ChineseChar chineseChar = new ChineseChar(word);
                    string currentWordPinYin = chineseChar.Pinyins[0].ToString();
                    pinYinAbbr += currentWordPinYin.Substring(0, 1);
                }
                catch
                {
                    pinYinAbbr += word.ToString();
                }
            }

            return pinYinAbbr;
        }
    }
}