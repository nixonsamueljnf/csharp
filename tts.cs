using System;
using System.Collections.Generic;
using System.Diagnostics;
using RestSharp;
using Plivo.XML;

namespace text_to_speech
{
    class Program
    {
        static void Main(string[] args)
        {
            Plivo.XML.Response resp = new Plivo.XML.Response();

            resp.AddSpeak("Здравствуйте, Это сообщение от Charlie. Машина за Nixon, приедет приблизительно в 10. Пожалуйста, будьте готовы к этому времени. Мы Вам позвоним еще раз когда машина подъедет к Вашему дому. Спасибо", new Dictionary<string, string>()
            {
                {"language", "ru-RU"},
                {"voice", "WOMAN"}
            });

            Console.Write("TTS Output:\n");
            Console.Write(resp.ToString());
        }
    }
}
