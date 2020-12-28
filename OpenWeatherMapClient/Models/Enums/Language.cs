using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherMapClient.Models.Enums
{

    /// <summary>
    /// Supported languages as of 28.12.2020. To select one, you can use the corresponding language code
    /// </summary>
    public class Language
    {
        public string LanguageCode { get; set; }

        public Language()
        {
            LanguageCode = "en";
        }

        public Language(string language)
        {
            LanguageCode = language;
        }

        public static Language Afrikaans = new Language("af");
        public static Language Albanian = new Language("al");
        public static Language Arabic = new Language("ar");
        public static Language Azerbaijani = new Language("az");
        public static Language Bulgarian = new Language("bg");
        public static Language Catalan = new Language("ca");
        public static Language Czech = new Language("cz");
        public static Language Danish = new Language("da");
        public static Language German = new Language("de");
        public static Language Greek = new Language("el");
        public static Language English = new Language("en");
        public static Language Basque = new Language("eu");
        /// (Farsi);
        public static Language Persian = new Language("fa");
        public static Language Finnish = new Language("fi");
        public static Language French = new Language("fr");
        public static Language Galician = new Language("gl");
        public static Language Hebrew = new Language("he");
        public static Language Hindi = new Language("hi");
        public static Language Croatian = new Language("hr");
        public static Language Hungarian = new Language("hu");
        public static Language Indonesian = new Language("id");
        public static Language Italian = new Language("it");
        public static Language Japanese = new Language("ja");
        public static Language Korean = new Language("kr");
        public static Language Latvian = new Language("la");
        public static Language Lithuanian = new Language("lt");
        public static Language Macedonian = new Language("mk");
        public static Language Norwegian = new Language("no");
        public static Language Dutch = new Language("nl");
        public static Language Polish = new Language("pl");
        public static Language Portuguese = new Language("pt");
        /// Brasil;
        public static Language Português = new Language("pt_br");
        public static Language Romanian = new Language("ro");
        public static Language Russian = new Language("ru");
        public static Language Swedish = new Language("sv");
        public static Language Slovak = new Language("sk");
        public static Language Slovenian = new Language("sl");
        public static Language Spanish = new Language("es");
        public static Language Serbian = new Language("sr");
        public static Language Thai = new Language("th");
        public static Language Turkish = new Language("tr");
        public static Language Ukrainian = new Language("ua");
        public static Language Vietnamese = new Language("vi");
        public static Language SimplifiedChinese = new Language("zh_cn");
        public static Language TraditionalChinese = new Language("zh_tw");
        public static Language Zulu = new Language("zu");
    }
}
