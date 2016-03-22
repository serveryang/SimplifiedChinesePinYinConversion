using Microsoft.International.Converters.PinYinConverter;

namespace System
{
    /// <summary>
    /// 扩展String类，用于获取汉字全拼或汉字首字母拼音。
    /// TODO: 无法实现对多音字正确语议下的拼音的提取。
    /// </summary>
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
                if (!ChineseChar.IsValidChar(word))
                {
                    pinyin += word.ToString();
                    continue;
                }

                var wordPinYin = SingleCharPinYin(word);
                pinyin += wordPinYin.Substring(0, wordPinYin.Length - 1);
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
                if (!ChineseChar.IsValidChar(word))
                {
                    pinYinAbbr += word.ToString();
                    continue;
                }

                string wordPinYin = SingleCharPinYin(word);
                pinYinAbbr += wordPinYin.Substring(0, 1);
            }

            return pinYinAbbr;
        }

        private static string SingleCharPinYin(char word)
        {
            var chineseChar = new ChineseChar(word);

            return chineseChar.Pinyins[0].ToString();
        }
    }
}