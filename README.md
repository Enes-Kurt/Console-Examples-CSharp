# Console-Examples-CSharp

C# yazýlým diliyle console uygulamasýnda yapýlan bazý algoritma örnekleri.

## 1- Polindrome Sayý

Bir sayýnýn polindrome sayý olup olmadýðýný bulur.  
 **Örnek**  
Input: 32123  --> Output: "Sayý polindromdur."

#### Programýn Çalýþmasý

1. Kullanýcýnýn kaç basamaklý sayý girmek istediðini sorar ve kullanýcýdan bu bilgiyi alýr.
2. Kullanýcýdan kontrol edeceði sayýyý girmesini ister ve kullanýcýdan bu bilgiyi alýr.
3. Sayýyý string olarak alýr ve array mantýðýyla sayýnýn kotrolünü yapar.
4. Sayýnýn polindrome olup olmadýðýný ekrana yazdýrýr.

## 2- Sayýlarý Yazýya Çevirme

En fazla 5 basamaklý olacak þekilde yazýya çevirmek istediðiniz sayýyý yazý formatýnda yazar.  
 **Örnek**  
Input: 54231  --> Output: ellidörtbinikiyüzotuzbir

#### Programýn Çalýþmasý

1. Kullanýcýdan çevirmek istediði sayýyý girmesini ister ve kullanýcýdan bu bilgiyi alýr.
2. Sayýyý string olarak alýr ve basamaklara özel atanmýþ strin dizileri yardýmýyla boþ bir stringe sayýnýn yazý karþýlýðýný sýrayla ekler.
3. Sayýnýn yazý olarak karþýlýðýný ekrana yazdýrýr.

## 3- Çalýþanlarýn Mesaili Ücretini Hesaplama

Bu program þirketinizdeki iþçinin sýnýfýný seçektikten sonra bu iþçinin hafta içi ve hafta sonu mesai sürelerini girerek iþçinin toplam aylýk ücretini hesaplar. Ýþçlerinizi listesini çýkartýr.  
 **Örnek**  
Input: Ýþçi adý soyadý: Enes Kurt  
&emsp;Ýþçi seçimi: Çýrak  
&emsp;1 Hafta için toplam hafta içi mesaisi: 10 &emsp;&emsp; --> Output:&emsp;&emsp;----------------Listeniz-----------  
&emsp;1 Hafta için toplam hafta sonu mesaisi: 15 &emsp;&emsp;&emsp;&emsp;Enes Kurt isimli iþçinin net ücreti: 5100 TL

#### Programýn Çalýþmasý

1. Kullanýcýdan ad, soyad ve haftalýk mesai saatleri bilgilerini alýr.
2. Ýþçi sýnýfý seçimine göre (çýrak, kalfa, usta) net maaþ hesabýný yapar.
3. Programý sonlandýrýp listeyi görmek için "y" giriþi yaparak sonlandýrabilir veya listeye daha fazla iþçi girmek için baþka bir giriþ yapabilirisiz.
4. Program sonlandýðýnda listenizi ekrana yazdýrýr.

## 4- Asal Çarpan Bulma

Girilen sayýnýn asal çarpanlarýný ve bulur.  
 **Örnek**  
Input: 32681  --> Output: 1. Asal çarpan: 11&emsp;&emsp;&emsp;2. Asal çarpan: 2971

#### Programýn Çalýþmasý

1. Kullanýcýdan asal çarpanlarýný bulmak istediði sayýyý girmesini ister ve kullanýcýdan bu bilgiyi alýr.
2. Sayýyý int olarak alýr ve sayýnýn bölenlerini bulur. Bulunan tam bölenlerin asal olup olmadýðýný kontrol eder.
3. Sayýnýn asal çapranlarýný ekrana yazdýrýr.

## 5- Þarký Listesi Oluþturma

Ýstediðiniz kadar þarký ekleyerek veya çýkartarak bir þarký listesi oluþturur.  
 **Örnek**  
Input: "Parca1" "Parca2" "Parca3" "Parca4" &emsp;&emsp; --> Output:&emsp;-----------Son Listeniz-----------  
NOt: Parca3 listeden çýkartýlmýþtýr.&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;"Parca1" "Parca2" "Parca4"

#### Programýn Çalýþmasý

1. Bir liste oluþturur ve kullanýcý bu liseteye istediði kadar þarký ekleyebilir.
2. Kullanýcýya ekledeðiþi þarký listesinden þarký çýkarmak isteyip istmedðiðini sorar ve isterse þarkýlarý listeden çýkartabilir.
3. Kullanýcýnýn listesi tamamlandýðýnda programý sonlandýðýnda þarký listesini ekrana yazdýrýr.

## 6- Kosu Mesafesi Hesaplama

Adým uzunluðu,koþu süresi ve dakika baþýna adým gibi bilgileri alarak kullanýcýnýn koþu mesafesini hesaplar. Kullanýcý birden fazla koþu hesaplatabilir ve program tüm koþularý listeler ve tüm koþularýnýn toplam koþu mesefasini ve toplam süresini bulur.

#### Programýn Çalýþmasý

1. Kullanýcýyý giriþ yapacaðý bilgiler hakkýnda bilgilendirir.
2. Kullanýcýdan adým uzunluðu alýr. Bunun ardýndan bir tura ait koþulan saat,dakika ve dakikada kaç adým attýðýný girmesini ister.
3. Kullanýcýdan alýnan bilgileri kullanaran bir turdaki koþu mesafesini hespalar ve baþka bir koþu giriþi için kullanýcýya sorar kulllanýcý bu þekilde birden fazla koþu ekleyebilir.
4. Kullanýcýnýn koþularýný ve bu koþudaki bilgilerini ekranda bir liste halinde yazdýrýr.