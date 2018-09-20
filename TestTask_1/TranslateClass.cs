using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexLinguistics.NET;

namespace TestTask_1
{
    class TranslateClass
    {
        public TranslateClass()
        {
            tr = new Translator(apiStringKey);
            lp = new LangPair();
        }

        const string apiStringKey = "trnsl.1.1.20180911T170920Z.bbbe32530f1728ff.7fdb51f1907a42adf4eae4888d4d4081db90352e";
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