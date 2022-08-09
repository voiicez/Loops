namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int sayi = 1; sayi <= 10; sayi++) // 1 den 10' a kadar.
            {
                Console.WriteLine(sayi);
            }

            for (int tek = 49; tek >= 1; tek = tek - 2) // 49 dan 0 a tek sayılar
            {
                Console.WriteLine(tek);
            }


            for (int uy = 1; uy <= 30; uy++) //3 veya 7 ye bölünen sayılar. 30 a kadar
            {
                if (uy % 3 == 0 || uy % 7 == 0)
                {
                    Console.WriteLine(uy);
                }
            }
            int no = 1;
            while (no <= 30) //3 ve 7 ye kalansız bölünen.  
            {

                if (no % 3 == 0 && no % 7 == 0)
                {
                    Console.WriteLine(no);
                }
                no = no + 1;
            }

            no = 1;
            while (no <= 10)
            {
                Console.WriteLine(no);
                no++;
            }
            no = 1; 
            do //Do while illaki bir kere çalışır. İlk kodu çalıştırır sonra koşulu kontrol eder.
            {
                Console.WriteLine(no);
                no++;
            } while (no <= 10);   

            
        }


    }
}