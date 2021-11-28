using System;

namespace KelimeveHarfSayma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Sentence = CümleAl();
            Console.WriteLine("Bu cümlenin kelime sayısı {0}'dır ve harf sayısı {1}'dir",KelimeSayısı(Sentence),HarfSay(Sentence));
        }
        static string CümleAl()
        {
            Console.WriteLine("Lütfen bir cümle giriniz.");
            return Console.ReadLine();
        }
        static int KelimeSayısı(string Sentence)
        {
            int nWord = 0;
            for (int i = 0; i < Sentence.Length; i++)
            {
                if (Char.IsWhiteSpace(Sentence[i]) | Char.IsPunctuation(Sentence[i]))
                nWord++;                
            }
            return nWord;
        }
        static int HarfSay(string Sentence)
        {
            int nLetter = 0;
            int Count = 0;
            for (int i = 0; i < Sentence.Length; i++)
            {
                if (Char.IsWhiteSpace(Sentence[i]) | Char.IsPunctuation(Sentence[i]))
                    Count++;
            }
            return Sentence.Length - Count;

        }
    }
}
