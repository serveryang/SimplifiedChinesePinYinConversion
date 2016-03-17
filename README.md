Simplified Chinese PinYin Conversion
=============
   Using Microsoft.International.Converters.PinYinConverter to
   convert simplified chinese to pin yin or first letters of pin yin.

## Usage
* Install package from nuget.
    ```
    Install-Package SimplifiedChinesePinYinConversion
    ```

* Add `using System;` in source code.

* Code snippet for asp.net 5
    ```
    #if DNX451
            string chineseWords = "世界你好";
            string full = chineseWords.ToPinYin();         // output: SHIJIENIHAO
            string abbr = chineseWords.ToPinYinAbbr();     // output: SJNH
    #endif
    ```