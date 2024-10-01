using System;

namespace Kim_Milyoner_Olmak_İster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int correctAnswers = 0;

            // Soru ve cevaplar
            correctAnswers += SoruSor("Kızınca tüküren hayvan hangisidir?", "a) Lama", "b) Deve", "a");
            correctAnswers += SoruSor("Dünya'ya en yakın gezegen hangisidir?", "a) Venüs", "b) Mars", "a");

            // Eğer doğru cevap sayısı 1 ise üçüncü soruyu sor
            if (correctAnswers == 1)
            {
                correctAnswers += SoruSor("5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?", "a) 7", "b) 12", "b");
            }

            // Final sonuç
            if (correctAnswers >= 2)
            {
                Console.WriteLine("Tebrikler, 1 Milyon TL kazandınız!");
            }
            else
            {
                Console.WriteLine("Maalesef büyük ödülü kazanamadınız.");
            }

            Console.ReadKey();
        }

        // Soru sorma fonksiyonu
        static int SoruSor(string soru, string secenekA, string secenekB, string dogruCevap)
        {
            Console.WriteLine(soru);
            Console.WriteLine(secenekA.ToLower() + " " + secenekB.ToLower()); // Seçenekler küçük harfe çevriliyor
            Console.Write("Cevap: ");
            string cevap = Console.ReadLine();

            // Cevapları büyük/küçük harfe duyarsız hale getirmek için küçük harfe çeviriyoruz
            if (cevap.ToLower() == dogruCevap.ToLower())
            {
                Console.WriteLine("Doğru cevap!");
                return 1;
            }
            else
            {
                Console.WriteLine("Yanlış cevap!");
                return 0;
            }
        }
    }
}

