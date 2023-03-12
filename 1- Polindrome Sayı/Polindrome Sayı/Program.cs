int numberLength;
int number;
while (true)
{
    Console.Write("Kaç basamaklı sayı gireceğinizi giriniz:");
    bool numberLengthIsInt = int.TryParse(Console.ReadLine(), out numberLength);
    Console.Write("Test etmek istediğiniz sayıyı giriniz:");
    bool numberIsInt = int.TryParse(Console.ReadLine(), out number);
    string number1 = Convert.ToString(number);
    if (numberLengthIsInt && numberIsInt && number > 0 && numberLength > 0 && numberLength == number1.Length)
    {
        break;
    }
    else Console.WriteLine("\nHatalı giriş yaptınız lütfen 0 dan büyük bir sayılar giriniz.");
}

int[] numbers = new int[numberLength];
bool kontrol = true;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = number % 10;
    number = number / 10;
}

for (int j = 0; j < numbers.Length; j++)
{
    if (!(numbers[j] == numbers[numbers.Length - j - 1]))        
    kontrol = false;
}

string result = kontrol ? "\nSayi palindromdur." : "Sayi palindrom değildir.";
Console.WriteLine(result);