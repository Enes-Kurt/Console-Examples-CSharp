namespace Koşu_Mesafesi_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Based on your step length, this program calculates how many meters you have run in the entered time with the average number of steps you take in one minute.
            int stepLengthCm;
            Information();
            ReadstepLength(out stepLengthCm);
            RunResult(stepLengthCm);
        }

        //This method informs
        static void Information()
        {
            Console.WriteLine("Bu program adım boyunuzdan yola çıkarak ortalama bir dakikada attığınız adımla birlikte girilen sürede kaç metre mesafe aldığınızı hesaplamaktadır.");
            Console.WriteLine("\n--------BİLGİLENDİRME METNİ--------");
            Console.WriteLine("1- Giriş yapacağınız değerler sayı olmalıdır.");
            Console.WriteLine("2- Bir insanın adım boyu 20 cm den küçük ve 200 cm den büyük olamaz.");
            Console.WriteLine("3- Bir insanın bir dakikada koşarken attığı adım sayısı 100den küçük ve 10000 den büyük olamaz.");
            Console.WriteLine("4- Saat 0 dan küçük olamaz ve bir insan  ara vermeden 15 saatten fazla koşamaz.");
            Console.WriteLine("5- Dakika 0 dan küçük ve 60 tan büyük olamaz.");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("\n-----PROGRAMI SONLANDIRMAK İÇİN KOŞU SUNUCUNUZDAN SONRA 'exit' ŞEKLİNDE GİRİŞ YAPINIZ------\n");
        }

        //This method is used to get the "Step Length" from the user and control the "Step Length".
        static void ReadstepLength(out int stepLengthCm)
        {
            while (true)
            {
                Console.Write("Adım boyunuzu cm cinsinden giriniz: ");
                bool stepLengthCmIsInt = int.TryParse(Console.ReadLine(), out stepLengthCm);
                if (!stepLengthCmIsInt || stepLengthCm < 20 || 200 < stepLengthCm)
                {
                    Console.WriteLine("\n!!!HATA!!! Bir insanın adım boyu 20cm den küçük ve 200 cm den büyük olamaz. Lütfen belirtilen değerler arasında bir sayı girişi yapınız.\n");
                    continue;
                }
                else break;
            }
        }

        // This method is used to get the required parameters from the user and control them.
        static void ReadOtherParameters(out int numberOfSteps, out int minuteTypeTime, out int hourTypeTime)
        {
            while (true)
            {
                Console.Write("Dakikada ortalama kaç adım attığınızı giriniz: ");
                bool numberOfStepsIsInt = int.TryParse(Console.ReadLine(), out numberOfSteps);
                if (!numberOfStepsIsInt || numberOfSteps < 100 || 10000 < numberOfSteps)
                {
                    Console.WriteLine("\n!!!HATA!!! Bir insanın bir dakikada koşarken attığı adım sayısı 100den küçük ve 10000 den büyük olamaz. Lütfen belirtilen değerler arasında bir sayı girişi yapınız.\n");
                    continue;
                }
                Console.Write("Kaç saat koştuğunuzu giriniz: ");
                bool hourTypeTimeIsInt = int.TryParse(Console.ReadLine(), out hourTypeTime);
                if (!hourTypeTimeIsInt || hourTypeTime < 0 || 15 < hourTypeTime)
                {
                    Console.WriteLine("\n!!!HATA!!! Saat 0 dan küçük olamaz ve bir insan  ara vermeden 15 saatten fazla koşamaz. Lütfen belirtilen değerler arasında bir sayı girişi yapınız.\n");
                    continue;
                }
                Console.Write("Kaç dakika koştuğunuzu giriniz: ");
                bool minuteTypeTimeIsInt = int.TryParse(Console.ReadLine(), out minuteTypeTime);
                if (!minuteTypeTimeIsInt || minuteTypeTime < 0 || 60 < minuteTypeTime)
                {
                    Console.WriteLine("\n!!!HATA!!! Dakika 0 dan küçük ve 60 tan büyük olamaz. Lütfen belirtilen değerler arasında bir sayı girişi yapınız.\n");
                    continue;
                }
                break;
            }
        }

        // This method calculates the total distance.
        static double CalculateDistance(int stepLengthCm, int numberOfSteps, int minuteTypeTime, int hourTypeTime)
        {
            int totalMinute = hourTypeTime * 60 + minuteTypeTime;
            double stepLengthMeter = stepLengthCm / 100.0;

            return stepLengthMeter * numberOfSteps * totalMinute;
        }

        //This method returns results for every run result and all runs total result the user has made. 
        static void RunResult(int stepLengthCm)
        {
            List<string> runList = new List<string>();
            int numberOfSteps, minuteTypeTime, hourTypeTime, totalhourTypeTime = 0, totalminuteTypeTime = 0, extraHour, counter = 1;
            double totalDistance = 0, distance;
            string control = "";
            while (control != "exit")
            {
                Console.WriteLine($"\n--------{counter}. Koşu parametrelerinizi giriniz--------");
                ReadOtherParameters(out numberOfSteps, out minuteTypeTime, out hourTypeTime);
                totalminuteTypeTime += minuteTypeTime;
                totalhourTypeTime += hourTypeTime;
                distance = CalculateDistance(stepLengthCm, numberOfSteps, minuteTypeTime, hourTypeTime);
                totalDistance += distance;
                Console.WriteLine($"\n--------{counter}. KOŞUDAKİ SONUCUNUZ--------");
                string thisRun = $"{hourTypeTime} saat {minuteTypeTime} dakika koştunuz ve katettiğiniz toplam mesafe {distance} metredir.";
                Console.WriteLine(thisRun);
                runList.Add(thisRun);
                Console.WriteLine("\nÇıkış yapmak istiyor musunuz? (exit)");
                control = Console.ReadLine();
            }
            extraHour = totalminuteTypeTime / 60;
            totalminuteTypeTime %= 60;
            totalhourTypeTime += extraHour;
            Console.WriteLine("\n--------TÜM KOŞULARINIZIN LİSTESİ--------");
            foreach (string run in runList)
            {
                Console.WriteLine($"{counter}. Koşu --> " + run);
                counter++;
            }
            Console.WriteLine("\n--------TOPLAM KOŞU SONUCUNUZ--------");
            Console.WriteLine($"{totalhourTypeTime} saat {totalminuteTypeTime} dakika koştunuz ve katettiğiniz toplam mesafe {totalDistance} metredir.");
        }

    }
}