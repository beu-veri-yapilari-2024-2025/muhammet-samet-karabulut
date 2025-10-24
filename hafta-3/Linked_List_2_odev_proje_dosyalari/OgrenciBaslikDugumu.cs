public class OgrenciBaslikDugumu
{
    public int OgrenciNumarasi;
    public OgrenciBaslikDugumu SonrakiOgrenci; 
    public NotDugumu IlkDers;                


    public OgrenciBaslikDugumu(int ogrenciNo)
    {
        this.OgrenciNumarasi = ogrenciNo;
        this.SonrakiOgrenci = null;
        this.IlkDers = null;
    }
}