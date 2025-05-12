using System;
namespace Milyoner
{
    class Program
    {
        static void Main(string[] args)

        {
            int counter = 0;
            Console.WriteLine("Büyük ödüllü Kim Milyoner Olmak İster adlı yarışmamıza hoş geldiniz.");
            Console.WriteLine("Toplamda 3 sorumuz bulunuyor.");
            Console.WriteLine("3 sorudan 2'sini doğru bilen kişi 1 Milyon TL'lik büyük ödülün sahibi olacak.");
            Console.WriteLine("Hazırsanız ilk sorumuzu cevaplamakla başlayalım (Enter'a basınız.)");
            Console.ReadLine();

            // question 1
            Console.WriteLine("Kızınca tüküren hayvan hangisidir?");
            Console.WriteLine("A) Lama");
            Console.WriteLine("B) Deve");
            Console.Write("Cevabınız: ");
            string answer1 = Console.ReadLine().ToUpper();
            if (answer1 == "A")
            {
                counter++; // bu şekilde doğru cevap sayısını 0'dan 1'e olacak şekilde artırıyoruz.
                Console.WriteLine("Tebrikler! Doğru cevap verdiniz.");
            }
            else
            {
                Console.WriteLine("Yanlış cevap verdiniz. Doğru seçenek A olmalıydı.");
            }
            // question 2
            Console.WriteLine("Güneş sisteminde en büyük gezegen hangisidir?");
            Console.WriteLine("A) Mars");
            Console.WriteLine("B) Jüpiter");
            Console.Write("Cevabınız: ");
            string answer2 = Console.ReadLine().ToUpper();

            if (answer2 == "B")
            {
                counter++;
                Console.WriteLine("Tebrikler! Doğru cevap verdiniz.");
            }

            else
            {
                Console.WriteLine("Yanlış cevap verdiniz. Doğru seçenek B olmalıydı.");
            }

            //Eğer iki sorudan 2'si de yanlışsa
            if (counter == 0)
            {
                Console.WriteLine("Üzgünüz. İlk iki sorumuza da yanlış yanıt verdiğiniz için elendiniz.");
            }

            else
            {
                // question 3
                Console.WriteLine("5 * 2 + 8 /2 -2 işleminin sonucu kaçtır?");
                Console.WriteLine("A) 12");
                Console.WriteLine("B) 7");
                Console.Write("Cevabınız: ");
                string answer3 = Console.ReadLine().ToUpper();

                if (answer3 == "A")
                {
                    counter++;
                    Console.WriteLine("Tebrikler. Doğru Cevap verdiniz.");

                }
                else
                {
                    Console.WriteLine("Yanlış cevap verdiniz. Doğru seçenek A olmalıydı.");
                }

            }
            //sonuç olarak
            Console.WriteLine($"Toplam doğru sayınız: {counter}");
            if (counter >= 2)
            {
                Console.WriteLine("TEBRIKLER. 1 MİLYON TL'LİK ÖDÜLÜN SAHİBİ OLDUNUZ!");
            }
            else
            {
                Console.WriteLine("Maalesef ödülü kazanamadınız. :(");
            }
            Console.WriteLine("Yarışmaya katıldığınız için teşekkürler.");
        }


    }
}