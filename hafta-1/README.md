# Hafta-1 Veri Yapıları Ödevi

1. **Recursive İkili Arama (Binary Search)**
2. **Dizi Elemanlarının Toplamı**
3. **Matris Çarpımı**

---

## 🎯 Algoritmaların Detaylı Analizi

### 1. Recursive İkili Arama (Binary Search)

#### Açıklama
İkili arama algoritması, **sıralanmış** bir dizi içerisinde aranan elemanı logaritmik zamanda bulur. Algoritma her adımda arama uzayını yarıya indirerek çalışır.

#### Kod
```csharp
public static int Search(int[] dizi, int aradigimizSayi, int sol, int sag)
{
    if (sag >= sol)
    {
        int orta = sol + (sag - sol) / 2;
        if (dizi[orta] == aradigimizSayi)
            return orta;
        else if (dizi[orta] > aradigimizSayi)
            return Search(dizi, aradigimizSayi, sol, orta - 1);
        else
            return Search(dizi, aradigimizSayi, orta + 1, sag);
    }
    return -1;
}
```

#### Zaman Karmaşıklığı
- **En İyi Durum:** `O(1)` - Aranan eleman tam ortada bulunursa
- **Ortalama Durum:** `O(log n)` - Her adımda arama uzayı yarıya iner
- **En Kötü Durum:** `O(log n)` - Aranan eleman bulunamazsa veya dizinin en ucunda ise

#### Alan Karmaşıklığı
- **Recursive:** `O(log n)` - Her recursive çağrı için stack'te alan kullanılır
- **Iterative olsaydı:** `O(1)` - Sabit alan kullanılırdı

---

### 2. Dizi Elemanlarının Toplamı

#### Açıklama
Bir dizideki tüm elemanların toplamını hesaplayan basit bir döngü algoritmasıdır.

#### Kod
```csharp
int[] dizi1 = { 1, 2, 3 };
int toplam = 0;
for (int i = 0; i < dizi1.Length; i++)
{
    toplam += dizi1[i];
}
```

#### Zaman Karmaşıklığı
- **Tüm Durumlar:** `O(n)` - Dizinin tüm elemanları bir kez gezilir
  - `n`: Dizideki eleman sayısı
  - Her eleman için sabit zamanlı işlem (toplama) yapılır

#### Alan Karmaşıklığı
- `O(1)` - Sadece `toplam` ve `i` değişkenleri için sabit alan kullanılır

---

### 3. Matris Çarpımı

#### Açıklama
İki matrisin çarpımını gerçekleştiren algoritma. İlk matrisin sütun sayısı, ikinci matrisin satır sayısına eşit olmalıdır.

**Matematiksel Kural:** `A(m×n) × B(n×p) = C(m×p)`

#### Kod
```csharp
for (int i = 0; i < satir1; i++)
{
    for (int j = 0; j < sutun2; j++)
    {
        for (int k = 0; k < sutun1; k++)
        {
            sonuc[i, j] += dizi[i, k] * dizi2[k, j];
        }
    }
}
```

#### Zaman Karmaşıklığı
- **Tüm Durumlar:** `O(n × m × p)` veya genelde `O(n³)` (kare matrisler için)
  - `n`: İlk matrisin satır sayısı
  - `m`: İlk matrisin sütun sayısı = İkinci matrisin satır sayısı
  - `p`: İkinci matrisin sütun sayısı
  - 3 iç içe döngü bulunmaktadır

**Detaylı Analiz:**
- Dış döngü: `satir1` kez çalışır → `O(n)`
- Orta döngü: `sutun2` kez çalışır → `O(p)`
- İç döngü: `sutun1` kez çalışır → `O(m)`
- **Toplam:** `O(n × m × p)`

#### Alan Karmaşıklığı
- `O(n × p)` - Sonuç matrisi için alan gerekir

---

## 📊 Karmaşıklık Karşılaştırma Tablosu

| Algoritma | Zaman Karmaşıklığı | Alan Karmaşıklığı | Kullanım Alanı |
|-----------|-------------------|-------------------|----------------|
| İkili Arama (Recursive) | O(log n) | O(log n) | Sıralı dizilerde hızlı arama |
| Dizi Toplamı | O(n) | O(1) | Toplu hesaplamalar |
| Matris Çarpımı | O(n³) veya O(n×m×p) | O(n×p) | Lineer cebir işlemleri |

---

## 📈 Büyük-O Notasyonu Sıralaması (Hızdan Yavaşa)

1. **O(1)** - Sabit zaman
2. **O(log n)** - Logaritmik zaman (İkili Arama) ⭐
3. **O(n)** - Lineer zaman (Dizi Toplamı) ⭐
4. **O(n log n)** - Lineeritmik zaman (Merge Sort, Quick Sort)
5. **O(n²)** - Karesel zaman (Bubble Sort)
6. **O(n³)** - Kübik zaman (Matris Çarpımı) ⭐
7. **O(2ⁿ)** - Üstel zaman (Fibonacci recursive)
8. **O(n!)** - Faktöriyel zaman (Permütasyonlar)

---

## 📅 Tarih
Hafta-1 Ödevi

---

