using System;

namespace TKMOyunu
{
     class Program
    {
        static void Main(string[] args)
        {

            string inputPlayer, inputCPU;
            int randomInt;
           
            bool playAgaın = true;


            while (playAgaın)
            {

            int scorePlayer = 0;
            int scoreCPU = 0;


            while(scorePlayer < 3 && scoreCPU < 3) {
             

            Console.WriteLine("TAŞ , KAĞIT  VE MAKAS arasında bir seçim yapınız : ");

            inputPlayer = Console.ReadLine();     // Bu komut hem ekranda durdurma işlemi yapmakta hem de klavyeden metin girişi yapılıp değişkene atılmasını sağlamaktadır.

            inputPlayer = inputPlayer.ToUpper();      
           // büyük/ küçük harfe duyarlı olmayan bir karşılaştırmada kullanılabilmesi için bir dizeyi büyük harfe dönüştürmek için kullanılır.

            Random rnd = new Random();

            randomInt= rnd.Next(1,4);      // randomInt bir sonraki rastgele sayıya eşit 1,4 arasında



            switch (randomInt)
            {
                case 1:
                    inputCPU = "TAŞ";

                    Console.WriteLine("Bilgisayar TAŞ seçti");

                    if (inputPlayer == "TAŞ")
                    {
                        Console.WriteLine("Berabere kaldınız !");   
                    }
                    else if(inputPlayer == "KAĞIT")
                    {
                        Console.WriteLine("Oyunuc kazandı");
                        scorePlayer++;
                    }

                    else if(inputPlayer == "TAŞ")
                    {
                        Console.WriteLine("Bilgisayar kazandı ");
                        scoreCPU++;
                    }
                    break;



                case 2:
                    inputCPU = "KAĞIT";

                    Console.WriteLine("Bilgisayar KAĞIT seçti");

                    if (inputPlayer == "KAĞIT")
                    {
                        Console.WriteLine("Berabere kaldınız !");
                    }
                    else if (inputPlayer == "TAŞ")
                    {
                        Console.WriteLine("Bilgisayar kazandı");
                        scoreCPU++;
                    }

                    else if (inputPlayer == "MAKAS")
                    {
                        Console.WriteLine("Oyuncu kazandı ");
                        scorePlayer++;
                    }
                    break;


                case 3:
                    inputCPU = "MAKAS";

                    Console.WriteLine("Bilgisayar MAKAS seçti");

                    if (inputPlayer == "MAKAS")
                    {
                        Console.WriteLine("Berabere kaldınız !");
                    }

                            else if (inputPlayer == "KAĞIT")
                            {
                                Console.WriteLine("Bilgisayar kazandı ");
                                scoreCPU++;
                            }

                            else if (inputPlayer == "TAŞ")
                    {
                        Console.WriteLine("Oyuncu kazandı");
                        scorePlayer++;
                    }

                    break;
                        default:
                            Console.WriteLine("Yanlış giriş");
                            break;
            }

                    Console.WriteLine("SCORES : PLAYER : ", scorePlayer, scoreCPU);
            }


            // Uygulama çalışma bölümü


            if (scorePlayer == 3)
            {
                Console.WriteLine("Oyunu Kazandı !");   
            }
            else if(scoreCPU== 3)
            {
                Console.WriteLine("Bilgisayar kazandı !");
            }


            Console.WriteLine("Tekrar oynamak ister misiniz ? (E / H)");
            string loop = Console.ReadLine();

            if(loop == "E")
            {
                playAgaın = true;
                    Console.Clear();
            }

            else if(loop == "H") {
                playAgaın= false;
                    Console.Clear();
                   
            }
            }
        }
    }
}