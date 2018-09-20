using System;
using YandexLinguistics.NET;

namespace TestTask_1
{
    class TranslateClass
    {
        public TranslateClass(Lang inLang, Lang outLang, string key)
        {
            tr = new Translator(key);

            lp = new LangPair
            {
                InputLang = inLang,
                OutputLang = outLang
            };
        }

        Translator tr;
        public LangPair lp;

        public string GetTransliteText(string text)
        {
            try
            {
                return tr.Translate(text, lp).Text;
            }
            catch (Exception ex)
            {
                return "Ошибка: " + ex.Message;
            }
        }
    }
}