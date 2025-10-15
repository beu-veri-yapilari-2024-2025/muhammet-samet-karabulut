using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bagli_liste
{
    internal class Program
    {
        //düğüm yapısı
        public class Node
        {
            public int Data; //verimiz
            public Node Next; //sonraki pointerimiz
            public Node(int data) //yapıcı metodu node dönüştürür.
            {
                Data = data;
                Next = null;
            }
        }

        //linked list

        public class BagliList
        {
            private Node head;
            private Node tail;

            public BagliList()
            {
                head = null;
                tail = null;
            }
            
            public void BasaEkle(int value)
            {
                Node newNode = new Node(value); //noda dönüştürür.
                newNode.Next = head;
                head = newNode;
                Console.WriteLine($"{value} başa eklendi");
            }
            public void SonaEkle(int value)
            {
                Node newNode = new Node(value);
                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                    Console.WriteLine($"{value} sona eklendi");
                    return;
                }
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                tail = newNode;
                Console.WriteLine($"{value} sona eklendi");

            }

            //belirli bir değerin sonrasına eleman ekleme
            public void BelirliDegerSonrasiEkle(int arananDeger, int yeniDeger)
            {
                Node current = head;
                while (current != null)
                {
                    if (current.Data == arananDeger)
                    {
                        Node newNode = new Node(yeniDeger);
                        newNode.Next = current.Next;
                        current.Next = newNode;
                        
                        // Eğer son elemandan sonra ekleme yapıldıysa tail'i güncelle
                        if (newNode.Next == null)
                        {
                            tail = newNode;
                        }
                        
                        Console.WriteLine($"{yeniDeger}, {arananDeger} değerinin sonrasına eklendi");
                        return;
                    }
                    current = current.Next;
                }
                Console.WriteLine($"{arananDeger} değeri listede bulunamadı, ekleme yapılamadı");
            }
            //eleman arama
            public void ara(int value) 
            {
                Node current = head;
                while(current != null)
                {
                    if (current.Data == value)
                    {
                        Console.WriteLine($"{value} listede bulunuyor.");
                        return;
                    }
                    current = current.Next;
                }
                Console.WriteLine($"{value} listede bulunmuyor.");
            }
            public void Display()
            {
                if (head == null)
                {
                    Console.WriteLine("Liste boş");
                    return;
                }

                Node current = head;
                Console.Write("Liste: ");

                while (current != null)
                {
                    Console.Write(current.Data + "-->");
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {
            BagliList liste = new BagliList();
            int secim;
            
            do
            {
                Console.WriteLine("\n--- Bağlı Liste İşlemleri ---");
                Console.WriteLine("1. Başa eleman ekle");
                Console.WriteLine("2. Sona eleman ekle");
                Console.WriteLine("3. Belirli değerin sonrasına ekle");
                Console.WriteLine("4. Eleman ara");
                Console.WriteLine("5. Listeyi görüntüle");
                Console.WriteLine("0. Çıkış");
                Console.Write("Seçiminizi yapın: ");
                
                if (int.TryParse(Console.ReadLine(), out secim))
                {
                    switch (secim)
                    {
                        case 1:
                            Console.Write("Başa eklenecek değeri girin: ");
                            if (int.TryParse(Console.ReadLine(), out int basaDeger))
                            {
                                liste.BasaEkle(basaDeger);
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz değer girdiniz!");
                            }
                            break;
                            
                        case 2:
                            Console.Write("Sona eklenecek değeri girin: ");
                            if (int.TryParse(Console.ReadLine(), out int sonaDeger))
                            {
                                liste.SonaEkle(sonaDeger);
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz değer girdiniz!");
                            }
                            break;
                            
                        case 3:
                            Console.Write("Aranan değeri girin: ");
                            if (int.TryParse(Console.ReadLine(), out int arananDeger))
                            {
                                Console.Write("Eklenecek yeni değeri girin: ");
                                if (int.TryParse(Console.ReadLine(), out int yeniDeger))
                                {
                                    liste.BelirliDegerSonrasiEkle(arananDeger, yeniDeger);
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz değer girdiniz!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz değer girdiniz!");
                            }
                            break;
                            
                        case 4:
                            Console.Write("Aranacak değeri girin: ");
                            if (int.TryParse(Console.ReadLine(), out int aranacakDeger))
                            {
                                liste.ara(aranacakDeger);
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz değer girdiniz!");
                            }
                            break;
                            
                        case 5:
                            liste.Display();
                            break;
                            
                        case 0:
                            Console.WriteLine("Programdan çıkılıyor...");
                            break;
                            
                        default:
                            Console.WriteLine("Geçersiz seçim! Lütfen 0-5 arasında bir değer girin.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen sayısal bir değer girin.");
                    secim = -1; // Döngünün devam etmesi için
                }
                
            } while (secim != 0);
        }
    }
}
