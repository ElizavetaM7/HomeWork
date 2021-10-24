using System;

namespace СтрокиИСимволы5._1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст на русском языке:");

             static string (string str)

            {
                string i = Console.ReadLine();
                
                string[] rus = { "А", "Б", "В", "Г", "Д", "Е", "Ж", "З", "И",
                    "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф",
                    "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };
                string[] eng = { "A", "B", "V", "G", "D", "E", "ZH", "Z", "I",
                    "I", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F",
                    "KH", "TS", "CH", "SH", "SHCH", "IE", "Y", null, "E", "IU", "IA" };
                
                str = str.Replace(rus[i], eng[i]);

                
                Console.ReadKey();

            }
        }
        
    }
}
