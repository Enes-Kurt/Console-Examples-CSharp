/* Soru
             * Kullanıcı "tamam" yazana kadar girdiği şarkı isimlerinden oluşan bir playlist oluşturan ve kullanıcıdan bu playlistten çıkarmak istediği bir şarkı ismi alan; eğer o şarkı playlistte varsa çıkarılmış yeni playlist'i listeleyen yoksa "Bu playlist'te böyle bir şarkı yok çıktısı" ile beraber aynı playlist'i veren uygulamayı yazın.
            */


// CREATE LİST AND ADD SONG
string[] songList = new string[0];
int i = 0;
Console.WriteLine("Şarkı eklemeyi sonlandırmak için (tamam) yazınız.\n");
while (true)
{
    Console.Write("Şarkı adı: ");
    string song = Console.ReadLine();
    if (song == "tamam") break;
    else
    {
        Array.Resize(ref songList, songList.Length + 1);
        songList[i] = song;
        i++;
    }
}

// DELETE SONG
string[] newSongList = new string[0];
bool control = false;
Console.WriteLine("\nŞarkı çıkarmayı sonlandırmak için (tamam) yazınız.");
while (true)
{
    // Another method
    // str = str.Except(new string[]{deletedSong}).ToArray(); 

    Console.Write("\nÇıkarılacak şarkı adı: ");
    string deletedSong = Console.ReadLine();
    if (deletedSong == "tamam")
        break;
    if (songList.Contains(deletedSong))
    {
        Array.Resize(ref newSongList, songList.Length - 1);
        int deletedSongIndex = Array.IndexOf(songList, deletedSong);
        for (int k = 0; k < deletedSongIndex; k++)
            newSongList[k] = songList[k];
        for (int k = deletedSongIndex + 1; k < songList.Length; k++)
            newSongList[k - 1] = songList[k];
        Console.WriteLine("\n------Güncel Listeniz------");
        foreach (string song in newSongList)
            Console.Write($"\"{song}\" ");
        songList = newSongList;
        control = true;
    }
    else
    {
        Console.WriteLine("\nBu platlist'te böyle bir şarkı yok!");
        Console.WriteLine("\n------Güncel Listeniz------");
        if (control == true)
        {
            foreach (string song in newSongList)
                Console.Write($"\"{song}\" ");
        }
        else
        {
            foreach (string song in songList)
                Console.Write($"\"{song}\" ");
        }
    }
    if (songList.Length == 0)
        break;
}

// WRITE THE FINAL LİST
if (songList.Length == 0)
    Console.WriteLine("Boş liste!");
else
{
    Console.WriteLine("------Son listeniz------");
    foreach (string song in newSongList)
        Console.Write($"\"{song}\" ");
}