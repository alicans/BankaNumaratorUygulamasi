using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altyapi.Arabirimler
{
    public interface INumarator
    {
        public IMusteri Musteri { get; set; } //Anlık işlemde olan müşteri
        public BindingList<IMusteri> BekleyenMusteriler { get; set; }

        public int VipSayac { get; set; }
        public int GiseSayac { get; set; }
        public int BireyselSayac { get; set; }

        public int NumaraUret(IMusteri Musteri);
        public string SiradakiniGetir();

    }
}
