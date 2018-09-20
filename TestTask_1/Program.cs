using System;

namespace TestTask_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TranslateClass translater = new TranslateClass(YandexLinguistics.NET.Lang.Ru,
                YandexLinguistics.NET.Lang.En, "trnsl.1.1.20180911T170920Z.bbbe32530f1728ff.7fdb51f1907a42adf4eae4888d4d4081db90352e");

            
            Console.WriteLine("Привет! Я переводчик от Яндекса! Напишите текст на русском языке, для перевода на английский. Для выхода, напишите 'exit' или отправте пустой запрос.");

            string text = Console.ReadLine();

            while ((text != "") && (text != "exit"))
            {
                Console.WriteLine(translater.GetTransliteText(text));

                text = Console.ReadLine();
            }
        }
    }
}