namespace Asal_Çarpan_Bulma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Asal çarpanlarını bulmak istediğiniz sayı: ");
            int number, counter = 0, counter2, counter3 = 1;
            bool numberIsInt;
            while (true)
            {
                numberIsInt = int.TryParse(Console.ReadLine(), out number);
                if (numberIsInt && number >= 0) break;
                else Console.WriteLine("Hatalı giriş yaptınız lütfen 0 dan büyük bir sayı giriniz");
            }
            int[] numbers = new int[number];
            for (int i = 1; i < numbers.Length + 1; i++)
            {
                if (number % i == 0)
                {
                    numbers[i - 1] = i;
                    counter++;
                }
            }
            for (int i = 1; i < numbers.Length + 1; i++)
            {
                counter2 = 0;
                for (int j = 1; j <= numbers[i - 1]; j++)
                {
                    if (numbers[i - 1] % j == 0)
                        counter2++;
                }
                if (counter2 == 2)
                {
                    Console.WriteLine($"{counter3}. asal çarpan: {numbers[i - 1]}");
                    counter3++;
                }
            }
        }
    }
}