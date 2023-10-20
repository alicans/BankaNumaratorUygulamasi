using Altyapi.Enumlar;

namespace Altyapi.Arabirimler
{
    //Numaratöre gitmesi OLAYINI TANIMLAYALIM
    public delegate int NumaraDelege(IMusteri musteri);
    
    public interface IMusteri
    {
        public bool IslemTamamlandiMi { get; set; }
        public int NumaraAl();
        public MusteriTipi MusteriTipi { get; set; }
        public string TcKimlik { get; set; }

        public event NumaraDelege NumaratoreGit;
        public int Numara { get; set; }

    }
}
