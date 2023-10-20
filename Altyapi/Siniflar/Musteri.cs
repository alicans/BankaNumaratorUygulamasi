using Altyapi.Arabirimler;
using Altyapi.Enumlar;

namespace Altyapi.Siniflar
{
    public class Musteri : IMusteri
    {
        public MusteriTipi MusteriTipi { get; set; }
        public string TcKimlik { get; set; }
        public int Numara { get; set; }
        public bool IslemTamamlandiMi { get; set; }

        public event NumaraDelege NumaratoreGit;

        public int NumaraAl()
        {
            return NumaratoreGit(this);
        }
    }
}
