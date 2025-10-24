\# C# Çift Yönlü Bağlı Liste (Doubly Linked List) Ödevi



!\[C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge\&logo=c-sharp\&logoColor=white)



Bu proje, bir bilgisayar mühendisliği veri yapıları dersi ödevi kapsamında C# programlama dili kullanılarak geliştirilmiş bir \*\*Çift Yönlü Bağlı Liste (Doubly Linked List)\*\* uygulamasıdır.



Proje, bağlı listelerin temel CRUD (Create, Read, Update, Delete) işlemlerini ve bazı yardımcı fonksiyonları içeren bir `BagliListe` sınıfını ve bu listeyi oluşturan elemanları temsil eden bir `Dügüm` (Node) sınıfını barındırır.



\## Kod Yapısı



Tüm kod, `Program.cs` dosyası içinde yer almaktadır ve aşağıdaki sınıfları içerir:



\* \*\*`Program`\*\*: Ana sınıf. Test kodlarını içeren `Main` metodunu barındırır.

\* \*\*`Dügüm` (Node)\*\*: Listenin her bir elemanını temsil eden iç sınıf.

&nbsp;   \* `int veri`: Düğümün taşıdığı veri.

&nbsp;   \* `Dügüm Sonraki`: Bir sonraki düğüme olan referans (işaretçi).

&nbsp;   \* `Dügüm Onceki`: Bir önceki düğüme olan referans (işaretçi).

\* \*\*`BagliListe` (LinkedList)\*\*: Çift yönlü bağlı listenin kendisini ve operasyonlarını yöneten iç sınıf.

&nbsp;   \* `Dügüm bas`: Listenin başını (head) tutar.

&nbsp;   \* `Dügüm son`: Listenin sonunu (tail) tutar.



\## İçerdiği Metotlar



`BagliListe` sınıfı aşağıdaki temel bağlı liste operasyonlarını gerçekleştirebilir:



\* \*\*`BasaEkle(int veri)`\*\*: Listenin başına yeni bir düğüm ekler.

\* \*\*`SonaEkle(int veri)`\*\*: Listenin sonuna yeni bir düğüm ekler.

\* \*\*`DegerdenSonraEkleme(int hedefVeri, int eklenecekVeri)`\*\*: Belirtilen bir veriye sahip düğümden \*sonra\* yeni bir düğüm ekler.

\* \*\*`DegerdenOnceEkleme(int hedefVeri, int eklenecekVeri)`\*\*: Belirtilen bir veriye sahip düğümden \*önce\* yeni bir düğüm ekler.

\* \*\*`BastanSilme()`\*\*: Listenin başındaki düğümü siler.

\* \*\*`SondanSilme()`\*\*: Listenin sonundaki düğümü siler.

\* \*\*`AradanSilme(int veri)`\*\*: Belirtilen veriye sahip \*ilk\* düğümü listeden siler. (Eğer baş veya sondaysa ilgili metotları çağırır).

\* \*\*`Arama(int veri)`\*\*: Listede belirtilen veriyi arar. Bulursa verinin bulunduğu \*\*indeksi (0'dan başlayarak)\*\*, bulamazsa `-1` değerini döndürür.

\* \*\*`Listele()`\*\*: Listenin tüm elemanlarını baştan sona `X <-> Y <-> Z` formatında konsola yazdırır.

\* \*\*`TumunuSil()`\*\*: Listenin tüm elemanlarını siler (listeyi sıfırlar).

\* \*\*`ToArray()`\*\*: Listedeki tüm verileri bir `int\[]` dizisine aktarır ve bu diziyi döndürür.



\## Nasıl Kullanılır?



1\.  Projeyi klonlayın veya indirin.

2\.  Bir C# IDE'si (Visual Studio, VS Code, Rider vb.) ile açın.

3\.  Projeyi derleyip çalıştırın.



`Program.cs` dosyasındaki `Main` metodu, tüm fonksiyonları test eden bir dizi örnek işlem içerir.



```csharp

static void Main(string\[] args)

{

&nbsp;   BagliListe liste = new BagliListe();



&nbsp;   // Örnek işlemler

&nbsp;   liste.BasaEkle(10);

&nbsp;   liste.SonaEkle(20);

&nbsp;   liste.SonaEkle(30);

&nbsp;   liste.BasaEkle(5);

&nbsp;   liste.DegerdenSonraEkleme(20, 25);

&nbsp;   liste.DegerdenOnceEkleme(10, 8);



&nbsp;   Console.WriteLine("Listeleme:");

&nbsp;   liste.Listele();



&nbsp;   Console.WriteLine("\\nArama (25):");

&nbsp;   int idx = liste.Arama(25);

&nbsp;   Console.WriteLine(idx >= 0 ? $"Bulundu. Konum: {idx}" : "Bulunamadı.");



&nbsp;   Console.WriteLine("\\nBaştan silme:");

&nbsp;   liste.BastanSilme();

&nbsp;   liste.Listele();



&nbsp;   Console.WriteLine("\\nSondan silme:");

&nbsp;   liste.SondanSilme();

&nbsp;   liste.Listele();



&nbsp;   Console.WriteLine("\\nAradan silme (20):");

&nbsp;   liste.AradanSilme(20);

&nbsp;   liste.Listele();



&nbsp;   Console.WriteLine("\\nDizide atma:");

&nbsp;   int\[] dizi = liste.ToArray();

&nbsp;   Console.WriteLine(string.Join(", ", dizi));



&nbsp;   Console.WriteLine("\\nTümünü silme:");

&nbsp;   liste.TumunuSil();

&nbsp;   liste.Listele();



&nbsp;   Console.WriteLine("\\nİşlem tamam. Çıkmak için bir tuşa basın...");

&nbsp;   Console.ReadKey();

}

```



\### Örnek Çıktı



Yukarıdaki test kodunun konsol çıktısı aşağıdakine benzer olacaktır:



```plaintext

10 listeye başa eklendi.

20 listeye sona eklendi.

30 listeye sona eklendi.

5 listeye başa eklendi.

25 listeye 20 verisinden sonra eklendi.

8 listeye 10 verisinden önce eklendi.

Listeleme:

5 <-> 8 <-> 10 <-> 20 <-> 25 <-> 30



Arama (25):

Bulundu. Konum: 4



Baştan silme:

5 baştan silindi.

8 <-> 10 <-> 20 <-> 25 <-> 30



Sondan silme:

30 sondan silindi.

8 <-> 10 <-> 20 <-> 25



Aradan silme (20):

20 aradan silindi.

8 <-> 10 <-> 25



Dizide atma:

8, 10, 25



Tümünü silme:

Liste tamamen silindi.

Liste boş.



İşlem tamam. Çıkmak için bir tuşa basın...

```

