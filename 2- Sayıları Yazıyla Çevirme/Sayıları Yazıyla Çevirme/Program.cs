Console.Write("En fazla 5 basamaklı olacak şekilde yazıya çevirmek istediğiniz sayıyı giriniz: ");
string tutar = Console.ReadLine();
string yazi = "";
char[] rakamlar = { '2', '3', '4', '5', '6', '7', '8', '9' };
string[] birler = { "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
string[] onlar = { "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };

for (int i = 0; i < tutar.Length; i++)
{

    if (tutar[i] == '1')
    {
        if (i == tutar.Length - 5 && tutar.Length == 5) yazi += "on";
        else if (i == tutar.Length - 4 && tutar.Length == 5) yazi += "bir";
        if (i == tutar.Length - 4) yazi += "bin";
        if (i == tutar.Length - 3) yazi += "yüz";
        if (i == tutar.Length - 2) yazi += "on";
        else if (i == tutar.Length - 1) yazi += "bir";
    }
    for (int j = 0; j < 8; j++)
    {
        if (tutar[i] == rakamlar[j])
        {
            if (i == tutar.Length - 5) yazi += onlar[j];
            else if (i == tutar.Length - 2) yazi += onlar[j];
            else yazi += birler[j];
            if (i == tutar.Length - 4) yazi += "bin";
            if (i == tutar.Length - 3) yazi += "yüz";
        }
    }
}
Console.WriteLine(yazi);