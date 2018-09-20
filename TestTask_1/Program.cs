using System;

namespace TestTask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TranslateClass translater = new TranslateClass();

            translater.lp.InputLang = YandexLinguistics.NET.Lang.Ru;
            translater.lp.OutputLang = YandexLinguistics.NET.Lang.En;

            string text = "";

            Console.WriteLine("Привет! Я переводчик от Яндекса! Напишите текст на русском языке, для перевода на английский. Для выхода, напишите 'exit' или отправте пустой запрос.");

            text = Console.ReadLine();

            while ((text != "") && (text != "exit"))
            {
                Console.WriteLine(translater.GetTransliteText(text));

                text = Console.ReadLine();
            }

        }
    }
}