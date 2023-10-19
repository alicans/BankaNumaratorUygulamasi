using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altyapi.Arabirimler
{
    public interface IBanka
    {
        public List<IMusteri> Musteriler { get; set; }
        public INumarator Numarator { get; set; }

    }
}
