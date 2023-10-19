using Altyapi.Arabirimler;
using Altyapi.Enumlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altyapi.Siniflar
{
    public class Numarator : INumarator
    {
        public List<IMusteri> BekleyenMusteriler { get; set; }
        public IMusteri Musteri { get; set; }

        public int VipSayac { get; set; } = 400;
        public int GiseSayac { get; set; } = 300;
        public int BireyselSayac { get; set; } = 100;

        public int NumaraUret(IMusteri Musteri)
        {
            if (Musteri.MusteriTipi == MusteriTipi.Vip)
            {
                VipSayac++;
                return VipSayac;
            }
            else if (Musteri.MusteriTipi == MusteriTipi.Gise)
            {
                GiseSayac++;
                return GiseSayac;
            }
            else if (Musteri.MusteriTipi == MusteriTipi.Bireysel)
            {
                BireyselSayac++;
                return BireyselSayac;
            }
            else
                return 0;

        }

        public string SiradakiniGetir()
        {
            StringBuilder sonuc = new StringBuilder();
            
            if (BekleyenMusteriler.Count == 0)
                sonuc.Append("Bekleyen müşteri yoktur");
            else //bekleyen müşteri varsa
            {
                List<IMusteri> vipList = BekleyenMusteriler.Where(mus => mus.MusteriTipi == MusteriTipi.Vip).OrderBy(m => m.Numara).ToList();
                List<IMusteri> vipOlmayanlar = BekleyenMusteriler.Where(mus => mus.MusteriTipi != MusteriTipi.Vip).OrderBy(m => m.Numara).ToList();

                if(vipList.Count > 0) //vip müşteri varsa
                {
                    sonuc.Append("Müşteri türü: " + vipList[0].MusteriTipi + " Numarası: " + vipList[0].Numara + "\n");
                    BekleyenMusteriler.Remove(vipList[0]);
                }
                else if(vipOlmayanlar.Count > 0)
                {
                    sonuc.Append("Müşteri türü: " + vipOlmayanlar[0].MusteriTipi + " Numarası: " + vipOlmayanlar[0].Numara + "\n");
                    BekleyenMusteriler.Remove(vipOlmayanlar[0]);
                }
            }
            return sonuc.ToString();
        }
    }
}
