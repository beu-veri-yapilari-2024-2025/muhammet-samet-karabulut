public class DersBaslikDugumu
{
    public string DersKodu;
    public DersBaslikDugumu SonrakiDers; 
    public NotDugumu IlkOgrenci;         
    public DersBaslikDugumu(string dersKodu)
    {
        this.DersKodu = dersKodu;
        this.SonrakiDers = null;
        this.IlkOgrenci = null;
    }
}