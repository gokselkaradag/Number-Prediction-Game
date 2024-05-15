namespace Number_Prediction_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz. ");
            Console.WriteLine("İyi Oyunlar. ");

            int counter = 5;

            //Method ile beraber değişkene sayı atadık.
            int level1 = CreateRandomNumber(26);
            int level2 = CreateRandomNumber(51);
            int levelInfo = 1;
            int guessNumber = 0;
            int finish = 25;
            do
            {
                if (levelInfo == 1)
                {
                    guessNumber = level1;
                }
                else if (levelInfo == 2)
                {
                    guessNumber = level2;
                    finish = 50;
                }
                Console.WriteLine(guessNumber);

                Console.WriteLine("Sayı tahmin ediniz");
                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer < 0 || answer > finish)
                {
                    Console.WriteLine("Geçersiz karakter, Yeniden giriniz.");
                    continue;
                }

                if (guessNumber == answer) //1 seviye
                {
                    Console.WriteLine("Başarılı");

                    bool isContuine = GetAnswer();

                    if (isContuine == true) // 2 seviye
                    {
                        // counter = 5;
                        levelInfo++;
                        Console.WriteLine("level 2'ye geçtiniz");
                    }
                    else if (isContuine == false)
                    {
                        Console.WriteLine("İyi oynadınız.");
                        break;
                    }


                }
                else
                {
                    Console.WriteLine("Başarısız oldunuz.");
                    counter--;

                    Console.WriteLine($"kalan hakkınız {counter}");

                }
            } while (counter != 0);
            
        }
        public static int CreateRandomNumber(int finish)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, finish);
            return randomNumber;
        }
        public static bool GetAnswer()
        {
            string answer;
            do
            {
                Console.WriteLine("Devam etmek istiyor musunuz");
                answer = Console.ReadLine().ToLower();


                if (answer == "evet")
                {
                    return true;
                }
                else if (answer == "hayır")
                {
                    return false;
                }


            } while (answer != "evet" || answer != "hayır");

            return false;

        }
    }
}
