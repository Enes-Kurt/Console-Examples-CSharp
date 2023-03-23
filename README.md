# Console-Examples-CSharp

C# yaz�l�m diliyle console uygulamas�nda yap�lan baz� algoritma �rnekleri.

## 1- Polindrome Say�

Bir say�n�n polindrome say� olup olmad���n� bulur.  
 **�rnek**  
Input: 32123  --> Output: "Say� polindromdur."

#### Program�n �al��mas�

1. Kullan�c�n�n ka� basamakl� say� girmek istedi�ini sorar ve kullan�c�dan bu bilgiyi al�r.
2. Kullan�c�dan kontrol edece�i say�y� girmesini ister ve kullan�c�dan bu bilgiyi al�r.
3. Say�y� string olarak al�r ve array mant���yla say�n�n kotrol�n� yapar.
4. Say�n�n polindrome olup olmad���n� ekrana yazd�r�r.

## 2- Say�lar� Yaz�ya �evirme

En fazla 5 basamakl� olacak �ekilde yaz�ya �evirmek istedi�iniz say�y� yaz� format�nda yazar.  
 **�rnek**  
Input: 54231  --> Output: ellid�rtbinikiy�zotuzbir

#### Program�n �al��mas�

1. Kullan�c�dan �evirmek istedi�i say�y� girmesini ister ve kullan�c�dan bu bilgiyi al�r.
2. Say�y� string olarak al�r ve basamaklara �zel atanm�� strin dizileri yard�m�yla bo� bir stringe say�n�n yaz� kar��l���n� s�rayla ekler.
3. Say�n�n yaz� olarak kar��l���n� ekrana yazd�r�r.

## 3- �al��anlar�n Mesaili �cretini Hesaplama

Bu program �irketinizdeki i��inin s�n�f�n� se�ektikten sonra bu i��inin hafta i�i ve hafta sonu mesai s�relerini girerek i��inin toplam ayl�k �cretini hesaplar. ���lerinizi listesini ��kart�r.  
 **�rnek**  
Input: ���i ad� soyad�: Enes Kurt  
&emsp;���i se�imi: ��rak  
&emsp;1 Hafta i�in toplam hafta i�i mesaisi: 10 &emsp;&emsp; --> Output:&emsp;&emsp;----------------Listeniz-----------  
&emsp;1 Hafta i�in toplam hafta sonu mesaisi: 15 &emsp;&emsp;&emsp;&emsp;Enes Kurt isimli i��inin net �creti: 5100 TL

#### Program�n �al��mas�

1. Kullan�c�dan ad, soyad ve haftal�k mesai saatleri bilgilerini al�r.
2. ���i s�n�f� se�imine g�re (��rak, kalfa, usta) net maa� hesab�n� yapar.
3. Program� sonland�r�p listeyi g�rmek i�in "y" giri�i yaparak sonland�rabilir veya listeye daha fazla i��i girmek i�in ba�ka bir giri� yapabilirisiz.
4. Program sonland���nda listenizi ekrana yazd�r�r.

## 4- Asal �arpan Bulma

Girilen say�n�n asal �arpanlar�n� ve bulur.  
 **�rnek**  
Input: 32681  --> Output: 1. Asal �arpan: 11&emsp;&emsp;&emsp;2. Asal �arpan: 2971

#### Program�n �al��mas�

1. Kullan�c�dan asal �arpanlar�n� bulmak istedi�i say�y� girmesini ister ve kullan�c�dan bu bilgiyi al�r.
2. Say�y� int olarak al�r ve say�n�n b�lenlerini bulur. Bulunan tam b�lenlerin asal olup olmad���n� kontrol eder.
3. Say�n�n asal �apranlar�n� ekrana yazd�r�r.

## 5- �ark� Listesi Olu�turma

�stedi�iniz kadar �ark� ekleyerek veya ��kartarak bir �ark� listesi olu�turur.  
 **�rnek**  
Input: "Parca1" "Parca2" "Parca3" "Parca4" &emsp;&emsp; --> Output:&emsp;-----------Son Listeniz-----------  
NOt: Parca3 listeden ��kart�lm��t�r.&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;"Parca1" "Parca2" "Parca4"

#### Program�n �al��mas�

1. Bir liste olu�turur ve kullan�c� bu liseteye istedi�i kadar �ark� ekleyebilir.
2. Kullan�c�ya eklede�i�i �ark� listesinden �ark� ��karmak isteyip istmed�i�ini sorar ve isterse �ark�lar� listeden ��kartabilir.
3. Kullan�c�n�n listesi tamamland���nda program� sonland���nda �ark� listesini ekrana yazd�r�r.

## 6- Kosu Mesafesi Hesaplama

Ad�m uzunlu�u,ko�u s�resi ve dakika ba��na ad�m gibi bilgileri alarak kullan�c�n�n ko�u mesafesini hesaplar. Kullan�c� birden fazla ko�u hesaplatabilir ve program t�m ko�ular� listeler ve t�m ko�ular�n�n toplam ko�u mesefasini ve toplam s�resini bulur.

#### Program�n �al��mas�

1. Kullan�c�y� giri� yapaca�� bilgiler hakk�nda bilgilendirir.
2. Kullan�c�dan ad�m uzunlu�u al�r. Bunun ard�ndan bir tura ait ko�ulan saat,dakika ve dakikada ka� ad�m att���n� girmesini ister.
3. Kullan�c�dan al�nan bilgileri kullanaran bir turdaki ko�u mesafesini hespalar ve ba�ka bir ko�u giri�i i�in kullan�c�ya sorar kulllan�c� bu �ekilde birden fazla ko�u ekleyebilir.
4. Kullan�c�n�n ko�ular�n� ve bu ko�udaki bilgilerini ekranda bir liste halinde yazd�r�r.