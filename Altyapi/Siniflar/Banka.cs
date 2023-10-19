using Altyapi.Arabirimler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altyapi.Siniflar
{
    public class Banka : IBanka
    {
        public List<IMusteri> Musteriler { get; set; }
        public INumarator Numarator { get; set; }
    }
}
